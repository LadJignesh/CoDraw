namespace DiagramApp
{
	partial class decisionFigForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtcondition = new System.Windows.Forms.TextBox();
			this.txtYesCond = new System.Windows.Forms.TextBox();
			this.txtNoCond = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codition :-";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "If YES :-";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "If NO :-";
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(79, 295);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// txtcondition
			// 
			this.txtcondition.Location = new System.Drawing.Point(79, 31);
			this.txtcondition.Multiline = true;
			this.txtcondition.Name = "txtcondition";
			this.txtcondition.Size = new System.Drawing.Size(131, 66);
			this.txtcondition.TabIndex = 4;
			// 
			// txtYesCond
			// 
			this.txtYesCond.Location = new System.Drawing.Point(79, 114);
			this.txtYesCond.Multiline = true;
			this.txtYesCond.Name = "txtYesCond";
			this.txtYesCond.Size = new System.Drawing.Size(131, 67);
			this.txtYesCond.TabIndex = 5;
			// 
			// txtNoCond
			// 
			this.txtNoCond.Location = new System.Drawing.Point(79, 198);
			this.txtNoCond.Multiline = true;
			this.txtNoCond.Name = "txtNoCond";
			this.txtNoCond.Size = new System.Drawing.Size(131, 71);
			this.txtNoCond.TabIndex = 6;
			// 
			// decisionFigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(253, 339);
			this.Controls.Add(this.txtNoCond);
			this.Controls.Add(this.txtYesCond);
			this.Controls.Add(this.txtcondition);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "decisionFigForm";
			this.Text = "decisionFigForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtcondition;
		private System.Windows.Forms.TextBox txtYesCond;
		private System.Windows.Forms.TextBox txtNoCond;
	}
}