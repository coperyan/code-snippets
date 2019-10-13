//This uses the EASendMail Package (trial)

private void SendEmail()
{
  string body = "This is a test email.";
  string filepath = @"C:\Users\Administrator\Desktop\File.txt";
  string subject = "Test Email";
  string email1 = "test@email123.com";
  string email2 = "test@email456.com";
  string myemail = "myemail@myemail.com";
  string myemailpass = "myemailpassword";

  //Create outlook instance
  SmtpMail oMail = new SmtpMail("TryIt");
  SmtpClient oSmtp = new SmtpClient();

  //Add from email
  oMail.From = myemail;

  //Add recipients
  oMail.To.Add(new MailAddress(email1));
  oMail.To.Add(new MailAddress(email2));

  //Adding subject and body
  oMail.Subject = subject;
  oMail.TextBody = body;

  //Setting server for Outlook 365
  SmtpServer oServer = new SmtpServer("outlook.office365.com");

  //Adding creds
  oServer.User = myemail;
  oServer.Password = myemailpass;

  //Setting port and connection type
  oServer.Port = 587;
  oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

  //Adding attchment
  oMail.AddAttachment(filepath);
  oSmtp.SendMail(oServer,oMail);

}
