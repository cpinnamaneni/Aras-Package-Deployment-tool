using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Aras.IOM;
using System.IO;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateLoginDialog();
        }
        private void updateLoginDialog()
        {
            System.Configuration.AppSettingsReader config = new AppSettingsReader();
           
            string value = ConfigurationManager.AppSettings["url"];
            url.Text = value;
            string Userid = ConfigurationManager.AppSettings["userid"];
            user_id.Text = Userid;
            string Database = ConfigurationManager.AppSettings["database"];
            database.Text = Database;
            string logpath = ConfigurationManager.AppSettings["logpath"];
            log_path.Text = logpath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show(fbd.SelectedPath);
                inn_fold_path.Text = fbd.SelectedPath;
            }
        }

        private void button_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        HttpServerConnection conn = null;

        private void button2_login_Click(object sender, EventArgs e)
        {
            String ArasURL = url.Text;
            String userid = user_id.Text;
            string DataBaseName = database.Text;
            String usePass = password.Text;
            

            if (String.IsNullOrEmpty(ArasURL) || String.IsNullOrEmpty(DataBaseName) || String.IsNullOrEmpty(usePass) || String.IsNullOrEmpty(userid))
            {
                MessageBox.Show("Please provide all the information to login");
            }

            conn = Program.login(ArasURL, DataBaseName, userid, usePass);
            if (conn != null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["url"].Value = url.Text;
                config.AppSettings.Settings["database"].Value = database.Text;
                config.AppSettings.Settings["userid"].Value = user_id.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form actfrm = Form1.ActiveForm;
           
            var currcursor = actfrm.Cursor;
            actfrm.Cursor = System.Windows.Forms.Cursors.AppStarting;
            //actfrm.Cursor = System.Windows.Forms.Cursor ;
            if (conn != null)
            {
                conn.Logout();
            }
            database.Items.Clear();
            String ArasURL = url.Text;
            if(String.IsNullOrEmpty(ArasURL))
            {
                MessageBox.Show("Enter URL...");
                return;
            }
            String[] urlarray = ArasURL.Split('/');

            String ServerName = urlarray[2];
            String Site = urlarray[3];

            String urlval = @"http://" + ServerName + "/" + Site;

            HttpServerConnection conn1 = IomFactory.CreateHttpServerConnection(urlval);
            String[] DBNames = conn1.GetDatabases();

            foreach(String DBName in DBNames)
            {
                database.Items.Add(DBName);
            }
            actfrm.Cursor = currcursor;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("closing");
            if(conn != null)
            {
                conn.Logout();
            }
        }

        private void execute_Click(object sender, EventArgs e)
        {

            if (conn == null)
            {
                MessageBox.Show("Please Login Before Execute the import");
                return;
            }

            Innovator inn = IomFactory.CreateInnovator(conn);
            //---------------Get the User info -----------------------
            String ArasURL = url.Text;
            String userid = user_id.Text;
            string DataBaseName = database.Text;
            String usePass = password.Text;
            string mfpath = path.Text;
            String logpath = log_path.Text;
            String relnum = "2.4";
            StringBuilder output = new StringBuilder();
            output.AppendLine("Started Importing the Package..");
            cmd_status.Text = output.ToString(); ;

            output.AppendLine("reading User imputs");
            cmd_status.Text = output.ToString(); ;
            if (String.IsNullOrEmpty(ArasURL) || String.IsNullOrEmpty(DataBaseName) || String.IsNullOrEmpty(usePass) || String.IsNullOrEmpty(userid))
            {
                MessageBox.Show("Please provide all the information to login");
                output.AppendLine("Please provide all the information to login");
                cmd_status.Text = output.ToString(); ;
                return;
            }

            
            
            String[] urlarray = ArasURL.Split('/');

            String ServerName = urlarray[2];
            String Site = urlarray[3];

            String urlval = @"http://" + ServerName + "/" + Site;
            //---------------Got all the USer info--------------------

#region Importing the Pre-Import Scripts
            output.AppendLine("******************************* Running Pre Import Scripts *******************************");
            cmd_status.Text = output.ToString(); ;

            String preImportFolder = pre_imp_fold_path.Text;
            if (String.IsNullOrEmpty(preImportFolder))
            {
                output.AppendLine("\nThere is no Pre-Import Selected so skiping the pre-Imports Scripts");
                cmd_status.Text = output.ToString();
            }
            else
            {
                output.AppendLine("\nRunning Pre-Import Scripts");
                cmd_status.Text = output.ToString();


                string[] files = Directory.GetFiles(preImportFolder)
                              .Where(p => p.EndsWith(".xml"))
                              .ToArray();
                foreach (var path in files)
                {
                    XDocument xDoc = XDocument.Load(path);
                    // read Xml file
                    try
                    {
                        //Item preImpotItem = inn.newItem();
                        //preImpotItem.loadAML(xDoc.ToString());
                        //preImpotItem.apply();

                        Item preImpotItem = inn.applyAML(xDoc.ToString());


                        if (preImpotItem.isError())
                        {
                            output.AppendLine("Error Wile Running the Pre-Import" + path);
                            output.AppendLine(preImpotItem.getErrorDetail());
                            cmd_status.Text = output.ToString();
                        }
                        else
                        {
                            output.AppendLine("Imported the Pre-Import Script " + path);
                            cmd_status.Text = output.ToString();
                        }
                    }
                    catch(Exception ex)
                    {
                        output.AppendLine("Error Wile Running the Pre-Import" + path);
                        output.AppendLine(ex.Message);
                        output.AppendLine(ex.ToString());
                        cmd_status.Text = output.ToString();
                    }

                }
            }

            output.AppendLine("******************************* End of Running Pre Import Scripts *******************************");
#endregion
            output.AppendLine("");
#region Running .mf file for Package Import
            output.AppendLine("###############################  Importing the Package Using .mf File ###############################");
            cmd_status.Text = output.ToString(); ;

            if (!String.IsNullOrEmpty(mfpath) && !(mfpath.Contains(".mf")))
            {
                MessageBox.Show("Please specify the correct Manifest File location");
                return;
            }
            else if (!String.IsNullOrEmpty(mfpath) && mfpath.Contains(".mf"))
            {
                String mfdir = Path.GetDirectoryName(mfpath);
                ProcessStartInfo psi = new ProcessStartInfo("cmd");
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.CreateNoWindow = true;
                psi.RedirectStandardInput = true;
                var proc = Process.Start(psi);


                String CMDargs = ("consoleUpgrade server=\"" + urlval
                    + "\" database=\"" + DataBaseName
                    + "\" login=\"" + userid
                    + "\" password=\"" + usePass
                    + "\" release=\"" + relnum
                    + "\" import dir=\"" + mfdir
                    + "\" mfFile=\"" + mfpath
                    + "\" merge log=\"" + logpath);
                // String CMDargs = ("consoleUpgrade ");
                // @String.Format(CMDargs, urlval, DataBaseName, userid,password, "relnum" , mfpath, mfpath, logpath);

                // proc.StandardInput.WriteLine("cd consoleUpgrade");
                proc.StandardInput.WriteLine(CMDargs);
                proc.StandardInput.WriteLine("exit");

                output.AppendLine(proc.StandardOutput.ReadToEnd());
                output.AppendLine(proc.StandardError.ReadToEnd());
                cmd_status.Text = output.ToString();
                proc.WaitForExit();
                proc.Close();

            }
            else if(String.IsNullOrEmpty(mfpath))
            {
                output.AppendLine("\n There is no Manifest file selected so skiping the Package Import");
                cmd_status.Text = output.ToString();
            }

            output.AppendLine("###############################  End of Importing the Package Using .mf File ###############################");
            #endregion;
            output.AppendLine("");
#region Copying Innovator Files
            output.AppendLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$  Copying Innovator Files $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            cmd_status.Text = output.ToString(); ;
            //Starting the Coping the Innovator Files

            String selInnFolder = inn_fold_path.Text;
            if(String.IsNullOrEmpty(selInnFolder))
            {
                output.AppendLine("\nThere is no Innovator Files Selected to skiping the Copy of Innovtor Foder");
                cmd_status.Text = output.ToString();
            }
            else
            {
                output.AppendLine("\nCopying files from Innovtor Foder to Aras Location");
                cmd_status.Text = output.ToString();
                String arasInnFolder = aras_inn_fldr_path.Text;
                if (String.IsNullOrEmpty(arasInnFolder))
                {
                    MessageBox.Show("There is no Aras Innovator Path Selected so could not Copy the Files");
                    output.AppendLine("There is no Aras Innovator Path Selected so could not Copy the Files");
                    cmd_status.Text = output.ToString();
                    return;
                }
                else;
                {
                    ProcessStartInfo psi = new ProcessStartInfo("cmd");
                    psi.UseShellExecute = false;
                    psi.RedirectStandardOutput = true;
                    psi.RedirectStandardError = true;
                    psi.CreateNoWindow = true;
                    psi.RedirectStandardInput = true;
                    var proc = Process.Start(psi);


                    String CMDargs = ("Robocopy \"" + selInnFolder
                        + "\" \"" + arasInnFolder
                        + "\" /E /IS");
                    // String CMDargs = ("consoleUpgrade ");
                    // @String.Format(CMDargs, urlval, DataBaseName, userid,password, "relnum" , mfpath, mfpath, logpath);

                    // proc.StandardInput.WriteLine("cd consoleUpgrade");
                    proc.StandardInput.WriteLine(CMDargs);
                    proc.StandardInput.WriteLine("exit");

                    output.AppendLine(proc.StandardOutput.ReadToEnd());
                    output.AppendLine(proc.StandardError.ReadToEnd());
                    cmd_status.Text = output.ToString();
                    proc.WaitForExit();
                    proc.Close();
                }


            }

            output.AppendLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ End of Copying Innovator Files $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
#endregion
            output.AppendLine("");
#region Running Post-Import Scripts
            output.AppendLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& Running Post Import Scripts &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            cmd_status.Text = output.ToString(); ;

            String postImportFolder = post_inp_fold_path.Text;
            if (String.IsNullOrEmpty(postImportFolder))
            {
                output.AppendLine("\nThere is no Post-Import Selected so skiping the pre-Imports Scripts");
                cmd_status.Text = output.ToString();
            }
            else
            {
                output.AppendLine("\nRunning Post-Import Scripts");
                cmd_status.Text = output.ToString();

                string[] files = Directory.GetFiles(postImportFolder)
                              .Where(p => p.EndsWith(".xml"))
                              .ToArray();
                foreach (var path in files)
                {
                    XDocument xDoc = XDocument.Load(path);
                    // read Xml file
                    try
                    {
                        //Item preImpotItem = inn.newItem();
                        //preImpotItem.loadAML(xDoc.ToString());
                        //preImpotItem.apply();
                        Item preImpotItem = inn.applyAML(xDoc.ToString());

                        if (preImpotItem.isError())
                        {
                            output.AppendLine("Error Wile Running the Post-Import" + path);
                            output.AppendLine(preImpotItem.getErrorDetail());
                            cmd_status.Text = output.ToString();
                        }
                        else
                        {
                            output.AppendLine("Imported the Post-Import Script " + path);
                            cmd_status.Text = output.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        output.AppendLine("Error Wile Running the Post-Import" + path);
                        output.AppendLine(ex.Message);
                        output.AppendLine(ex.ToString());
                        cmd_status.Text = output.ToString();
                    }

                }
            }
            output.AppendLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& End of Running Post Import Scripts &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            cmd_status.Text = output.ToString(); ;
#endregion
            // while(proc.)
            // proc.StandardOutput.ReadToEndAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog filediag = new OpenFileDialog();
            filediag.AddExtension = true;
            //filediag.DefaultExt = "*.mf";
            filediag.Filter = "MF File (*.mf)|*.mf|XML Files(*.xml)|*.xml|All Files (*.*)|*.*";
           // filediag.

            if (filediag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               path.Text = filediag.FileName;//.Replace("\\\\", "\\");
            }


        }

        private void log_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog filediag = new OpenFileDialog();
            filediag.Filter = "Log File (*.log)|*.log|All Files (*.*)|*.*";
            if (filediag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                log_path.Text = filediag.FileName;//.Replace("\\\\", "\\");
            }
        }

        private void pre_imp_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show(fbd.SelectedPath);
                pre_imp_fold_path.Text = fbd.SelectedPath;
            }
        }

        private void post_impt_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show(fbd.SelectedPath);
                post_inp_fold_path.Text = fbd.SelectedPath;
            }
        }

        private void aras_inn_fldr_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show(fbd.SelectedPath);
                aras_inn_fldr_path.Text = fbd.SelectedPath;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
