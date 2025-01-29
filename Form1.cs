using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Firebase.Auth;
using System.Net;
using System.IO;
using OfficeOpenXml;
using System.Linq;
using GemBox.Spreadsheet;
using MimeKit;
using System.Threading.Tasks;
using MimeKit.Text;

namespace Emailer
{
    public partial class Form1 : Form
    {
        private IFirebaseConfig config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "*****************************",
            BasePath = "*******************************"
        };
        private Firebase.Auth.FirebaseConfig authConfig;
        private FirebaseAuthProvider authProvider;
        private IFirebaseClient client;
        private List<User> list;
        private string attachment;

        public Form1()
        {
            InitializeComponent();
            list = new List<User>();
            client = new FirebaseClient(config);
        }

        private async void btnLoadEmails_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("Users/");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            if (data != null)
            {
                foreach (dynamic item in data)
                {
                    list.Add(JsonConvert.DeserializeObject<User>(((JProperty)item).Value.ToString()));
                }
                CleanList();
                MessageBox.Show("Data retreived successfully.", "Data retreival", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Retreival unsuccessful.", "Data retreival", MessageBoxButtons.OK);
        }

        private void CleanList()
        {
            List<User> users = new List<User>();
            foreach(var v in list)
            {
                if (!string.IsNullOrEmpty(v.email))
                {
                    if(!users.Contains(v))
                        users.Add(v);
                }
            }
            list.Clear();
            foreach (var s in users)
                list.Add(s);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewEmails_Click(object sender, EventArgs e)
        {
            if(list != null)
            {
                string s = "";
                foreach (User user in list)
                {
                    s += user.GetDetails() + "\n";
                }
                MessageBox.Show(s, "User emails", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("There are no emails loaded.");
            }
        }

        //Send email to each email in the list
        private async void btnSend_Click(object sender, EventArgs e)
        {
            foreach (var user in list) 
            {
                await SendEmail(user.email, user.name, txtSubject.Text, txtBody.Text, isHTML.Checked);
            }
            MessageBox.Show("Emails sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Can send either html or text
        // "_to" is receiver's
        // Can attach files as well
        private async Task SendEmail(string _toEmail, string _toName, string _subject, string _body, bool isHTML, string filePath = "")
        {
            filePath = attachment;
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("########", "##################"));
            email.To.Add(new MailboxAddress(_toName, _toEmail));
            email.Subject = _subject;

            TextPart textPart = new TextPart(isHTML ? TextFormat.Html : TextFormat.Text)
            {
                Text = _body
            };

            if (String.IsNullOrEmpty(filePath))
                email.Body = textPart;

            else
            {
                var multiPart = new Multipart("mixed");
                multiPart.Add(textPart);
                email.Body = multiPart;

                var attachment = new MimePart("image", Path.GetExtension(filePath))
                {
                    Content = new MimeContent(File.OpenRead(filePath), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(filePath)
                };
                multiPart.Add(attachment);
            }

            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.Connect("***********", 25, false);
                smtp.Authenticate("*********", "*******");
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
        }

        private void btnClearEmails_Click(object sender, EventArgs e)
        {
            list.Clear();
            MessageBox.Show("Emails cleared");
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a file";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                attachment = dialog.FileName;
            }
        }
    }
}
