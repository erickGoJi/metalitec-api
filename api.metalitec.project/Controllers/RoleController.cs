using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.metalitec.project.Models.ApiResponse;
using api.metalitec.project.Models.Catalogue;
using api.metalitec.project.Models.Users;
using api.metalitec.project.Services.Logger;
using AutoMapper;
using biz.admin.Models;
using biz.admin.Repository.CatRole;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace api.metalitec.project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly ICatRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public RoleController(ICatRoleRepository roleRepository, IMapper mapper, ILoggerManager logger)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
            _logger = logger;
        }
        /// <summary>
        /// Obtener todos los Roles
        /// </summary>
        /// <returns></returns>
        [Route("All", Name = "AllRoles")]
        [HttpGet]
        public ActionResult<ApiResponse<List<CatRoleDto>>> GetAllUsers()
        {
            var response = new ApiResponse<List<CatRoleDto>>();

            try
            {
                response.Result = _mapper.Map<List<CatRoleDto>>(_roleRepository.GetAll());
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
        /// Obtener el Rol por ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [Route("{id}", Name = "GetRoleById")]
        [HttpGet]
        public ActionResult<ApiResponse<CatRoleDto>> GetRoleById(int id)
        {
            var response = new ApiResponse<CatRoleDto>();

            try
            {
                response.Result = _mapper.Map<CatRoleDto>(_roleRepository.Find(f => f.Id == id));
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
        /// Agregar nuevo Role
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [Route("Add", Name = "AddRole")]
        [HttpPost]
        public async Task<ActionResult<ApiResponse<CatRoleDto>>> AddRole([FromBody] CatRoleDto dto)
        {
            var response = new ApiResponse<CatRoleDto>();

            try
            {
                response.Result = _mapper.Map<CatRoleDto>(await _roleRepository.AddAsync(_mapper.Map<CatRole>(dto)));
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
        /// Editar un Role
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [Route("Edit", Name = "EditRole")]
        [HttpPut]
        public async Task<ActionResult<ApiResponse<CatRoleDto>>> EditRole([FromBody] CatRoleDto dto)
        {
            var response = new ApiResponse<CatRoleDto>();

            try
            {
                if (await _roleRepository.ExistsAsync(e=>e.Id==dto.Id))
                {
                    dto.UpdatedDate = DateTime.Now;
                    response.Result = _mapper.Map<CatRoleDto>(await _roleRepository.UpdateAsync(_mapper.Map<CatRole>(dto), dto.Id));
                }
                else
                {
                    response.Result = null;
                    response.Success = false;
                    response.Message = $"Role not exist: {dto.Role}";
                    return NotFound(response);
                }


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
        /// Eliminar Role por ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [Route("Delete/{id}", Name = "DeleteRole")]
        [HttpDelete]
        public async Task<ActionResult<ApiResponse<CatRoleDto>>> DeleteRole(int id)
        {
            var response = new ApiResponse<CatRoleDto>();

            try
            {
                if (await _roleRepository.ExistsAsync(e=>e.Id==id))
                {
                    var role = await _roleRepository.FindAsync(f => f.Id == id);
                    await _roleRepository.DeleteAsync(role);
                    response.Result = _mapper.Map<CatRoleDto>(role);
                }
                else
                {
                    response.Result = null;
                    response.Success = false;
                    response.Message = $"Role not exist ";
                    return NotFound(response);
                }


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
        
    }
}