namespace Calendar
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbdays = new Label();
            lbevent = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.AutoSize = true;
            lbdays.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lbdays.Location = new Point(15, 14);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(28, 21);
            lbdays.TabIndex = 0;
            lbdays.Text = "00";
            // 
            // lbevent
            // 
            lbevent.Location = new Point(3, 64);
            lbevent.Name = "lbevent";
            lbevent.Size = new Size(112, 27);
            lbevent.TabIndex = 1;
            lbevent.TextAlign = ContentAlignment.MiddleCenter;
            lbevent.Click += lbevent_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbevent);
            Controls.Add(lbdays);
            Name = "UserControlDays";
            Size = new Size(118, 102);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private Label lbevent;
        private System.Windows.Forms.Timer timer1;
    }
}
