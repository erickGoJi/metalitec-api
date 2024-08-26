using biz.admin.Repository.Generic;

namespace biz.admin.Repository.User
{
    public interface IUserRepository: IGenericRepository<Models.User>
    {
        string HashPassword(string password);
        bool VerifyPassword(string hash, string password);
        string BuildToken(Models.User user);
        string SendMail(string emailTo, string body, string subject);

    }
}