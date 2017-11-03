namespace DiagramApp
{
    partial class mainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrame));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependsOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inheritesFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.implementsInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isAssociatedWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.scenarioStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scenarioEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGenerateCode = new System.Windows.Forms.ToolStripSplitButton();
            this.activityCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityCodeWithClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripSeparator4,
            this.toolStripSplitButton2,
            this.toolStripSeparator1,
            this.saveBtn,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.toolStripButton2,
            this.toolStripSeparator6,
            this.ClearBtn,
            this.toolStripSeparator7,
            this.btnGenerateCode});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1130, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classToolStripMenuItem,
            this.interfaceToolStripMenuItem,
            this.dependsOnToolStripMenuItem,
            this.inheritesFromToolStripMenuItem,
            this.implementsInterfaceToolStripMenuItem,
            this.isAssociatedWithToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(138, 22);
            this.toolStripSplitButton1.Text = "Class Diagram Shapes";
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.classToolStripMenuItem.Text = "Class";
            this.classToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem_Click);
            // 
            // interfaceToolStripMenuItem
            // 
            this.interfaceToolStripMenuItem.Name = "interfaceToolStripMenuItem";
            this.interfaceToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.interfaceToolStripMenuItem.Text = "Interface";
            this.interfaceToolStripMenuItem.Click += new System.EventHandler(this.interfaceToolStripMenuItem_Click);
            // 
            // dependsOnToolStripMenuItem
            // 
            this.dependsOnToolStripMenuItem.Name = "dependsOnToolStripMenuItem";
            this.dependsOnToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.dependsOnToolStripMenuItem.Text = "Dependency";
            this.dependsOnToolStripMenuItem.Click += new System.EventHandler(this.dependsOnToolStripMenuItem_Click);
            // 
            // inheritesFromToolStripMenuItem
            // 
            this.inheritesFromToolStripMenuItem.Name = "inheritesFromToolStripMenuItem";
            this.inheritesFromToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.inheritesFromToolStripMenuItem.Text = "Aggregation";
            this.inheritesFromToolStripMenuItem.Click += new System.EventHandler(this.inheritesFromToolStripMenuItem_Click);
            // 
            // implementsInterfaceToolStripMenuItem
            // 
            this.implementsInterfaceToolStripMenuItem.Name = "implementsInterfaceToolStripMenuItem";
            this.implementsInterfaceToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.implementsInterfaceToolStripMenuItem.Text = "Composition";
            this.implementsInterfaceToolStripMenuItem.Click += new System.EventHandler(this.implementsInterfaceToolStripMenuItem_Click);
            // 
            // isAssociatedWithToolStripMenuItem
            // 
            this.isAssociatedWithToolStripMenuItem.Name = "isAssociatedWithToolStripMenuItem";
            this.isAssociatedWithToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.isAssociatedWithToolStripMenuItem.Text = "Association";
            this.isAssociatedWithToolStripMenuItem.Click += new System.EventHandler(this.isAssociatedWithToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scenarioStartToolStripMenuItem,
            this.scenarioEndToolStripMenuItem,
            this.activityToolStripMenuItem,
            this.decisionToolStripMenuItem,
            this.transitionToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(151, 22);
            this.toolStripSplitButton2.Text = "Activity Diagram Shapes";
            // 
            // scenarioStartToolStripMenuItem
            // 
            this.scenarioStartToolStripMenuItem.Name = "scenarioStartToolStripMenuItem";
            this.scenarioStartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scenarioStartToolStripMenuItem.Text = "Initial State";
            this.scenarioStartToolStripMenuItem.Click += new System.EventHandler(this.scenarioStartToolStripMenuItem_Click);
            // 
            // scenarioEndToolStripMenuItem
            // 
            this.scenarioEndToolStripMenuItem.Name = "scenarioEndToolStripMenuItem";
            this.scenarioEndToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scenarioEndToolStripMenuItem.Text = "Final State";
            this.scenarioEndToolStripMenuItem.Click += new System.EventHandler(this.scenarioEndToolStripMenuItem_Click);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.activityToolStripMenuItem.Text = "Activity";
            this.activityToolStripMenuItem.Click += new System.EventHandler(this.activityToolStripMenuItem_Click);
            // 
            // decisionToolStripMenuItem
            // 
            this.decisionToolStripMenuItem.Name = "decisionToolStripMenuItem";
            this.decisionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decisionToolStripMenuItem.Text = "Decision";
            this.decisionToolStripMenuItem.Click += new System.EventHandler(this.decisionToolStripMenuItem_Click);
            // 
            // transitionToolStripMenuItem
            // 
            this.transitionToolStripMenuItem.Name = "transitionToolStripMenuItem";
            this.transitionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transitionToolStripMenuItem.Text = "Transition ";
            this.transitionToolStripMenuItem.Click += new System.EventHandler(this.transitionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 22);
            this.saveBtn.Text = "Save Image As";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Load Image";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton2.Text = "Make Jar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_2);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // ClearBtn
            // 
            this.ClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("ClearBtn.Image")));
            this.ClearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(56, 22);
            this.ClearBtn.Text = "ClearBtn";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGenerateCode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityCodeToolStripMenuItem,
            this.activityCodeWithClassToolStripMenuItem});
            this.btnGenerateCode.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateCode.Image")));
            this.btnGenerateCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(101, 22);
            this.btnGenerateCode.Text = "Generate Code";
            // 
            // activityCodeToolStripMenuItem
            // 
            this.activityCodeToolStripMenuItem.Name = "activityCodeToolStripMenuItem";
            this.activityCodeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.activityCodeToolStripMenuItem.Text = "Activity Code";
            this.activityCodeToolStripMenuItem.Click += new System.EventHandler(this.activityCodeToolStripMenuItem_Click);
            // 
            // activityCodeWithClassToolStripMenuItem
            // 
            this.activityCodeWithClassToolStripMenuItem.Name = "activityCodeWithClassToolStripMenuItem";
            this.activityCodeWithClassToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.activityCodeWithClassToolStripMenuItem.Text = "Activity Code with class";
            this.activityCodeWithClassToolStripMenuItem.Click += new System.EventHandler(this.activityCodeWithClassToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1106, 604);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1165, 763);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1130, 659);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoDraw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dependsOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inheritesFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem implementsInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isAssociatedWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem scenarioStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scenarioEndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transitionToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ClearBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSplitButton btnGenerateCode;
        private System.Windows.Forms.ToolStripMenuItem activityCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityCodeWithClassToolStripMenuItem;
    }
}

