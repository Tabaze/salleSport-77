namespace salleSport
{
    partial class login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.show = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.minimaze = new System.Windows.Forms.PictureBox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLogo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtActivation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.show);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.btnUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(371, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.ForeColor = System.Drawing.Color.Black;
            this.show.Location = new System.Drawing.Point(49, 188);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(159, 19);
            this.show.TabIndex = 6;
            this.show.Text = "Afficher le mot de passe ";
            this.show.UseVisualStyleBackColor = true;
            this.show.CheckedChanged += new System.EventHandler(this.show_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(73, 239);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Connecter";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.txtLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.txtLogin_MouseLeave);
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUser.FlatAppearance.BorderSize = 2;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Location = new System.Drawing.Point(73, 287);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(125, 38);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "Créer un compt";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click_1);
            this.btnUser.MouseEnter += new System.EventHandler(this.btnUser_MouseEnter);
            this.btnUser.MouseLeave += new System.EventHandler(this.btnUser_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "S\'identifier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(361, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 55);
            this.label2.TabIndex = 9;
            this.label2.Text = "BIENVENUE";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::salleSport.Properties.Resources.close__3_;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(939, 24);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 33);
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimaze
            // 
            this.minimaze.BackColor = System.Drawing.Color.Transparent;
            this.minimaze.BackgroundImage = global::salleSport.Properties.Resources.minimize__1_;
            this.minimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimaze.Location = new System.Drawing.Point(902, 24);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(30, 33);
            this.minimaze.TabIndex = 2;
            this.minimaze.TabStop = false;
            this.minimaze.Click += new System.EventHandler(this.minimaze_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserName.HintText = "";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.Black;
            this.txtUserName.LineIdleColor = System.Drawing.Color.Black;
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtUserName.LineThickness = 3;
            this.txtUserName.Location = new System.Drawing.Point(420, 217);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(171, 32);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Black;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Black;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(420, 253);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(171, 32);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtLogo
            // 
            this.txtLogo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogo.HintForeColor = System.Drawing.Color.Empty;
            this.txtLogo.HintText = "";
            this.txtLogo.isPassword = false;
            this.txtLogo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLogo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLogo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLogo.LineThickness = 3;
            this.txtLogo.Location = new System.Drawing.Point(0, 0);
            this.txtLogo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(370, 44);
            this.txtLogo.TabIndex = 0;
            this.txtLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtActivation
            // 
            this.txtActivation.BackColor = System.Drawing.Color.Black;
            this.txtActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtActivation.ForeColor = System.Drawing.Color.White;
            this.txtActivation.Location = new System.Drawing.Point(371, 517);
            this.txtActivation.Name = "txtActivation";
            this.txtActivation.Size = new System.Drawing.Size(271, 22);
            this.txtActivation.TabIndex = 10;
            this.txtActivation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtActivation.Visible = false;
            this.txtActivation.TextChanged += new System.EventHandler(this.txtActivation_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(436, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Licence Key";
            this.label3.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::salleSport.Properties.Resources.be_a_denist;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtActivation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.minimaze);
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.login_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox show;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimaze;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActivation;
        private System.Windows.Forms.Label label3;
    }
}

