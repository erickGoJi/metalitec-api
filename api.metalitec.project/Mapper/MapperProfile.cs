using api.metalitec.project.Models.Users;
using AutoMapper;
using biz.erpmet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.metalitec.project.Models;
using api.metalitec.project.Models.Catalogue;
using biz.admin.Models;
using biz.erpmet.Repository;

namespace api.metalitec.project.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<BudgetAdvance, BudgetAdvanceDto>().ReverseMap();
            CreateMap<User, UserAddDto>().ReverseMap();
            CreateMap<User, UserReturnDto>().ReverseMap();
            CreateMap<CatRole, CatRoleDto>().ReverseMap();
        }
    }
}
