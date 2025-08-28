namespace EmailHandler.Email;

public class EmailModel
{
    public int Id { get; set; }
    public string From { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public DateTime DateReceived { get; set; }
    public bool IsRead { get; set; }
}
