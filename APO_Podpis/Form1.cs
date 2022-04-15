using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;
using System.IO;
using System.Security.Cryptography;


namespace APO_Podpis
{
    public partial class Form1 : Form
    {
        static string pathFileAdd, pathSignAdd, pathKeyAdd, pathFileLoad, pathSignLoad, pathKeyLoad, pathFileCipher;

        private void addSignButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loaddoc = new OpenFileDialog();
            if (loaddoc.ShowDialog() == DialogResult.OK)
            {
                pathSignAdd = loaddoc.FileName;
                MessageBox.Show("Подпись добавлена к письму");
            }
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loaddoc = new OpenFileDialog();
            if (loaddoc.ShowDialog() == DialogResult.OK)
            {
                pathFileLoad = loaddoc.FileName;
                MessageBox.Show("Файл для проверки добавлен");
            }
        }

        private void LoadSignButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loaddoc = new OpenFileDialog();
            if (loaddoc.ShowDialog() == DialogResult.OK)
            {
                pathSignLoad = loaddoc.FileName;
                MessageBox.Show("Подпись для проверки добавлена");
            }
        }

        private void LoadKeyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loaddoc = new OpenFileDialog();
            if (loaddoc.ShowDialog() == DialogResult.OK)
            {
                pathKeyLoad = loaddoc.FileName;
                MessageBox.Show("Ключ для проверки добавлен");
            }
        }

        private void chekFileButton_Click(object sender, EventArgs e)
        {
            string contentfile = File.ReadAllText(pathFileLoad).GetHashCode().ToString();
            byte[] hash = Encoding.UTF8.GetBytes(contentfile);
            SHA256 sha256 = new SHA256Managed();
            hash = sha256.ComputeHash(hash);
            string sign = File.ReadAllText(pathSignLoad);
            byte[] signhash = Convert.FromBase64String(sign);
            RSA rsa = RSA.Create();
            rsa.FromXmlString(File.ReadAllText(pathKeyLoad));
            RSAPKCS1SignatureDeformatter rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
            rsaDeformatter.SetHashAlgorithm("SHA256");
            if (rsaDeformatter.VerifySignature(hash, signhash))
            {
                MessageBox.Show("Подпись совпадает, файл не был исправлен");
            }
            else
            {
                MessageBox.Show("Кто-то менял файл!");
            }
        }

        private void addKeyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loaddoc = new OpenFileDialog();
            if (loaddoc.ShowDialog() == DialogResult.OK)
            {
                pathKeyAdd = loaddoc.FileName;
                MessageBox.Show("Публичный ключ добавлен к письму");
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        public async Task sendEmail()
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Program", "test0l5b3u@pepisandbox.com"));
            email.To.Add(new MailboxAddress("Max", "kurpyakov97@yandex.ru"));
            email.Subject = "Laba";
            var builder = new BodyBuilder();
            builder.TextBody = "Check this file";
            builder.Attachments.Add(pathFileAdd);
            builder.Attachments.Add(pathSignAdd);
            builder.Attachments.Add(pathKeyAdd);
            email.Body = builder.ToMessageBody();
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.netcorecloud.net", 587, MailKit.Security.SecureSocketOptions.None);
                await client.AuthenticateAsync("test0l5b3u", "test0l5b3u_eb96c43159b0c54cb4f306802c9857fa");
                await client.SendAsync(email);
                await client.DisconnectAsync(true);
            }
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            sendEmail();
            MessageBox.Show("Письмо отправлено");
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loaddoc = new OpenFileDialog();
            if (loaddoc.ShowDialog() == DialogResult.OK)
            {
                pathFileAdd = loaddoc.FileName;
                MessageBox.Show("Файл добавлен к письму");
            }
        }

        private void cipherFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loaddoc = new OpenFileDialog();
            if (loaddoc.ShowDialog() == DialogResult.OK)
            {
                pathFileCipher = loaddoc.FileName;
                string contentfile = File.ReadAllText(pathFileCipher).GetHashCode().ToString();
                byte[] hash = Encoding.UTF8.GetBytes(contentfile);
                SHA256 sha256 = new SHA256Managed();
                hash = sha256.ComputeHash(hash);
                byte[] signhash;
                RSA rsa = RSA.Create();
                RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                rsaFormatter.SetHashAlgorithm("SHA256");
                signhash = rsaFormatter.CreateSignature(hash);
                string signedText = Convert.ToBase64String(signhash);
                StreamWriter sr = new StreamWriter("sign.txt", false);
                sr.WriteLine(signedText);
                sr.Close();
                string publickey = rsa.ToXmlString(false);
                StreamWriter sr1 = new StreamWriter("key.pub", false);
                sr1.WriteLine(publickey);
                sr1.Close();
                MessageBox.Show("Файл зашифрован и подписан");
            }
        }
    }
}
