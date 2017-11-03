using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramApp
{
    public partial class classFigInfo : Form
    {
        public ClassInfoForm abc { get; set; }
        public classFigInfo()
        {
            InitializeComponent();
        }
               

        private void btnOk_Click(object sender, EventArgs e)
        {
            abc.ClassName = txtClassName.Text;
            abc.Values = txtValues.Text;
            abc.Methods = txtMethods.Text;
        }
    }
}
