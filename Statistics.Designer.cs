namespace MontyHall
{
    partial class Statistics
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
            this.GameCount = new System.Windows.Forms.Label();
            this.WinCount = new System.Windows.Forms.Label();
            this.WinRatio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("ＭＳ 明朝", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(84, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("ＭＳ 明朝", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(84, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = "Win Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("ＭＳ 明朝", 26F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(84, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 100);
            this.label3.TabIndex = 2;
            this.label3.Text = "Win Ratio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameCount
            // 
            this.GameCount.BackColor = System.Drawing.SystemColors.Control;
            this.GameCount.Font = new System.Drawing.Font("ＭＳ 明朝", 26F, System.Drawing.FontStyle.Bold);
            this.GameCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameCount.Location = new System.Drawing.Point(420, 86);
            this.GameCount.Name = "GameCount";
            this.GameCount.Size = new System.Drawing.Size(300, 100);
            this.GameCount.TabIndex = 3;
            this.GameCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinCount
            // 
            this.WinCount.BackColor = System.Drawing.SystemColors.Control;
            this.WinCount.Font = new System.Drawing.Font("ＭＳ 明朝", 26F, System.Drawing.FontStyle.Bold);
            this.WinCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WinCount.Location = new System.Drawing.Point(420, 195);
            this.WinCount.Name = "WinCount";
            this.WinCount.Size = new System.Drawing.Size(300, 100);
            this.WinCount.TabIndex = 4;
            this.WinCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinRatio
            // 
            this.WinRatio.BackColor = System.Drawing.SystemColors.Control;
            this.WinRatio.Font = new System.Drawing.Font("ＭＳ 明朝", 26F, System.Drawing.FontStyle.Bold);
            this.WinRatio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WinRatio.Location = new System.Drawing.Point(420, 303);
            this.WinRatio.Name = "WinRatio";
            this.WinRatio.Size = new System.Drawing.Size(300, 100);
            this.WinRatio.TabIndex = 5;
            this.WinRatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ＭＳ 明朝", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(236, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 60);
            this.label7.TabIndex = 6;
            this.label7.Text = "Statistics";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WinRatio);
            this.Controls.Add(this.WinCount);
            this.Controls.Add(this.GameCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GameCount;
        private System.Windows.Forms.Label WinCount;
        private System.Windows.Forms.Label WinRatio;
        private System.Windows.Forms.Label label7;
    }
}