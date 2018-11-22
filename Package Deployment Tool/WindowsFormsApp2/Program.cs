using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aras.IOM;
using System.Collections;
using System.IO;
using System.Xml;

namespace WindowsFormsApp2
{
    static class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        internal static HttpServerConnection login(string ArasURL, string DataBaseName, string userid, string usePass)
        {

            String[] urlarray = ArasURL.Split('/');

            String ServerName = urlarray[2];
            String Site = urlarray[3];

            String url = @"http://" + ServerName + "/" + Site;
            //String url = ArasURL;
            String db = DataBaseName;
            String user = userid;
            String password = usePass;

            //conn.
            HttpServerConnection conn = IomFactory.CreateHttpServerConnection(url, db, user, password);
            
            Item login_result = conn.Login();
            if (login_result.isError())
            {
                //return null;
                MessageBox.Show(login_result.getErrorString().Replace("SOAP-ENV:ServerAuthentication failed for admin", ""), "Login Failed");
                //throw new Exception("Login failed :-" + login_result.getErrorString());
            }

            return conn;
        }
        internal static Aras.IOM.HttpServerConnection login()
        {
            return null; ;
        }

    }
}
