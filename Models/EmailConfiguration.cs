public interface IEmailConfiguration
{
	string SMTPServer { get; }
	int SMTPPort { get; }
	string SMTPUsername { get; set; }
	string SMTPPassword { get; set; }
}

public class EmailConfiguration : IEmailConfiguration
{
	public string SMTPServer { get; set; }
	public int SMTPPort  { get; set; }
	public string SMTPUsername { get; set; }
	public string SMTPPassword { get; set; }
}