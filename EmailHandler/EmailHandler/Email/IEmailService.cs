namespace EmailHandler.Email;

public interface IEmailService
{
    EmailModel[] GetSince(DateTime date);
    void Forward(int emailId, string toAddress);
    void MoveToFolder(int emailId, string folderName);
}
