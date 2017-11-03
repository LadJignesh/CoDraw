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
	public partial class decisionFigForm : Form
	{
		public DecisionFigForm dff { get; set; }
		public decisionFigForm()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			dff.Condition = txtcondition.Text;
			dff.yesCond = txtYesCond.Text;
			dff.noCond = txtNoCond.Text;
		}
	}
}
