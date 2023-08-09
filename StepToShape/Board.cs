using StepToShape.Shapes;
using StepToShape.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepToShape
{
    public partial class frmBoard : Form
    {
        protected int StepIndex { get; set; } = 0;

        protected List<PointD> DrawToList { get; set; }

        public frmBoard()
        {
            InitializeComponent();
            //btnStartCursor.Focus();
            lbValueBoardOpened.Text = string.Format("= {0:HH:mm:ss, dd.MM.yyyy}", DateTime.Now);
        }

        protected void btnStartCursor_Click(object sender, EventArgs e)
        {
            var radius = MathTools.ClipRadius() - 100;
            radius = 350;
            var circle = new Circle(radius);
            this.DrawToList = circle.DrawToList();

            grbTimerLog.Text = string.Format(" Timer started     = {0:HH:mm:ss} ", DateTime.Now);
            btnStopCursor.Focus();
            Stepper.Enabled = true;
        }

        protected void btnStopCursor_Click(object sender, EventArgs e)
        {
            btnStartCursor.Focus();
            Stepper.Enabled = false;
        }

        protected void Stepper_Tick(object sender, EventArgs e)
        {
            if (this.StepIndex >= this.DrawToList.Count)
            {
                this.StepIndex = 0;
            }
            var current = this.DrawToList[this.StepIndex++].Position;
            Cursor.Position = current;
            lbValueTick.Text = string.Format("= {0:HH:mm:ss}", DateTime.Now);
            lbValueStep.Text = string.Format("= {0} / {1}", this.StepIndex, this.DrawToList.Count);
            lbValuePoint.Text = string.Format("= x {0}, y {1}", current.X, current.Y);
        }

        protected void btnClipBox_Click(object sender, EventArgs e)
        {
            this.ShowClipBox();
        }

        protected void ShowClipBox()
        {
            var cType = this.GetType();
            //MessageBox.Show(string.Format("Name: '{0}', FullName: '{1}', Assembly: {2}", cType.Name, cType.FullName, cType.AssemblyQualifiedName));

            DrawEllipse();

            var clip = Cursor.Clip;
            var msgText = string.Format("Width: {0}, Height: {1}\nLeft: {2}, Top: {3}\nX: {4}, Y: {5}", clip.Width, clip.Height, clip.Left, clip.Top, clip.X, clip.Y);
            var show = MessageBox.Show(msgText, "Cursor.Clip", MessageBoxButtons.OK);
            Cursor.Clip = new Rectangle(0, 0, 200, 200);
        }

        protected void frmBoard_MouseMove(object sender, MouseEventArgs e)
        {
            lbValueMousePosition.Text = string.Format("= x {0}, y {1}", Cursor.Position.X, Cursor.Position.Y);
        }

        protected void DrawEllipse()
        {
            Pen myPen = new Pen(Color.Red);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            //formGraphics.DrawEllipse(myPen, new Rectangle(0, 0, 200, 300));
            formGraphics.DrawRectangle(myPen, new Rectangle(0, 0, 200, 300));
            myPen.Dispose();
            formGraphics.Dispose();
        }
    }
}
