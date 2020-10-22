namespace WindowsFormsApp20201022
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.go = new System.Windows.Forms.Button();
            this.rtbmsg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.go.Location = new System.Drawing.Point(291, 89);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(112, 90);
            this.go.TabIndex = 0;
            this.go.Text = "go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.Go_Click);
            // 
            // rtbmsg
            // 
            this.rtbmsg.Location = new System.Drawing.Point(244, 215);
            this.rtbmsg.Name = "rtbmsg";
            this.rtbmsg.Size = new System.Drawing.Size(260, 132);
            this.rtbmsg.TabIndex = 1;
            this.rtbmsg.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbmsg);
            this.Controls.Add(this.go);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go;
        private System.Windows.Forms.RichTextBox rtbmsg;
    }
}

