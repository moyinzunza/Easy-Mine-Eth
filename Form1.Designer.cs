
namespace LatinmineWin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.textbox_wallet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxLog = new System.Windows.Forms.TextBox();
            this.button_to_worker = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.PaleGreen;
            this.button_start.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_start.Location = new System.Drawing.Point(596, 19);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(93, 36);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textbox_wallet
            // 
            this.textbox_wallet.Location = new System.Drawing.Point(12, 27);
            this.textbox_wallet.Name = "textbox_wallet";
            this.textbox_wallet.Size = new System.Drawing.Size(391, 23);
            this.textbox_wallet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ETH Wallet";
            // 
            // textboxLog
            // 
            this.textboxLog.BackColor = System.Drawing.SystemColors.Desktop;
            this.textboxLog.ForeColor = System.Drawing.Color.Aqua;
            this.textboxLog.Location = new System.Drawing.Point(12, 61);
            this.textboxLog.Multiline = true;
            this.textboxLog.Name = "textboxLog";
            this.textboxLog.ReadOnly = true;
            this.textboxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxLog.Size = new System.Drawing.Size(776, 304);
            this.textboxLog.TabIndex = 3;
            // 
            // button_to_worker
            // 
            this.button_to_worker.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_to_worker.Location = new System.Drawing.Point(12, 415);
            this.button_to_worker.Name = "button_to_worker";
            this.button_to_worker.Size = new System.Drawing.Size(391, 23);
            this.button_to_worker.TabIndex = 4;
            this.button_to_worker.Text = "Open worker info on latinmine";
            this.button_to_worker.UseVisualStyleBackColor = false;
            this.button_to_worker.Click += new System.EventHandler(this.button_to_worker_Click);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stop_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.stop_button.Location = new System.Drawing.Point(695, 19);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(93, 36);
            this.stop_button.TabIndex = 5;
            this.stop_button.Text = "STOP";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.button_to_worker);
            this.Controls.Add(this.textboxLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_wallet);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Easy Latinmine mining";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textbox_wallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxLog;
        private System.Windows.Forms.Button button_to_worker;
        private System.Windows.Forms.Button stop_button;
    }
}

