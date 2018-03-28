
#region NameSpace
    using System;
    using System.IO;
    using System.Web;
    using System.Text;
    using System.Data;
    using System.Configuration;
    using System.Security.Cryptography;
    using System.Net.Mail;
#endregion NameSpace

namespace PICountDesktopApp.BAL
{
    public class Common
    {
        #region Constants

        public const int NEWS_EVENTS = 1;
        public const int CORPORATE_FINANCE = 2;
        public const int GCC = 3;
        public const int MAILING_LIST = 4;
        public const int CLIENTS = 5;
        public const int FUNDS = 6;
        public const int OVERALL_ADMINISTRATION = 7;
        public const int ASSETS = 8;

        #endregion Constants

        #region Public Properties

        /// <summary>
        /// Privilege
        /// </summary>
        public static string Privilege
        {
            set;
            get;
        }

        /// <summary>
        /// Emp Id
        /// </summary>
        public static string UserId
        {
            set;
            get;
        }

        /// <summary>
        /// Location
        /// </summary>
        public static string Location
        {
            set;
            get;
        }

        /// <summary>
        /// WorkSheets
        /// </summary>
        public static int WorkSheets
        {
            set;
            get;
        }

        /// <summary>
        /// Files
        /// </summary>
        public static int Files
        {
            set;
            get;
        }

        #endregion Public Properties

        #region Methods

        #region LogException
        /// <summary>
        /// Log Exception/Errors
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="methodName"></param>
        /// <param name="message"></param>
        //public static void LogException(string fileName, string methodName, string message)
        //{
        //    try
        //    {
        //        string path = HttpContext.Current.Server.MapPath("~/ErrorLogging/");
        //        // check if directory exists
        //        if (!Directory.Exists(path))
        //        {
        //            Directory.CreateDirectory(path);
        //        }
        //        path = path + DateTime.Today.ToString("dd-MMM-yy") + ".log";
        //        // check if file exist
        //        if (!File.Exists(path))
        //        {
        //            File.Create(path).Dispose();
        //        }
        //        // log the error now
        //        using (StreamWriter writer = File.AppendText(path))
        //        {
        //            string error = "\r\nLog written at : " + DateTime.Now.ToString() +
        //            "\r\nError occured on page : " + HttpContext.Current.Request.Url.ToString() +
        //            "\r\nError occured on page : " + methodName.ToString() +
        //            "\r\n\r\nHere is the actual error :\n" + message.ToString();
        //            writer.WriteLine(error);
        //            writer.WriteLine("==========================================");
        //            writer.Flush();
        //            writer.Close();
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        #endregion LogException

        #region CreateHash
        /// <summary>
        /// Create Hashed Values (Eg: for password)
        /// </summary>
        /// <param name="unHashed">unhashed string</param>
        /// <returns>hashed string</returns>
        public static string CreateHash(string unHashed)
        {
            string s = "";
            try
            {
                MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
                byte[] data = System.Text.Encoding.ASCII.GetBytes(unHashed);
                data = x.ComputeHash(data);
                s = Encoding.ASCII.GetString(data);
            }
            catch (Exception e)
            {
                //LogException("Common.cs", "BAL/Common.cs/CreateHash", e.Message);
            }
            return s;
        }
        #endregion CreateHash

        #region MatchHash
        /// <summary>
        /// Match hashed value with user input
        /// </summary>
        /// <param name="HashData">hashed data</param>
        /// <param name="HashUserInput">user input</param>
        /// <returns></returns>
        public static bool MatchHash(string HashData, string HashUserInput)
        {
            bool flag = false;
            try
            {
                HashUserInput = CreateHash(HashUserInput);

                if (HashUserInput == HashData)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception e)
            {
                //LogException("Common.cs", "BAL/Common.cs/MatchHash", e.Message);
            }
            return flag;
        }
        #endregion MatchHash

        #region SendMail
        /// <summary>
        /// send mail
        /// </summary>
        /// <param name="toAddress"></param>
        /// <param name="subject"></param>
        /// <param name="messageBody"></param>
        public static void SendMail(string toAddress, string subject, string messageBody)
        {
            string from = (null != ConfigurationManager.AppSettings["emailSenderId"])
               ? ConfigurationManager.AppSettings["emailSenderId"].ToString() : "";
            string smtpServer = (null != ConfigurationManager.AppSettings["smtpServer"])
               ? ConfigurationManager.AppSettings["smtpServer"].ToString() : "";
            int port = (null != ConfigurationManager.AppSettings["smtpPort"])
               ? Convert.ToInt32(ConfigurationManager.AppSettings["smtpPort"]) : 0;
            string userName = (null != ConfigurationManager.AppSettings["smtpUserName"])
               ? ConfigurationManager.AppSettings["smtpUserName"].ToString() : "";
            string password = (null != ConfigurationManager.AppSettings["smtpPassword"])
               ? ConfigurationManager.AppSettings["smtpPassword"].ToString() : "";

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(from);
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = messageBody;


            try
            {

                SmtpClient SmtpServer = new SmtpClient(smtpServer);
                SmtpServer.Port = port;
                SmtpServer.Host = (null != ConfigurationManager.AppSettings["smtpHost"])
               ? ConfigurationManager.AppSettings["smtpHost"].ToString() : "";
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(userName, password);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                // LogException("Common.cs", "SendMail", ex.Message);
            }

        }

        #endregion SendMail


        #region Base64Encode
        /// <summary>
        /// Base64Encode
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        #endregion Base64Encode


        #region Base64Decode
        // For Decoding

        public static string Base64Decode(string base64EncodedData)
        {
            object misValue = System.Reflection.Missing.Value;

            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        #endregion Base64Decode

        #endregion Methods
    }
}
