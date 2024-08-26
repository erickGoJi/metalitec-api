using biz.admin.Repository.CatRole;
using dal.admin.DBContext;
using dal.admin.Repository.Generic;

namespace dal.admin.Repository.CatRole
{
    public class CatRoleRepository:GenericRepository<biz.admin.Models.CatRole>,ICatRoleRepository
    {
        public CatRoleRepository(MetalitecDataContext context):base(context){}
    }
}