namespace BLL.Interfaces
{
    /// <summary>
    /// Send Mail
    /// </summary>
    public interface IEmail
    {
        void BuildMail(string content);
        void SendMail(string receipient, string subject);
    }
}
