using biz.erpmet.Model;
using biz.erpmet.Repository.User;
using dal.erpmet.DBContext;
using dal.erpmet.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.erpmet.Repository.User
{
    public class UserRepository : GenericRepository<Usuario>, IUserRepository
    {
        public UserRepository(ERPMETContext context) : base(context)
        {
        }
    }
}
