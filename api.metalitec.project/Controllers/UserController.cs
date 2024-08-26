using api.metalitec.project.Models.ApiResponse;
using api.metalitec.project.Models.Users;
using AutoMapper;
using biz.erpmet.Repository.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using api.metalitec.project.ActionFilter;
using api.metalitec.project.Services.Logger;
using biz.admin.Models;
using NLog;
using NPOI.SS.Formula.Functions;

namespace api.metalitec.project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly biz.admin.Repository.User.IUserRepository _userRepository;
        private readonly ILoggerManager _logger;

        public UserController(
            IMapper mapper,
            biz.admin.Repository.User.IUserRepository userRepository,
            ILoggerManager logger)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _logger = logger;
        }
        /// <summary>
        /// Retorna un Usuario especifico por Id
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}", Name = "GetById")]
        [ServiceFilterAttribute(typeof(ValidationFilterAttribute))]
        public async Task<ActionResult<ApiResponse<UserReturnDto>>> GetById(int id)
        {
            var response = new ApiResponse<UserReturnDto>();

            try
            {
                response.Result = _mapper.Map<UserReturnDto>(await _userRepository.GetAsync(id));
            }
            catch (Exception ex)
            {
                response.Result = null;
                response.Success = false;
                response.Message = "Internal server error";
                //_logger.LogError($"Something went wrong: { ex.ToString() }");
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        /// <summary>
        /// Retorna una lista de todos los usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("All", Name = "GetAllUsers")]
        public ActionResult<ApiResponse<List<UserAddDto>>> GetAllUsers()
        {
            var response = new ApiResponse<List<UserAddDto>>();

            try
            {
                response.Result = _mapper.Map<List<UserAddDto>>(_userRepository.GetAll());
            }
            catch (Exception ex)
            {
                response.Result = null;
                response.Success = false;
                response.Message = $"Something went wrong: { ex.Message }";
                _logger.LogError($"Something went wrong: { ex.ToString() }");
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        /// <summary>
        /// Agregar un nuevo usuario
        /// </summary>
        /// <param name="userAddDto">
        ///
        /// </param>
        /// <returns></returns>
        [HttpPost]
        [Route("New-User", Name = "NewUser")]
        [ServiceFilterAttribute(typeof(ValidationFilterAttribute))]
        public async Task<ActionResult<ApiResponse<UserAddDto>>> Create([FromBody] UserAddDto userAddDto)
        {
            var response = new ApiResponse<UserAddDto>();

            try
            {
                if (await _userRepository.ExistsAsync(c => c.Email == userAddDto.Email))
                {
                    response.Success = false;
                    response.Message = $"Email: { userAddDto.Email } Already Exists";
                    return BadRequest(response);
                }

                var guid = "Metalitec00$";
                userAddDto.Password = _userRepository.HashPassword("$" + guid);
                
                StreamReader reader = new StreamReader(Path.GetFullPath("TemplateMail/Email.html"));
                string body = string.Empty;
                body = reader.ReadToEnd();
                body = body.Replace("{name}", $"{userAddDto.Name} {userAddDto.LastName} {userAddDto.MotherLastName}");
                body = body.Replace("{username}", $"{userAddDto.Email}");
                body = body.Replace("{pass}", " $" + guid);

                _userRepository.SendMail(userAddDto.Email, body, "Accesos a Administrador");
                response.Message = "User added successfully.";
                response.Success = true;
                response.Result = _mapper.Map<UserAddDto>(await _userRepository.AddAsync(_mapper.Map<User>(userAddDto)));
            }
            catch (Exception ex)
            {
                response.Result = null;
                response.Success = false;
                response.Message = "Internal server error";
                _logger.LogError($"Something went wrong: { ex.Message }");
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        /// <summary>
        /// Editar Usuario
        /// </summary>
        /// <param name="userAddDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Edit-User", Name = "EditUser")]
        [ServiceFilterAttribute(typeof(ValidationFilterAttribute))]
        public async Task<ActionResult<ApiResponse<UserAddDto>>> Edit([FromBody] UserAddDto userAddDto)
        {
            var response = new ApiResponse<UserReturnDto>();
            try
            {
                if (await _userRepository.ExistsAsync(e=>e.Id == userAddDto.Id))
                {
                    var data = await _userRepository.FindAsync(f => f.Id == userAddDto.Id);
                    data.Avatar = userAddDto.Avatar;
                    data.Email = userAddDto.Email;
                    data.Name = userAddDto.Name;
                    data.LastName = userAddDto.LastName;
                    data.MotherLastName = userAddDto.MotherLastName;
                    data.Phone = userAddDto.Phone;
                    data.RoleId = userAddDto.RoleId;
                    data.MobilePhone = userAddDto.MobilePhone;
                    data.UpdatedBy = userAddDto.UpdatedBy;
                    data.UpdatedDate = DateTime.Now;
                    response.Message = "User updated successfully";
                    response.Result = _mapper.Map<UserReturnDto>(await _userRepository.UpdateAsync(data, data.Id));

                }
                else
                {
                    response.Success = false;
                    response.Message = $"User: { userAddDto.Email } Not Exists";
                    return BadRequest(response);
                }
            }
            catch (Exception ex)
            {
                response.Result = null;
                response.Success = false;
                response.Message = "Internal server error";
                _logger.LogError($"Something went wrong: { ex.Message }");
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        
        /// <summary>
        /// Verificar si el correo existe
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns></returns>
        [HttpGet("Verify-Email", Name = "VerifyEmail")]
        public ActionResult VerifyEmail(string email)
        {
            var response = new ApiResponse<dynamic>();

            try
            {
                if (_userRepository.Exists(e => e.Email == email))
                {
                    response.Success = false;
                    response.Message = "The email already exists.";
                    response.Result = email;
                }
                else 
                {
                    response.Success = true;
                    response.Message = "Email not exist.";
                    response.Result = email;
                }

            }
            catch (Exception ex)
            {
                response.Result = null;
                response.Success = false;
                response.Message = "Internal server error";
                _logger.LogError($"Something went wrong: { ex.Message }");
                return StatusCode(500, response);
            }

            return Ok(response);
        }
        
        /// <summary>
        /// Login para acceder a Admin Web
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="password">Contraseña</param>
        /// <returns></returns>
        [HttpPost("Login", Name = "Login")]
        public async Task<ActionResult<ApiResponse<UserReturnDto>>> Login(string email, string password)
        {
            var response = new ApiResponse<UserReturnDto>();

            try
            {
                var user =  _mapper.Map<User>(await _userRepository.FindAsync(c => c.Email == email));
                if (user != null)
                {
                    if (_userRepository.VerifyPassword(user.Password, password))
                    {
                        response.Result = _mapper.Map<UserReturnDto>(user);
                        response.Result.Token = _userRepository.BuildToken(user);
                        response.Success = true;
                        response.Message = "success";
                    }
                    else
                    {
                        response.Success = false;
                        response.Message = "User or password incorrect";

                    }
                }
                else
                {
                    response.Success = false;
                    response.Message = "User or password incorrect";

                }

            }
            catch (Exception ex)
            {
                response.Result = null;
                response.Success = false;
                response.Message = "Internal server error";
                _logger.LogError($"Something went wrong: { ex.ToString() }");
                return StatusCode(500, response);
            }

            return Ok(response);
        }
        
        /// <summary>
        /// Eliminar Usuario por el ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ActionResult<ApiResponse<bool>>> Delete([FromQuery] int id)
        {
            var response = new ApiResponse<bool>();

            try
            {
                if (await _userRepository.ExistsAsync(e=>e.Id==id))
                {
                    var user = await _userRepository.GetAsync(id);
                    await _userRepository.DeleteAsync(user);
                    response.Result = true;
                    response.Success = true;
                    response.Message = "User was removed successfully";
                }
                else
                {
                    response.Result = false;
                    response.Success = false;
                    response.Message = "User Not Exist";
                    return NotFound(response);
                }
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Success = false;
                response.Message = "Internal server error";
                //_logger.LogError($"Something went wrong: { ex.ToString() }");
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        
        /// <summary>
        ///  Recuperar contraseña
        /// </summary>
        /// <param name="email">Correo</param>
        /// <returns></returns>
        [HttpPut("Recovery-Password", Name = "Recovery_password")]
        public async Task<ActionResult<ApiResponse<UserReturnDto>>> Recovery_password(string email)
        {
            var response = new ApiResponse<UserReturnDto>();

            try
            {
                var _user = _mapper.Map<User>(await _userRepository.FindAsync(c => c.Email == email));

                if (_user != null)
                {

                    var guid = Guid.NewGuid().ToString().Substring(0, 7);
                    var password = _userRepository.HashPassword("$" + guid);

                    _user.Password = password;
                    _user.Reset = true;
                    _user.UpdatedBy = _user.Id;
                    _user.UpdatedDate = DateTime.Now;
                    
                    await _userRepository.UpdateAsync(_mapper.Map<User>(_user), _user.Id);

                    StreamReader reader = new StreamReader(Path.GetFullPath("TemplateMail/Email.html"));
                    string body = string.Empty;
                    body = reader.ReadToEnd();
                    body = body.Replace("{user}", _user.Name + " " + _user.LastName + " " + _user.MotherLastName);
                    body = body.Replace("{username}", $"{_user.Email}");
                    body = body.Replace("{pass}", "$" + guid);

                    _userRepository.SendMail(_user.Email, body, "Recovery password");

                    response.Result = _mapper.Map<UserReturnDto>(_user);
                    response.Success = true;
                    response.Message = "success";
                }
                else
                {
                    response.Success = false;
                    response.Message = "Hubo un error";

                }

            }
            catch (Exception ex)
            {
                response.Result = null;
                response.Success = false;
                response.Message = ex.ToString();
                _logger.LogError($"Something went wrong: { ex.ToString() }");
                return StatusCode(500, response);
            }

            return Ok(response);
        }
        
        /// <summary>
        /// Cambiar Contraseña
        /// </summary>
        /// <param name="email">Correo</param>
        /// <param name="password">Contraseña</param>
        /// <returns></returns>
        [HttpPut("Change-Password", Name = "Change_password")]
        public ActionResult<ApiResponse<UserReturnDto>> Change_password(string email, string password)
        {
            var response = new ApiResponse<UserReturnDto>();

            try
            {
                var _user = _mapper.Map<User>(_userRepository.Find(c => c.Email == email));

                if (_user != null)
                {
                    var guid = Guid.NewGuid().ToString().Substring(0, 7);
                    var passwordNew = _userRepository.HashPassword(password);

                    _user.Password = passwordNew;
                    _user.UpdatedBy = _user.Id;
                    _user.UpdatedDate = DateTime.Now;
                    _user.Reset = false;
                    _userRepository.Update(_mapper.Map<User>(_user), _user.Id);

                    response.Result = _mapper.Map<UserReturnDto>(_user);
                    response.Result.Token = _userRepository.BuildToken(_user);
                    response.Success = true;
                    response.Message = "success";
                }
                else
                {
                    response.Success = false;
                    response.Message = "Usuario y/o contraseña incorrecta";

                }

            }
            catch (Exception ex)
            {
                response.Result = null;
                response.Success = false;
                response.Message = "Internal server error";
                _logger.LogError($"Something went wrong: { ex.ToString() }");
                return StatusCode(500, response);
            }

            return Ok(response);
        }

    }
}
