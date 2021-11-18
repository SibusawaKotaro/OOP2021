using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{

    public partial class Form1 : Form
    {

        private ConfigForm configForm = new ConfigForm();
        private Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
            var filepass = @"./settings.xml";
            if (!File.Exists(filepass) ) {
                configForm.ShowDialog();
            }

        }
          
            
   

        private Settings setting = Settings.getInstance();



        private void btSend_Click(object sender, EventArgs e)
        {
            try {
                btSend.Enabled = false;
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(setting.MailAddr);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);

                if (tbCc.Text != ""){
                    mailMessage.CC.Add(tbCc.Text);
                }
                
                if (tbBcc.Text != ""){
                    mailMessage.Bcc.Add(tbBcc.Text);
                }
                
               
                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                if (tbMessage.Text.Trim() == "") {
                    MessageBox.Show("本文が未入力です");
                    btSend.Enabled = true;
                    return;
                }
                else {
                    mailMessage.Body = tbMessage.Text;
                }



                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報（ユーザー名、パスワード）




                smtpClient.Credentials
                    = new NetworkCredential(settings.MailAddr,settings.Pass);
                smtpClient.Host = setting.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                //smtpClient.Send(mailMessage);

                

                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                string userState = "SendMail";

                
                smtpClient.SendAsync(mailMessage, userState);
                



            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message);
            }else{
                MessageBox.Show("送信完了");
                tbTo.Text = null;
                tbTitle.Text = null;
                tbMessage.Text = null;
            }
            btSend.Enabled = true;

        }

        private void btChange_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e) {
            try {
                if (File.Exists(@"./settings.xml")) {
                    using (var reader = XmlReader.Create(@"./settings.xml")) {

                        var serializer = new DataContractSerializer(typeof(Settings));
                        var readSetting = serializer.ReadObject(reader) as Settings;

                        settings.Host = readSetting.Host;
                        settings.Port = readSetting.Port;
                        settings.MailAddr = readSetting.MailAddr;
                        settings.Pass = readSetting.Pass;
                        settings.Ssl = readSetting.Ssl;

                    }
                }
            }
            catch (Exception ) {
                MessageBox.Show("xmlが正しくありません");
                configForm.ShowDialog();
            }
            
        }

        
    }
}