using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DiagramApp
{
    public partial class mainFrame : Form
    {
        #region Declarations
        int x, y;
        int i, j;
        string clsname;
        string valname;
        string methodinfo;
        string activitydata;
        string pack;
        string drawString;
        Bitmap image;
        string filepath;
        string folderPath = "";
        #endregion

        public mainFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalImage = pictureBox1.Image;
            string opt=OptionFile.option;
            if (opt == "class") {
                
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    folderPath = folderBrowserDialog1.SelectedPath;
                    
                }
                toolStripSplitButton2.Enabled = false;
            }else if (opt == "activity")
            {
                toolStripSplitButton1.Enabled = false;
            }
            System.IO.File.WriteAllText(@"C:\\Users\\Jignesh Lad\\Desktop\\DiagramApp\\DiagramApp\\bin\\Debug\\output.txt", string.Empty);
            image = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
        }

        #region ToolStrip Menu Click Methods
        bool classfig = false;
        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Cross;
            classfig = true;
        }
        bool interfacefig = false;
        private void interfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interfacefig = true;
        }
        bool packagefig = false;
        private void packageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            packagefig = true;
        }
        bool dependsFig = false;
        private void dependsOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dependsFig = true;
        }
        bool aggregationFig = false;
        private void inheritesFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aggregationFig = true;
        }
        bool compositonFig = false;
        private void implementsInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compositonFig = true;
        }
        bool associationFig = false;
        private void isAssociatedWithToolStripMenuItem_Click(object sender, EventArgs e)
        {
            associationFig = true;
        }
        bool sceStart = false;
        private void scenarioStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sceStart = true;
        }
        bool sceEnd = false;
        private void scenarioEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sceEnd = true;
        }
        bool activityfig=false;
        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activityfig = true;
        }
        bool deciFig = false;
        private void decisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deciFig = true;
        }
        bool syncFig = false;
        private void synchronizationBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syncFig = true;
        }
        bool transitionFig=false;
        private void transitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transitionFig = true;
        }
        bool stateFig = false;
        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stateFig = true;
        }
        bool canPaint = false;
        #endregion

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"D:\";
            sfd.RestoreDirectory = true;
            
            sfd.DefaultExt = "png";
            sfd.Filter = "Bitmap Image (.bmp)|*.bmp|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream st = sfd.OpenFile();
                var filter = sfd.Filter;
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bmp, pictureBox1.Bounds);
                bmp.Save(st, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Photo Saved", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
      
        #region StructNamed Class Points

        public struct ClassPoints
        {
            public int nLeftX;
            public int nTopY;
            public int nRightX;
            public int nBottomY;
            public string className;


            public ClassPoints(int _nLeftX, int _nTopY, int _nRightX, int _nBottomY, string _className)
            {
                nLeftX = _nLeftX;
                nTopY = _nTopY;
                nRightX = _nRightX;
                nBottomY = _nBottomY;
                className = _className;
            }
        };
        #endregion

        List<ClassPoints> cP = new List<ClassPoints>();
        public int Not_Found { get; private set; }
        public int Found { get; private set; }
        string match;
        private int classClicked(int mouseX, int mouseY)
        {
            foreach (var person in cP)
            {
                if ((mouseX >= person.nLeftX) && (mouseX <= person.nRightX) &&
                (mouseY >= person.nTopY) && (mouseY <= person.nBottomY))
                {
                    match = person.className;
                    break;
                }

            }            
            return Not_Found;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //pictureBox1.Image = new Bitmap(ofd.FileName);
                Bitmap bmp = new Bitmap(ofd.FileName);
                pictureBox1.Image = bmp;
            }



        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(image);
            
            
        }

        private void toolStripButton2_Click_2(object sender, EventArgs e)
        {
            JarMaker jM = new JarMaker();
            jM.Show();
        }
        private Image originalImage;
        private void ClearBtn_Click(object sender, EventArgs e)
        {
           // pictureBox1.Image = null;
            pictureBox1.Refresh();
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(image);
            pictureBox1.Cursor = Cursors.Arrow;
            Pen p = new Pen(Color.Black);
            canPaint = true;
            #region ClassFigures
            #region PackageFigure
            if (packagefig)
            {
                x = e.X;
                y = e.Y;

                using (PackageInfo pfi = new PackageInfo() { PackageDta = new PackageName() })
                {
                    if (pfi.ShowDialog() == DialogResult.OK)
                    {
                        pack = pfi.PackageDta.PackageData;
                    }
                }
                SolidBrush sb = new SolidBrush(Color.Blue);
                g.DrawRectangle(p, i, j - 30, 70, 30);
                g.DrawString(pack, this.Font, Brushes.Black, i, j - 20);
                g.DrawRectangle(p, i, j, x - i, y - j);
                //string packagepath = "D:\\Projects\\null\\" + pack;
                //if (!Directory.Exists(packagepath))
                //{
                //    Directory.CreateDirectory(packagepath);
                //}
                canPaint = false;
                packagefig = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region DependsFigure
            if (dependsFig)
            {
                x = e.X;
                y = e.Y;
                g.DrawLine(p, i, j, x, y);
                SolidBrush sb = new SolidBrush(Color.Black);
                g.FillEllipse(sb, x, y, 5, 5);
                int cPointCheck1 = classClicked(i, j);
                string start = match;
                int cPointCheck2 = classClicked(x, y);
                string target = match;
                Console.WriteLine(start + " depends on " + target);
                var text = new StringBuilder();

                foreach (string s in File.ReadAllLines("D:\\" + start + ".java"))
                {
                    text.AppendLine(s.Replace(start, start+" extends "+target));
                }

                using (var file = new StreamWriter(File.Create("D:\\" + start + ".java")))
                {
                    file.Write(text.ToString());
                }
                canPaint = false;
                dependsFig = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region aggregationFigure
            if (aggregationFig)
            {
                x = e.X;
                y = e.Y;
                p.StartCap = LineCap.Round;
                p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                g.DrawLine(p, i, j, x, y);
                int cPointCheck1 = classClicked(i, j);
                string start = match;
                int cPointCheck2 = classClicked(x, y);
                string target = match;
                Console.WriteLine(start + " aggregates to " + target);
                var text = new StringBuilder();

                foreach (string s in File.ReadAllLines("D:\\" + start + ".java"))
                {
                    text.AppendLine(s.Replace(start + "{", start + " {  \n private " + target + " " + target + ";"));
                }

                using (var file = new StreamWriter(File.Create("D:\\" + start + ".java")))
                {
                    file.WriteLine(text.ToString());
                }
                canPaint = false;
                aggregationFig = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region compositonFigure
            if (compositonFig)
            {
                x = e.X;
                y = e.Y;
                // Set the width to 6.
                p.Width = 6.0F;

                // Set the DashCap to round.
                p.DashCap = System.Drawing.Drawing2D.DashCap.Round;

                // Create a custom dash pattern.
                p.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };



                AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                p.CustomEndCap = bigArrow;

                // Draw a line.
                g.DrawLine(p, i, j, x, y);
                int cPointCheck1 = classClicked(i, j);
                string start = match;
                int cPointCheck2 = classClicked(x, y);
                string target = match;
                Console.WriteLine(start + " composites to " + target);
                // Change the SmoothingMode to none.
                g.SmoothingMode =
                    System.Drawing.Drawing2D.SmoothingMode.None;

                // Dispose of the custom pen.
                p.Dispose();
                var text = new StringBuilder();

                foreach (string s in File.ReadAllLines("D:\\" + start + ".java"))
                {
                    text.AppendLine(s.Replace(start + "{", start + " {  \n private " + target + "[] " + target + ";"));
                }

                using (var file = new StreamWriter(File.Create("D:\\" + start + ".java")))
                {
                    file.WriteLine(text.ToString());
                }
                canPaint = false;
                compositonFig = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region AssociationFigure
            if (associationFig)
            {
                x = e.X;
                y = e.Y;

                using (LineText lt = new LineText() { Linetext1 = new LineText1() })
                {
                    if (lt.ShowDialog() == DialogResult.OK)
                    {
                        drawString = lt.Linetext1.LineInfo;
                    }
                }
                //string drawString = "Sample Text";
                System.Drawing.Font drawFont = new System.Drawing.Font(
                    "Arial", 10);
                System.Drawing.SolidBrush drawBrush = new
                    System.Drawing.SolidBrush(System.Drawing.Color.Black);
                //AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                //p.CustomEndCap = bigArrow;
                g.DrawString(drawString, drawFont, drawBrush, x - 70, y - 20);
                SolidBrush sb = new SolidBrush(Color.Black);
                Point[] a = { new Point(i - 10, j), new Point(i, j + 5), new Point(i + 10, j), new Point(i, j - 5) };
                g.FillPolygon(sb, a);
                g.DrawLine(p, i-10, j, x, y);
                int cPointCheck1 = classClicked(i, j);
                string start = match;
                int cPointCheck2 = classClicked(x, y);
                string target = match;
                Console.WriteLine(start + " associates to " + target);
                var text = new StringBuilder();

                foreach (string s in File.ReadAllLines("D:\\" + start + ".java"))
                {
                    text.AppendLine(s.Replace(start+"{", start + " {" +drawString+" "+ target+";"));
                }

                using (var file = new StreamWriter(File.Create("D:\\" + start + ".java")))
                {
                    file.WriteLine(text.ToString());
                }
                canPaint = false;
                associationFig = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #endregion
           
            #region Activity Shapes Code
            #region SynchronizationFigure
            if (syncFig)
            {
                x = e.X;
                y = e.Y;
                SolidBrush sb = new SolidBrush(Color.Black);
                g.FillRectangle(sb, x, y, 5, 5);
                g.DrawLine(p, i, j, x, y);
                canPaint = false;
                syncFig = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region TransitionFigure
            if (transitionFig)
            {
                x = e.X;
                y = e.Y;
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                p.CustomEndCap = bigArrow;
                g.DrawLine(p, i, j, x, y);
                canPaint = false;
                transitionFig = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region StateFigure
            if (stateFig)
            {
                x = e.X;
                y = e.Y;
                Pen pen = new Pen(Color.Black);
                g.DrawRectangle(p, i, j, x - i, y - j);
                canPaint = false;
                stateFig = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #endregion
        }

        private void activityCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "C:\\Users\\Jignesh Lad\\Desktop\\DiagramApp\\DiagramApp\\bin\\Debug\\output.txt");
        }
        string pathname="C:\\Users\\Jignesh Lad\\Desktop\\DiagramApp\\DiagramApp\\bin\\Debug\\output.txt";
        private void activityCodeWithClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JAVA(*.java)|*.java";
            saveFileDialog1.Title = "Save an Java File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {

                List<string> outputFileText = File.ReadAllLines(pathname).ToList();
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine("import java.*;");
                    writer.WriteLine("import java.util.*;");
                    writer.WriteLine("public class "+ Path.GetFileNameWithoutExtension(saveFileDialog1.FileName) + "{");
                    writer.WriteLine("public static void main(String args[]){");
                    foreach (String s in outputFileText)
                        writer.WriteLine(s);
                    //   writer.WriteLine(outputFileText);

                    writer.WriteLine("}");
                    writer.WriteLine("}");

                }
            }

        }

        string condition, YesCond, NoCond;
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //pictureBox1.Refresh();
            Graphics g = Graphics.FromImage(image);
            Pen p = new Pen(Color.Black);
            canPaint = true;
            #region ClassDiagramFigures
            #region ClassFigure
            if (classfig)
            {
                try
                {
                    using (classFigInfo cfi = new classFigInfo() { abc = new ClassInfoForm() })
                    {
                        if (cfi.ShowDialog() == DialogResult.OK)
                        {
                            clsname = cfi.abc.ClassName;
                            valname = cfi.abc.Values;
                            methodinfo = cfi.abc.Methods;
                        }

                    }

                    SolidBrush sb = new SolidBrush(Color.Red);
                    g.DrawRectangle(p, e.X, e.Y - 50, 150, 50);
                    g.DrawString(clsname, this.Font, Brushes.Black, e.X, e.Y - 30);
                    g.DrawRectangle(p, e.X, e.Y, 150, 50);
                    g.DrawString(valname, this.Font, Brushes.Black, e.X, e.Y + 3);
                    g.DrawRectangle(p, e.X, e.Y + 50, 150, 50);
                    g.DrawString(methodinfo, this.Font, Brushes.Black, e.X, e.Y + 50);
                    string[] methodLine = Regex.Split(methodinfo, "\n");
                    cP.Add(new ClassPoints(e.X, e.Y, e.X + 150, e.Y + 150, clsname));
                    #region Class FileGeneratorCode
                    using (StreamWriter writer = new StreamWriter(folderPath + clsname + ".java"))
                    {
                        writer.WriteLine("import java.*;");
                        writer.WriteLine("import java.util.*;");
                        writer.WriteLine("class " + clsname + "{");
                        //writer.WriteLine("public static void main(String args[]){");
                        writer.WriteLine(valname);
                        foreach (string line in methodLine)
                        {
                            writer.WriteLine(line);
                            writer.WriteLine("{ ");
                            writer.WriteLine("}");
                        }
                        writer.WriteLine("}");

                    }
                    #endregion
                    canPaint = false;
                    classfig = false;
                    pictureBox1.Invalidate();
                }catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            #endregion
            #region InterfaceFigure
            else if (interfacefig)
            {
                using (LineText lt = new LineText() { Linetext1 = new LineText1() })
                {
                    if (lt.ShowDialog() == DialogResult.OK)
                    {
                        drawString = lt.Linetext1.LineInfo;
                    }
                }
                g.DrawRectangle(p, e.X , e.Y , 100, 70);
                g.DrawString("<<interface>>", this.Font, Brushes.Black, e.X +15, e.Y + 5);
                g.DrawString(drawString, this.Font, Brushes.Black, e.X + 15, e.Y + 15);
                cP.Add(new ClassPoints(e.X, e.Y, e.X + 150, e.Y + 150, drawString));
                canPaint = false;
                interfacefig = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region DependsFigure
            else if (dependsFig)
            {
                i = e.X;
                j = e.Y;
                SolidBrush sb = new SolidBrush(Color.Black);
                g.FillRectangle(sb, i, j, 5, 5);
                canPaint = false;
            }
            #endregion
            #region aggregationFigure
            else if (aggregationFig)
            {
                i = e.X;
                j = e.Y;
                canPaint = false;
             }
            #endregion
            #region compositonFigure
            else if (compositonFig)
            {                
                i = e.X;
                j = e.Y;
                canPaint = false;
            }
            #endregion
            #region AssociationFigure
            else if (associationFig)
            {
                i = e.X;
                j = e.Y;
                canPaint = false;
            }
            #endregion
            #endregion

            #region Activity Diagram Figures
            #region ScenarioStartFigure
            else if (sceStart)
            {
                SolidBrush sb = new SolidBrush(Color.Black);
                g.DrawEllipse(p, e.X, e.Y, 20, 20);
                g.FillEllipse(sb, e.X, e.Y, 20, 20);
                canPaint = false;
                sceStart = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region ScenarioEndFigure
            else if (sceEnd)
            {
                SolidBrush sb = new SolidBrush(Color.Black);
                g.DrawEllipse(p, e.X, e.Y, 30, 30);
                g.FillEllipse(sb, e.X + 5, e.Y + 5, 20, 20);
                canPaint = false;
                sceEnd = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region ActivityFigure 
            else if (activityfig)
            {
                using (ActivityFigInfo afi = new ActivityFigInfo() { ActivityInfo = new ActivityInfo() })
                {
                    if (afi.ShowDialog() == DialogResult.OK)
                    {
                        activitydata = afi.ActivityInfo.ActivityData;
                    }

                }
                g.DrawRectangle(p, e.X, e.Y, 150, 80);
                g.DrawString(activitydata, new Font("Arial",10,FontStyle.Regular), Brushes.Black, e.X +3, e.Y +3);
                Console.WriteLine(activitydata);
                using (FileStream fs = new FileStream("output.txt", FileMode.Append, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine(activitydata);
                }
                // string[] methodLine = Regex.Split(methodinfo, "\n");
                canPaint = false;
                activityfig = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region DecisionFigure
            else if (deciFig)
            {
				using (decisionFigForm cfi = new decisionFigForm() { dff = new DecisionFigForm() })
				{
					if (cfi.ShowDialog() == DialogResult.OK)
					{
						condition = cfi.dff.Condition;
						YesCond = cfi.dff.yesCond;
						NoCond = cfi.dff.noCond;
					}
                    using (FileStream fs = new FileStream("output.txt", FileMode.Append, FileAccess.Write))
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.WriteLine("if(" + condition + "){");
                        writer.WriteLine(YesCond);
                        writer.WriteLine("}");
                        writer.WriteLine("else{");
                        writer.WriteLine(NoCond);
                        writer.WriteLine("}");

                    }
				}
				canPaint = false;
                deciFig = false;
				Font drawFont = new Font("Arial", 8);
				SolidBrush drawBrush = new SolidBrush(Color.Black);
				Point[] a = { new Point(e.X - 50, e.Y), new Point(e.X, e.Y + 50), new Point(e.X + 50, e.Y), new Point(e.X, e.Y - 50) };
				g.DrawString(condition, drawFont, drawBrush, e.X-40 , e.Y-20 );
				g.DrawPolygon(p, a);
				g.DrawLine(p,e.X+50,e.Y,e.X+100,e.Y);
				g.DrawString("No", drawFont, drawBrush, e.X + 70, e.Y + 4);
				Point[] no = { new Point(e.X + 100, e.Y), new Point(e.X+150, e.Y + 50), new Point(e.X + 200, e.Y), new Point(e.X+150, e.Y - 50) };
				g.DrawString(NoCond, drawFont, drawBrush, e.X+120, e.Y-10);
                //g.DrawPolygon(p, no);
                g.DrawRectangle(p,e.X+100,e.Y-25,200,50);
                g.DrawLine(p, e.X , e.Y+50, e.X , e.Y+100);
				g.DrawString("Yes", drawFont, drawBrush, e.X , e.Y +80);
				g.DrawString(YesCond, drawFont, drawBrush, e.X-60, e.Y+110);
				Point[] yes = { new Point(e.X-50 , e.Y+150), new Point(e.X, e.Y + 100), new Point(e.X + 50, e.Y+150), new Point(e.X, e.Y +200) };
                g.DrawRectangle(p, e.X-75, e.Y+100, 150, 50);
                //g.DrawPolygon(p, yes);


                pictureBox1.Invalidate();
            }
            #endregion
            #region SynchronizationFigure
            else if (syncFig)
            {
                i = e.X;
                j = e.Y;
                SolidBrush sb = new SolidBrush(Color.Black);
                g.FillRectangle(sb, i, j, 5, 5);
                canPaint = false;
                pictureBox1.Invalidate();
            }
            #endregion
            #region TransitionFigure
            else if (transitionFig)
            {
                i = e.X;
                j = e.Y;
                canPaint = false;
            }
            #endregion
            #region StateFigure
            if (stateFig)
            {

                i = e.X;
                j = e.Y;
                canPaint = false;
            }
            #endregion
            #endregion
        }       
   
    }
    
}
