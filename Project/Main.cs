using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WFA_MUA
{
    public partial class Main : Form
    {
        private IniFile ini;
        private string tmpFile = "tmp/test.txt";
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load Ini File
        /// </summary>
        private void loadIni()
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\sys\\Config.ini";
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                ini = new IniFile(path);
                log("Ini file loaded!");
            }
            else 
            {
                log("ERROR: Config.ini file not found!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadIni();
            populateAvailable();
            loadDefaultChars();            
        }
        /// <summary>
        /// Load the initial chars from INI file
        /// </summary>
        private void loadDefaultChars()
        {            
            string chars = ini.IniReadValue("mua", "chars");
            for (int i = 1; i <= 27; i++)
            {
                if (i == 27) i = 96;

                string path = chars + "\\" + ini.IniReadValue("defaultchars", i + "") + ".txt";
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    string name = file.Name.Remove(file.Name.Length - 4);
                    addSelectedChar(i, name, path);
                }
                else 
                {
                    log("ERROR: file not found: " + path);
                }
            }
        }
        /// <summary>
        /// Load chars from disc
        /// </summary>
        private void populateAvailable()
        {
            trvAvailableChars.Nodes.Clear();
            DirectoryInfo folder = new DirectoryInfo(ini.IniReadValue("mua","chars"));
            populateAvailable(folder, trvAvailableChars.Nodes);
            trvAvailableChars.Sort();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="nodes"></param>
        /// <seealso cref="http://www.c-sharpcorner.com/UploadFile/scottlysle/TreeviewBasics04152007195731PM/TreeviewBasics.aspx"/>
        private void populateAvailable(DirectoryInfo folder, TreeNodeCollection nodes)
        {
            foreach(DirectoryInfo subfolder in folder.GetDirectories()){
                TreeNode node = new TreeNode();
                node.Text = subfolder.Name;
                nodes.Add(node);

                populateAvailable(subfolder, node.Nodes);
            }
            foreach (FileInfo file in folder.GetFiles("*.txt"))
            {
                TreeNode node = new TreeNode();
                node.Text = file.Name.Remove(file.Name.Length - 4);
                node.Tag = file.FullName;
                nodes.Add(node);
            }
        }

        /// <summary>
        /// Run a MS Dos Command (used to compile/decompile MUA files)
        /// </summary>
        /// <seealso cref="http://forums.microsoft.com/MSDN/ShowPost.aspx?PostID=457996&SiteID=1"/>
        /// <param name="cmd"></param>
        /// <param name="vars"></param>
        /// <returns></returns>
        private string runDosCommnand(string cmd, string vars)
        {
            System.Diagnostics.ProcessStartInfo sinf = new System.Diagnostics.ProcessStartInfo(cmd, vars);
            // The following commands are needed to redirect the standard output. This means that it will be redirected to the Process.StandardOutput StreamReader.
            sinf.RedirectStandardOutput = true;
            sinf.UseShellExecute = false;
            // Do not create that ugly black window, please...
            sinf.CreateNoWindow = true;
            // Now we create a process, assign its ProcessStartInfo and start it
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = sinf;
            p.Start(); // well, we should check the return value here...
            // We can now capture the output into a string...
            string res = p.StandardOutput.ReadToEnd();
            // And do whatever we want with that.
            Console.WriteLine(res);
            return res;
        }
        /// <summary>
        /// Mark a char as selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trvAvailableChars_DoubleClick(object sender, EventArgs e)
        {
            if ((lstSelected.Items.Count <= 26) || !txtPosition.Text.Equals(""))
            {
                if (trvAvailableChars.SelectedNode.Tag != null)
                {

                    string name = trvAvailableChars.SelectedNode.Text.ToString();
                    string path = trvAvailableChars.SelectedNode.Tag.ToString();
                    int pos = getFreePosition();

                    if (!txtPosition.Text.Equals(""))
                    {
                        pos = Int32.Parse(txtPosition.Text);
                        foreach (ListViewItem lvi in lstSelected.Items) 
                        {
                            if (Int32.Parse(lvi.Text) == pos){ //REPLACE POSITION
                                lstSelected.Items.Remove(lvi);
                            }else if(name.Equals(lvi.SubItems[1].Text)) { //PREVENT SAME CHAR
                                objMenu.setTextbox(Int32.Parse(lvi.Text), "");
                                lstSelected.Items.Remove(lvi);
                            }
                        }
                    }

                    addSelectedChar(pos,name, path);


                    txtPosition.Text = "";
                    pos = getFreePosition();
                    if (pos!=0)
                        txtPosition.Text = pos + "";
                }
            }
            else 
            {
                log("ERROR: there is no space available");
            }
        }
        /// <summary>
        /// Return the first free position
        /// </summary>
        /// <returns></returns>
        private int getFreePosition()
        {
            for (int i = 1; i <= 26; i++) {
                if (objMenu.getTextbox(i).CharName.Equals(""))
                    return i;
            }
            if (objMenu.getTextbox(27).CharName.Equals(""))
                return 96;
            return 0;
        }
        /// <summary>
        /// Add a char in lstSelected
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="name"></param>
        /// <param name="path"></param>
        private void addSelectedChar(int pos, string name, string path)
        {
            objMenu.setTextbox(pos, name);
            ListViewItem lvi = new ListViewItem(pos + "");
            if (pos < 10)
                lvi.Text = "0" + lvi.Text;
            lvi.SubItems.Add(name);
            lvi.SubItems.Add(path);
            lstSelected.Items.Add(lvi);
            lstSelected.Sort();

            //log(path + " loaded");
        }

        private void lstSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPosition.Text = lstSelected.SelectedItems[0].Text;
        }
        /// <summary>
        /// Remove a selected char from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (lstSelected.Items.Count == 0) 
            {
                log("ERROR: There is no char to remove");
            }
            else if (lstSelected.SelectedItems.Count == 0)
            {
                log("ERROR: select char(s) to remove");
            }
            else
            {
                foreach (ListViewItem lvi in lstSelected.SelectedItems)
                {
                    objMenu.setTextbox(Int32.Parse(lvi.SubItems[0].Text), "");
                    lstSelected.Items.Remove(lvi);
                }
            }
        }
        /// <summary>
        /// Replace the MUA config file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (lstSelected.Items.Count > 0)
            {
                generateTextFile();
                runDosCommnand(Directory.GetCurrentDirectory() + "/sys/xmlb-compile.exe", "-s " + tmpFile + " tmp/hero.engb");
            }
            else
            {
                log("ERROR: there is not char selected");
            }
        }
        /// <summary>
        /// Generate the temporary text file with all selected chars
        /// </summary>
        private void generateTextFile()
        {
            DirectoryInfo folder = new DirectoryInfo("tmp");
            if (!folder.Exists)
                folder.Create();

            StreamWriter writer = new StreamWriter(tmpFile, false);
            writer.WriteLine("XMLB characters {");
            foreach (ListViewItem lvi in lstSelected.Items)
            {
                string path = lvi.SubItems[2].Text;
                int pos = Int32.Parse(lvi.SubItems[0].Text);

                writer.WriteLine("");
                writer.Write(readFile(path, pos));
                writer.WriteLine("");
            }
            writer.Write(readFile("sys/endoffile.txt", 0));
            writer.WriteLine("}");
            writer.Close();
        }
        /// <summary>
        /// Return all file content and replace the <b>menulocation</b> information
        /// </summary>
        /// <param name="path"></param>
        /// <param name="newPos"></param>
        /// <returns></returns>
        private string readFile(string path, int newPos)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line.Trim().StartsWith("menulocation"))
                {
                    sb.AppendLine("   menulocation = " + newPos + " ;");
                }
                else
                {
                    sb.AppendLine(line);
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return sb.ToString();
        }
        /// <summary>
        /// Put a message in the log console
        /// </summary>
        /// <param name="msg"></param>
        private void log(string msg){
            txtDebug.Text= msg + "\r\n" + txtDebug.Text;
        }
        /// <summary>
        /// Observer. Update the position field
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pos"></param>
        private void objMenu_OnDoubleClickChar(string name, int pos)
        {
            txtPosition.Text = pos + "";
        }
        /// <summary>
        /// Check the folders again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            populateAvailable();
        }
    }
}
