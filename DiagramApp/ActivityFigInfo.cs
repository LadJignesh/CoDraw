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
    public partial class ActivityFigInfo : Form
    {
        public ActivityInfo ActivityInfo { get; set; }
        public ActivityFigInfo()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ActivityInfo.ActivityData = txtActivityData.Text;
        }
    }
}
