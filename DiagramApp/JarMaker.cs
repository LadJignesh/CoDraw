using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramApp
{
    public partial class JarMaker : Form
    {
        public JarMaker()
        {
            InitializeComponent();
        }
        string classFileName;
        string classFilePath;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Class File(*.class)|*.class";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = System.IO.Path.GetFileName(ofd.FileName);
                classFileName = System.IO.Path.GetFileName(ofd.FileName);
                //if (classFileName.Contains(".java"))
                //{
                //    try
                //    {
                //        Process.Start("javac " + classFileName);
                //    }
                //    catch(Exception error)
                //    {
                //        MessageBox.Show(Exc);
                //    }}
                classFilePath = ofd.FileName;
                txtLogBox.Text = "Input file Selected ";
                txtLogBox.AppendText(Environment.NewLine + "Click 'Create Jar Button' to create Jar File");
                if (textBox1.Text != "")
                {
                    button2.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(classFilePath);
                Console.WriteLine(Path.GetDirectoryName(classFilePath) + "\\" + Path.GetFileNameWithoutExtension(classFileName) + "manifest.txt");
                Console.WriteLine(Path.GetDirectoryName(classFilePath));
                using (StreamWriter writer = new StreamWriter(Path.GetDirectoryName(classFilePath) + "\\" + Path.GetFileNameWithoutExtension(classFileName) + "manifest.txt"))
                {
                    writer.WriteLine("Main-Class: " + Path.GetFileNameWithoutExtension(classFileName));
                    writer.WriteLine(" ");
                }
                txtLogBox.AppendText(Environment.NewLine + "Manifest File Generated Successfully");
                //Console.WriteLine("jar cfm " + Path.GetFileNameWithoutExtension(classFileName) + ".jar " + Path.GetFileNameWithoutExtension(classFileName) + "manifest.txt" + " *.class" );
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(classFilePath);
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.StandardInput.WriteLine("jar cfm " + Path.GetFileNameWithoutExtension(classFileName) + ".jar " + Path.GetFileNameWithoutExtension(classFileName) + "manifest.txt" + " *.class");
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
                Console.WriteLine(process.StandardOutput.ReadToEnd());
                //Console.ReadKey();
                txtLogBox.AppendText(Environment.NewLine + "Jar File Generated at " + Path.GetDirectoryName(classFilePath));
                Console.WriteLine("JarCreated");
                Console.WriteLine("jar cfm " + Path.GetFileNameWithoutExtension(classFileName) + ".jar " + Path.GetFileNameWithoutExtension(classFileName) + "manifest.txt" + " " + classFileName);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
