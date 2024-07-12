namespace salleSport
{
    partial class backUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backUp));
            this.bar = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.minimaze = new System.Windows.Forms.PictureBox();
            this.retuurn = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_browser = new System.Windows.Forms.Button();
            this.txt_foder_backup = new System.Windows.Forms.TextBox();
            this.lb_progress = new System.Windows.Forms.Label();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retuurn)).BeginInit();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.bar.Controls.Add(this.close);
            this.bar.Controls.Add(this.minimaze);
            this.bar.Controls.Add(this.retuurn);
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(689, 40);
            this.bar.TabIndex = 105;
            this.bar.Paint += new System.Windows.Forms.PaintEventHandler(this.bar_Paint);
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown_1);
            this.bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bar_MouseMove_1);
            this.bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bar_MouseUp_1);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::salleSport.Properties.Resources.close__3_;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(607, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 33);
            this.close.TabIndex = 106;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimaze
            // 
            this.minimaze.BackColor = System.Drawing.Color.Transparent;
            this.minimaze.BackgroundImage = global::salleSport.Properties.Resources.minimize__1_;
            this.minimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimaze.Location = new System.Drawing.Point(569, 7);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(30, 33);
            this.minimaze.TabIndex = 107;
            this.minimaze.TabStop = false;
            this.minimaze.Click += new System.EventHandler(this.minimaze_Click);
            // 
            // retuurn
            // 
            this.retuurn.BackColor = System.Drawing.Color.Transparent;
            this.retuurn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retuurn.BackgroundImage")));
            this.retuurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.retuurn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retuurn.Location = new System.Drawing.Point(7, 3);
            this.retuurn.Name = "retuurn";
            this.retuurn.Size = new System.Drawing.Size(35, 33);
            this.retuurn.TabIndex = 108;
            this.retuurn.TabStop = false;
            this.retuurn.Click += new System.EventHandler(this.retuurn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(103, 173);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(436, 16);
            this.progressBar1.TabIndex = 110;
            // 
            // btn_browser
            // 
            this.btn_browser.Location = new System.Drawing.Point(451, 95);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(87, 27);
            this.btn_browser.TabIndex = 115;
            this.btn_browser.Text = "Parcourir";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.btn_browser_Click);
            // 
            // txt_foder_backup
            // 
            this.txt_foder_backup.Location = new System.Drawing.Point(103, 96);
            this.txt_foder_backup.Name = "txt_foder_backup";
            this.txt_foder_backup.ReadOnly = true;
            this.txt_foder_backup.Size = new System.Drawing.Size(341, 21);
            this.txt_foder_backup.TabIndex = 118;
            // 
            // lb_progress
            // 
            this.lb_progress.AutoSize = true;
            this.lb_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_progress.Location = new System.Drawing.Point(99, 140);
            this.lb_progress.Name = "lb_progress";
            this.lb_progress.Size = new System.Drawing.Size(11, 16);
            this.lb_progress.TabIndex = 119;
            this.lb_progress.Text = ".";
            // 
            // btn_restore
            // 
            this.btn_restore.BackColor = System.Drawing.Color.White;
            this.btn_restore.BackgroundImage = global::salleSport.Properties.Resources.backup;
            this.btn_restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_restore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_restore.Location = new System.Drawing.Point(330, 228);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(148, 120);
            this.btn_restore.TabIndex = 114;
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.White;
            this.btn_backup.BackgroundImage = global::salleSport.Properties.Resources.arrow;
            this.btn_backup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backup.ForeColor = System.Drawing.Color.Transparent;
            this.btn_backup.Location = new System.Drawing.Point(155, 228);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Padding = new System.Windows.Forms.Padding(12);
            this.btn_backup.Size = new System.Drawing.Size(148, 120);
            this.btn_backup.TabIndex = 113;
            this.btn_backup.UseVisualStyleBackColor = false;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // backUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(652, 389);
            this.Controls.Add(this.lb_progress);
            this.Controls.Add(this.txt_foder_backup);
            this.Controls.Add(this.btn_browser);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "backUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "backUp";
            this.Load += new System.EventHandler(this.backUp_Load);
            this.bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retuurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    
        private System.Windows.Forms.PictureBox retuurn;
        private System.Windows.Forms.PictureBox minimaze;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_browser;
        private System.Windows.Forms.TextBox txt_foder_backup;
        private System.Windows.Forms.Label lb_progress;
    }
}