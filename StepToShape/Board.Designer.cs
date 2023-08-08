
namespace StepToShape
{
    partial class frmBoard
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
            this.grbTimerLog = new System.Windows.Forms.GroupBox();
            this.lbValuePoint = new System.Windows.Forms.Label();
            this.lbNamePoint = new System.Windows.Forms.Label();
            this.lbValueStep = new System.Windows.Forms.Label();
            this.lbNameStep = new System.Windows.Forms.Label();
            this.lbValueTick = new System.Windows.Forms.Label();
            this.lbNameTick = new System.Windows.Forms.Label();
            this.lbNameMousePosition = new System.Windows.Forms.Label();
            this.lbNameBoardOpened = new System.Windows.Forms.Label();
            this.btnStopCursor = new System.Windows.Forms.Button();
            this.btnClipBox = new System.Windows.Forms.Button();
            this.btnStartCursor = new System.Windows.Forms.Button();
            this.lbValueBoardOpened = new System.Windows.Forms.Label();
            this.lbValueMousePosition = new System.Windows.Forms.Label();
            this.grbTimerLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTimerLog
            // 
            this.grbTimerLog.Controls.Add(this.lbValuePoint);
            this.grbTimerLog.Controls.Add(this.lbNamePoint);
            this.grbTimerLog.Controls.Add(this.lbValueStep);
            this.grbTimerLog.Controls.Add(this.lbNameStep);
            this.grbTimerLog.Controls.Add(this.lbValueTick);
            this.grbTimerLog.Controls.Add(this.lbNameTick);
            this.grbTimerLog.Location = new System.Drawing.Point(10, 74);
            this.grbTimerLog.Name = "grbTimerLog";
            this.grbTimerLog.Size = new System.Drawing.Size(312, 104);
            this.grbTimerLog.TabIndex = 21;
            this.grbTimerLog.TabStop = false;
            this.grbTimerLog.Text = " Timer started     = ";
            // 
            // lbValuePoint
            // 
            this.lbValuePoint.AutoSize = true;
            this.lbValuePoint.Location = new System.Drawing.Point(113, 81);
            this.lbValuePoint.Name = "lbValuePoint";
            this.lbValuePoint.Size = new System.Drawing.Size(16, 17);
            this.lbValuePoint.TabIndex = 6;
            this.lbValuePoint.Text = "=";
            // 
            // lbNamePoint
            // 
            this.lbNamePoint.AutoSize = true;
            this.lbNamePoint.Location = new System.Drawing.Point(62, 81);
            this.lbNamePoint.Name = "lbNamePoint";
            this.lbNamePoint.Size = new System.Drawing.Size(40, 17);
            this.lbNamePoint.TabIndex = 5;
            this.lbNamePoint.Text = "Point";
            // 
            // lbValueStep
            // 
            this.lbValueStep.AutoSize = true;
            this.lbValueStep.Location = new System.Drawing.Point(113, 54);
            this.lbValueStep.Name = "lbValueStep";
            this.lbValueStep.Size = new System.Drawing.Size(16, 17);
            this.lbValueStep.TabIndex = 4;
            this.lbValueStep.Text = "=";
            // 
            // lbNameStep
            // 
            this.lbNameStep.AutoSize = true;
            this.lbNameStep.Location = new System.Drawing.Point(62, 54);
            this.lbNameStep.Name = "lbNameStep";
            this.lbNameStep.Size = new System.Drawing.Size(37, 17);
            this.lbNameStep.TabIndex = 3;
            this.lbNameStep.Text = "Step";
            // 
            // lbValueTick
            // 
            this.lbValueTick.AutoSize = true;
            this.lbValueTick.Location = new System.Drawing.Point(113, 27);
            this.lbValueTick.Name = "lbValueTick";
            this.lbValueTick.Size = new System.Drawing.Size(16, 17);
            this.lbValueTick.TabIndex = 2;
            this.lbValueTick.Text = "=";
            // 
            // lbNameTick
            // 
            this.lbNameTick.AutoSize = true;
            this.lbNameTick.Location = new System.Drawing.Point(62, 27);
            this.lbNameTick.Name = "lbNameTick";
            this.lbNameTick.Size = new System.Drawing.Size(34, 17);
            this.lbNameTick.TabIndex = 1;
            this.lbNameTick.Text = "Tick";
            // 
            // lbNameMousePosition
            // 
            this.lbNameMousePosition.AutoSize = true;
            this.lbNameMousePosition.Location = new System.Drawing.Point(9, 182);
            this.lbNameMousePosition.Name = "lbNameMousePosition";
            this.lbNameMousePosition.Size = new System.Drawing.Size(103, 17);
            this.lbNameMousePosition.TabIndex = 20;
            this.lbNameMousePosition.Text = "Mouse position";
            // 
            // lbNameBoardOpened
            // 
            this.lbNameBoardOpened.AutoSize = true;
            this.lbNameBoardOpened.Location = new System.Drawing.Point(15, 47);
            this.lbNameBoardOpened.Name = "lbNameBoardOpened";
            this.lbNameBoardOpened.Size = new System.Drawing.Size(98, 17);
            this.lbNameBoardOpened.TabIndex = 19;
            this.lbNameBoardOpened.Tag = "";
            this.lbNameBoardOpened.Text = "Board opened";
            // 
            // btnStopCursor
            // 
            this.btnStopCursor.AutoSize = true;
            this.btnStopCursor.Location = new System.Drawing.Point(112, 10);
            this.btnStopCursor.Name = "btnStopCursor";
            this.btnStopCursor.Size = new System.Drawing.Size(91, 27);
            this.btnStopCursor.TabIndex = 17;
            this.btnStopCursor.Text = "Stop shape";
            this.btnStopCursor.UseVisualStyleBackColor = true;
            // 
            // btnClipBox
            // 
            this.btnClipBox.AutoSize = true;
            this.btnClipBox.Location = new System.Drawing.Point(213, 10);
            this.btnClipBox.Name = "btnClipBox";
            this.btnClipBox.Size = new System.Drawing.Size(103, 27);
            this.btnClipBox.TabIndex = 18;
            this.btnClipBox.Text = "Show clip box";
            this.btnClipBox.UseVisualStyleBackColor = true;
            // 
            // btnStartCursor
            // 
            this.btnStartCursor.AutoSize = true;
            this.btnStartCursor.Location = new System.Drawing.Point(10, 10);
            this.btnStartCursor.Name = "btnStartCursor";
            this.btnStartCursor.Size = new System.Drawing.Size(92, 27);
            this.btnStartCursor.TabIndex = 16;
            this.btnStartCursor.Text = "Start shape";
            this.btnStartCursor.UseVisualStyleBackColor = true;
            // 
            // lbValueBoardOpened
            // 
            this.lbValueBoardOpened.AutoSize = true;
            this.lbValueBoardOpened.Location = new System.Drawing.Point(124, 47);
            this.lbValueBoardOpened.Name = "lbValueBoardOpened";
            this.lbValueBoardOpened.Size = new System.Drawing.Size(16, 17);
            this.lbValueBoardOpened.TabIndex = 22;
            this.lbValueBoardOpened.Text = "=";
            // 
            // lbValueMousePosition
            // 
            this.lbValueMousePosition.AutoSize = true;
            this.lbValueMousePosition.Location = new System.Drawing.Point(124, 182);
            this.lbValueMousePosition.Name = "lbValueMousePosition";
            this.lbValueMousePosition.Size = new System.Drawing.Size(16, 17);
            this.lbValueMousePosition.TabIndex = 23;
            this.lbValueMousePosition.Text = "=";
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 253);
            this.Controls.Add(this.lbValueMousePosition);
            this.Controls.Add(this.lbValueBoardOpened);
            this.Controls.Add(this.grbTimerLog);
            this.Controls.Add(this.lbNameMousePosition);
            this.Controls.Add(this.lbNameBoardOpened);
            this.Controls.Add(this.btnStopCursor);
            this.Controls.Add(this.btnClipBox);
            this.Controls.Add(this.btnStartCursor);
            this.Name = "frmBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Board";
            this.grbTimerLog.ResumeLayout(false);
            this.grbTimerLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTimerLog;
        private System.Windows.Forms.Label lbValuePoint;
        private System.Windows.Forms.Label lbNamePoint;
        private System.Windows.Forms.Label lbValueStep;
        private System.Windows.Forms.Label lbNameStep;
        private System.Windows.Forms.Label lbValueTick;
        private System.Windows.Forms.Label lbNameTick;
        private System.Windows.Forms.Label lbNameMousePosition;
        private System.Windows.Forms.Label lbNameBoardOpened;
        private System.Windows.Forms.Button btnStopCursor;
        private System.Windows.Forms.Button btnClipBox;
        private System.Windows.Forms.Button btnStartCursor;
        private System.Windows.Forms.Label lbValueBoardOpened;
        private System.Windows.Forms.Label lbValueMousePosition;
    }
}

