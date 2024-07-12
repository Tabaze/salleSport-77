namespace salleSport
{
    partial class createUser
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
            this.txtpass1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.A = new System.Windows.Forms.CheckBox();
            this.M = new System.Windows.Forms.CheckBox();
            this.S = new System.Windows.Forms.CheckBox();
            this.V = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.PictureBox();
            this.txtpass2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpass1
            // 
            this.txtpass1.BackColor = System.Drawing.Color.White;
            this.txtpass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtpass1.ForeColor = System.Drawing.Color.Black;
            this.txtpass1.HintForeColor = System.Drawing.Color.Empty;
            this.txtpass1.HintText = "";
            this.txtpass1.isPassword = false;
            this.txtpass1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtpass1.LineIdleColor = System.Drawing.Color.Black;
            this.txtpass1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtpass1.LineThickness = 3;
            this.txtpass1.Location = new System.Drawing.Point(38, 97);
            this.txtpass1.Margin = new System.Windows.Forms.Padding(5);
            this.txtpass1.Name = "txtpass1";
            this.txtpass1.Size = new System.Drawing.Size(198, 31);
            this.txtpass1.TabIndex = 72;
            this.txtpass1.Text = "Mot de passe";
            this.txtpass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass1.Enter += new System.EventHandler(this.txtpass1_Enter);
            this.txtpass1.Leave += new System.EventHandler(this.txtpass1_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Controls.Add(this.M);
            this.groupBox1.Controls.Add(this.S);
            this.groupBox1.Controls.Add(this.V);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(36, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 135);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les rôles";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(13, 23);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(132, 22);
            this.A.TabIndex = 7;
            this.A.Text = "Ajouter adhérent";
            this.A.UseVisualStyleBackColor = true;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.Location = new System.Drawing.Point(13, 74);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(136, 22);
            this.M.TabIndex = 4;
            this.M.Text = "Modifier adhérent";
            this.M.UseVisualStyleBackColor = true;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(13, 99);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(149, 22);
            this.S.TabIndex = 3;
            this.S.Text = "Supprimer adhérent";
            this.S.UseVisualStyleBackColor = true;
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V.Location = new System.Drawing.Point(13, 48);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(129, 22);
            this.V.TabIndex = 0;
            this.V.Text = "Valider paiement";
            this.V.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 74;
            this.label1.Text = "Créer un compte";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(36, 315);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(196, 38);
            this.btnUser.TabIndex = 60;
            this.btnUser.Text = "Créer le compte";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::salleSport.Properties.Resources.close__3_;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(236, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 33);
            this.close.TabIndex = 76;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // txtpass2
            // 
            this.txtpass2.BackColor = System.Drawing.Color.White;
            this.txtpass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtpass2.ForeColor = System.Drawing.Color.Black;
            this.txtpass2.HintForeColor = System.Drawing.Color.Empty;
            this.txtpass2.HintText = "";
            this.txtpass2.isPassword = false;
            this.txtpass2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtpass2.LineIdleColor = System.Drawing.Color.Black;
            this.txtpass2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtpass2.LineThickness = 3;
            this.txtpass2.Location = new System.Drawing.Point(36, 134);
            this.txtpass2.Margin = new System.Windows.Forms.Padding(5);
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.Size = new System.Drawing.Size(198, 31);
            this.txtpass2.TabIndex = 77;
            this.txtpass2.Text = "Répéter mot de passe ";
            this.txtpass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass2.Enter += new System.EventHandler(this.txtpass2_Enter);
            this.txtpass2.Leave += new System.EventHandler(this.txtpass2_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.HintForeColor = System.Drawing.Color.Empty;
            this.txtUser.HintText = "";
            this.txtUser.isPassword = false;
            this.txtUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUser.LineIdleColor = System.Drawing.Color.Black;
            this.txtUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUser.LineThickness = 3;
            this.txtUser.Location = new System.Drawing.Point(36, 57);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(198, 31);
            this.txtUser.TabIndex = 78;
            this.txtUser.Text = "Nom d\'utilisateur";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // createUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.BackgroundImage = global::salleSport.Properties.Resources.dumbbell_1966247;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(268, 369);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtpass2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpass1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createUser";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.createUser_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.createUser_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.createUser_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.createUser_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpass1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox A;
        private System.Windows.Forms.CheckBox M;
        private System.Windows.Forms.CheckBox S;
        private System.Windows.Forms.CheckBox V;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.PictureBox close;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpass2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUser;
    }
}