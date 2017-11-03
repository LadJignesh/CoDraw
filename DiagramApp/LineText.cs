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
    public partial class LineText : Form
    {
        public LineText1 Linetext1 { get; set; }
        public LineText()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Linetext1.LineInfo = txtLineText.Text;
        }
    }
}
