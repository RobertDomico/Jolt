namespace Jolt
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            btnHide = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            maskedTextBoxInterval = new System.Windows.Forms.MaskedTextBox();
            maskedTextBoxOff = new System.Windows.Forms.MaskedTextBox();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // btnHide
            // 
            btnHide.Location = new System.Drawing.Point(191, 226);
            btnHide.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnHide.Name = "btnHide";
            btnHide.Size = new System.Drawing.Size(125, 44);
            btnHide.TabIndex = 0;
            btnHide.Text = "Hide";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += BtnHide_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 29);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(161, 25);
            label1.TabIndex = 2;
            label1.Text = "Interval in Seconds";
            // 
            // maskedTextBoxInterval
            // 
            maskedTextBoxInterval.Location = new System.Drawing.Point(38, 60);
            maskedTextBoxInterval.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            maskedTextBoxInterval.Mask = "00000";
            maskedTextBoxInterval.Name = "maskedTextBoxInterval";
            maskedTextBoxInterval.Size = new System.Drawing.Size(66, 31);
            maskedTextBoxInterval.TabIndex = 3;
            maskedTextBoxInterval.ValidatingType = typeof(int);
            // 
            // maskedTextBoxOff
            // 
            maskedTextBoxOff.Location = new System.Drawing.Point(38, 155);
            maskedTextBoxOff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            maskedTextBoxOff.Mask = "00000";
            maskedTextBoxOff.Name = "maskedTextBoxOff";
            maskedTextBoxOff.Size = new System.Drawing.Size(66, 31);
            maskedTextBoxOff.TabIndex = 5;
            maskedTextBoxOff.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(33, 124);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(162, 25);
            label2.TabIndex = 4;
            label2.Text = "Turn off in Minutes";
            // 
            // Main
            // 
            AcceptButton = btnHide;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(315, 281);
            ControlBox = false;
            Controls.Add(maskedTextBoxOff);
            Controls.Add(label2);
            Controls.Add(maskedTextBoxInterval);
            Controls.Add(label1);
            Controls.Add(btnHide);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximumSize = new System.Drawing.Size(337, 337);
            MinimumSize = new System.Drawing.Size(337, 337);
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Jolt";
            TopMost = true;
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInterval;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOff;
        private System.Windows.Forms.Label label2;
    }
}

