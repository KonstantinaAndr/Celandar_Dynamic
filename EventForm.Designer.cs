﻿namespace Calendar
{
    partial class EventForm
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
            txtDate = new TextBox();
            txtEvent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Location = new Point(209, 61);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(296, 23);
            txtDate.TabIndex = 0;
            // 
            // txtEvent
            // 
            txtEvent.Location = new Point(209, 172);
            txtEvent.Name = "txtEvent";
            txtEvent.Size = new Size(296, 23);
            txtEvent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(108, 61);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 2;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(108, 167);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 3;
            label2.Text = "Event";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnSave.Location = new Point(447, 232);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(58, 42);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 317);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEvent);
            Controls.Add(txtDate);
            Name = "EventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventForm";
            Load += EventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDate;
        private TextBox txtEvent;
        private Label label1;
        private Label label2;
        private Button btnSave;
    }
}