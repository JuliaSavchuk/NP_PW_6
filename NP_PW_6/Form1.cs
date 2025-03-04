using System.ComponentModel;
using System.Net;
using System.Net.Mail;

namespace NP_PW_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_SendMail_Click(object sender, EventArgs e)
        {
            _ = Task.Run(async () => await SendEmailAsync());
        }

        private async Task SendEmailAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_Adressat.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Theme.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Message.Text))
                {
                    UpdateStatus("Fill in all fields.");
                    return;
                }

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(textBox_Mail_Adress.Text),
                    Subject = textBox_Theme.Text,
                    Body = textBox_Message.Text
                };

                // Додаємо кілька адресатів (через кому)
                string[] recipients = textBox_Adressat.Text.Split(',');
                foreach (string recipient in recipients)
                {
                    mailMessage.To.Add(new MailAddress(recipient.Trim()));
                }

                // Додаємо вкладення
                foreach (var item in listBox_Attachments.Items)
                {
                    mailMessage.Attachments.Add(new Attachment(item.ToString()));
                }

                SmtpClient smtpClient = new SmtpClient
                {
                    Host = textBox_Host.Text,
                    Port = int.Parse(textBox_Port.Text),
                    EnableSsl = true,
                    Credentials = new NetworkCredential(textBox_Mail_Adress.Text, textBox_Password.Text)
                };

                smtpClient.SendCompleted += SmtpClient_SendCompleted;

                UpdateStatus("Sending...");
                await smtpClient.SendMailAsync(mailMessage);
                UpdateStatus("The letter is successfully sent.");
            }
            catch (Exception ex)
            {
                UpdateStatus("Error: " + ex.Message);
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //сообщение успешно отправлено
            if (e.Error != null)
            {
                toolStripLabel_Info.Text = "Error: " + e.Error.Message;
            }
            else
            {
                toolStripLabel_Info.Text = "The letter is successfully sent.";
            }
        }

        private void UpdateStatus(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => toolStripLabel_Info.Text = message));
            }
            else
            {
                toolStripLabel_Info.Text = message;
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    listBox_Attachments.Items.Add(file);
                }
            }
        }
    }
}


//
//try
//{
//    if (string.IsNullOrWhiteSpace(textBox_Adressat.Text) ||
//       string.IsNullOrWhiteSpace(textBox_Theme.Text) ||
//       string.IsNullOrWhiteSpace(textBox_Message.Text))
//    {
//        toolStripLabel_Info.Text = "Fill in all fields.";
//        return;
//    }

//    MailMessage mailMessage = new MailMessage();
//    mailMessage.From = new MailAddress(textBox_Mail_Adress.Text);
//    mailMessage.To.Add(new MailAddress(textBox_Adressat.Text));//многопользовательская рассылка
//    mailMessage.Subject = textBox_Theme.Text;
//    mailMessage.Body = textBox_Message.Text;

//    SmtpClient smtpClient = new SmtpClient();
//    smtpClient.Host = textBox_Host.Text;
//    smtpClient.Port = int.Parse(textBox_Port.Text);//995
//    smtpClient.EnableSsl = true;
//    smtpClient.Credentials = new NetworkCredential(textBox_Mail_Adress.Text, textBox_Password.Text);
//    smtpClient.SendCompleted += SmtpClient_SendCompleted;
//    smtpClient.Send(mailMessage);
//}
//catch (Exception ex)
//{
//    toolStripLabel_Info.Text = ex.Message;
//}
