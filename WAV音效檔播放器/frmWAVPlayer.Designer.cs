namespace WAV音效檔播放器
{
    partial class frmWAVPlayer
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
            this.grpPath = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.ofdWAVFile = new System.Windows.Forms.OpenFileDialog();
            this.grpPath.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPath
            // 
            this.grpPath.Controls.Add(this.btnBrowse);
            this.grpPath.Controls.Add(this.txtPath);
            this.grpPath.Location = new System.Drawing.Point(125, 59);
            this.grpPath.Name = "grpPath";
            this.grpPath.Size = new System.Drawing.Size(514, 100);
            this.grpPath.TabIndex = 0;
            this.grpPath.TabStop = false;
            this.grpPath.Text = "音效位置";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.BtnEnd);
            this.grpButton.Controls.Add(this.btnStop);
            this.grpButton.Controls.Add(this.btnLoop);
            this.grpButton.Controls.Add(this.btnPlay);
            this.grpButton.Location = new System.Drawing.Point(125, 202);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(514, 100);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "播放按鈕";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(17, 39);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(348, 25);
            this.txtPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(391, 39);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(104, 25);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "瀏覽";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(38, 34);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(105, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "播放一次";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(149, 34);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(105, 40);
            this.btnLoop.TabIndex = 1;
            this.btnLoop.Text = "重複播放";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(260, 34);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 40);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止播放";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Location = new System.Drawing.Point(371, 34);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(104, 40);
            this.BtnEnd.TabIndex = 3;
            this.BtnEnd.Text = "結束程式";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // ofdWAVFile
            // 
            this.ofdWAVFile.DefaultExt = "wav";
            // 
            // frmWAVPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPath);
            this.Name = "frmWAVPlayer";
            this.Text = "WAV音效檔撥放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWAVPlayer_FormClosing);
            this.grpPath.ResumeLayout(false);
            this.grpPath.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPath;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.OpenFileDialog ofdWAVFile;
    }
}

