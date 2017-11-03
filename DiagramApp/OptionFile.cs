using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramApp
{
    public partial class OptionFile : Form
    {
        public OptionFile()
        {
            //Thread t = new Thread(new ThreadStart(SplashScreen));
            //t.Start();
            //Thread.Sleep(5000);
            InitializeComponent();
           // t.Abort();
        }
        //public void SplashScreen()
        //{
        //    Application.Run(new splash());
        //}
        public static string option="";
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (checkBox1.Checked == true)
            {
                option="class";                                                                                                                                                                                                             
            }else if (checkBox2.Checked == true)
            {
                option = "activity";
            }
            this.Hide();
            mainFrame main = new mainFrame();
            
            main.ShowDialog();
            Visible = false;
            this.Close();
        }

    }
}
