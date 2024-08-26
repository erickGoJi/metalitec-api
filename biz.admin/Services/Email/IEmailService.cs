namespace biz.admin.Services.Email
{
    public interface IEmailService
    {
        string SendEmail(EmailModel email);
    }
}