namespace MontyHall
{
    partial class MontyHall
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Door1 = new System.Windows.Forms.Button();
            this.Door2 = new System.Windows.Forms.Button();
            this.Door3 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.DoorResult1 = new System.Windows.Forms.Label();
            this.DoorResult2 = new System.Windows.Forms.Label();
            this.DoorResult3 = new System.Windows.Forms.Label();
            this.Changing = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Door1
            // 
            this.Door1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Door1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Door1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Door1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Door1.Location = new System.Drawing.Point(59, 121);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(160, 200);
            this.Door1.TabIndex = 0;
            this.Door1.Text = "Door1";
            this.Door1.UseVisualStyleBackColor = false;
            this.Door1.Click += new System.EventHandler(this.Door_Clicked);
            // 
            // Door2
            // 
            this.Door2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Door2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Door2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Door2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Door2.Location = new System.Drawing.Point(319, 121);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(160, 200);
            this.Door2.TabIndex = 1;
            this.Door2.Text = "Door2";
            this.Door2.UseVisualStyleBackColor = false;
            this.Door2.Click += new System.EventHandler(this.Door_Clicked);
            // 
            // Door3
            // 
            this.Door3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Door3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Door3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Door3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Door3.Location = new System.Drawing.Point(574, 121);
            this.Door3.Name = "Door3";
            this.Door3.Size = new System.Drawing.Size(160, 200);
            this.Door3.TabIndex = 2;
            this.Door3.Text = "Door3";
            this.Door3.UseVisualStyleBackColor = false;
            this.Door3.Click += new System.EventHandler(this.Door_Clicked);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(31, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(604, 82);
            this.Title.TabIndex = 3;
            this.Title.Text = "Welcome to MontyHall!!";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(34, 349);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(500, 70);
            this.Result.TabIndex = 4;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoorResult1
            // 
            this.DoorResult1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DoorResult1.Font = new System.Drawing.Font("Segoe Print", 16F);
            this.DoorResult1.Location = new System.Drawing.Point(84, 254);
            this.DoorResult1.Name = "DoorResult1";
            this.DoorResult1.Size = new System.Drawing.Size(110, 50);
            this.DoorResult1.TabIndex = 5;
            this.DoorResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoorResult2
            // 
            this.DoorResult2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DoorResult2.Font = new System.Drawing.Font("Segoe Print", 16F);
            this.DoorResult2.Location = new System.Drawing.Point(346, 254);
            this.DoorResult2.Name = "DoorResult2";
            this.DoorResult2.Size = new System.Drawing.Size(110, 50);
            this.DoorResult2.TabIndex = 6;
            this.DoorResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoorResult3
            // 
            this.DoorResult3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DoorResult3.Font = new System.Drawing.Font("Segoe Print", 16F);
            this.DoorResult3.Location = new System.Drawing.Point(602, 254);
            this.DoorResult3.Name = "DoorResult3";
            this.DoorResult3.Size = new System.Drawing.Size(110, 50);
            this.DoorResult3.TabIndex = 7;
            this.DoorResult3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Changing
            // 
            this.Changing.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Changing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Changing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Changing.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changing.Location = new System.Drawing.Point(574, 349);
            this.Changing.Name = "Changing";
            this.Changing.Size = new System.Drawing.Size(160, 70);
            this.Changing.TabIndex = 8;
            this.Changing.Text = "Change";
            this.Changing.UseVisualStyleBackColor = false;
            this.Changing.Click += new System.EventHandler(this.Changing_Click);
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(654, 37);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(80, 50);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // MontyHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Changing);
            this.Controls.Add(this.DoorResult3);
            this.Controls.Add(this.DoorResult2);
            this.Controls.Add(this.DoorResult1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Door3);
            this.Controls.Add(this.Door2);
            this.Controls.Add(this.Door1);
            this.Name = "MontyHall";
            this.Text = "QuestionForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Door3_Click1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Door1_Click1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button Door1;
        private System.Windows.Forms.Button Door2;
        private System.Windows.Forms.Button Door3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label DoorResult1;
        private System.Windows.Forms.Label DoorResult2;
        private System.Windows.Forms.Label DoorResult3;
        private System.Windows.Forms.Button Changing;
        private System.Windows.Forms.Button Reset;
    }
}

