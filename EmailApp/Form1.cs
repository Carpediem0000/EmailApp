using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace EmailApp
{
    public partial class Form1 : Form
    {
        private SmtpClient _smtpClient;
        private MailMessage _message;
        private IConfiguration Configuration { get; }
        public Form1()
        {
            InitializeComponent();

            string currentDirectory = Directory.GetCurrentDirectory();

            string parentDirectory = Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName;

            var builder = new ConfigurationBuilder()
                .SetBasePath(parentDirectory)
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(Configuration["EmailSettings:Username"], Configuration["EmailSettings:Password"]),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            tb_From.Text = Configuration["EmailSettings:Username"];
        }

        private void tb_To_TextChanged(object sender, EventArgs e)
        {
            btn_Send.Enabled = !string.IsNullOrEmpty(tb_To.Text);
        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog.FileName);
                lbl_FileName.Text = file.Name;
                lbl_FileName.Tag = file.FullName;
                
                btn_Attach.Enabled = false;
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                _message = new MailMessage();

                _message.From = new MailAddress(Configuration["EmailSettings:Username"]);
                _message.To.Add(new MailAddress(tb_To.Text));

                _message.Subject = tb_Title.Text;
                _message.Body = tb_Message.Text;

                if (!string.IsNullOrEmpty(lbl_FileName.Text))
                {
                    _message.Attachments.Add(new Attachment(lbl_FileName.Tag as string));
                }

                _smtpClient.Send(_message);
                MessageBox.Show("Email sent successfully!");

                lbl_FileName.Text = string.Empty;
                tb_To.Text = string.Empty;
                tb_Title.Text = string.Empty;
                tb_Message.Text = string.Empty;
                btn_Attach.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}");
            }
        }
    }
}
