namespace AlarmWinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxTime = new TextBox();
            buttonStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(30, 30);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(200, 27);
            textBoxTime.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(250, 30);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(104, 27);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            ClientSize = new Size(438, 121);
            Controls.Add(buttonStart);
            Controls.Add(textBoxTime);
            Name = "Form1";
            Text = "Event-Driven Alarm App";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
