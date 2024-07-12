using System.Windows.Forms;

namespace salleSport
{
    partial class addAdhrent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAdhrent));
            this.label1 = new System.Windows.Forms.Label();
            this.bare = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnValider = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdF = new System.Windows.Forms.RadioButton();
            this.rdM = new System.Windows.Forms.RadioButton();
            this.txtSommeP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtaddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNbrmois = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPren = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtRemarque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboctgSport = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ckCatgSport = new Bunifu.Framework.UI.BunifuSwitch();
            this.picture = new System.Windows.Forms.PictureBox();
            this.minimaze = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.retuurn = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retuurn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ajouter adhérent";
            // 
            // bare
            // 
            this.bare.BackColor = System.Drawing.Color.Black;
            this.bare.ForeColor = System.Drawing.Color.White;
            this.bare.Location = new System.Drawing.Point(-6, -4);
            this.bare.Name = "bare";
            this.bare.Size = new System.Drawing.Size(754, 10);
            this.bare.TabIndex = 32;
            this.bare.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bare_MouseDown);
            this.bare.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bare_MouseMove);
            this.bare.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bare_MouseUp);
            // 
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.BackColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox5.HintText = "";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox5.LineThickness = 3;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(60, 22);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(133, 32);
            this.bunifuMaterialTextbox5.TabIndex = 33;
            this.bunifuMaterialTextbox5.Text = "nom";
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Black;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(288, 588);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(183, 34);
            this.btnValider.TabIndex = 33;
            this.btnValider.Text = "valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdF);
            this.groupBox2.Controls.Add(this.rdM);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(434, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 53);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "sexe";
            // 
            // rdF
            // 
            this.rdF.AutoSize = true;
            this.rdF.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdF.Location = new System.Drawing.Point(102, 21);
            this.rdF.Name = "rdF";
            this.rdF.Size = new System.Drawing.Size(70, 19);
            this.rdF.TabIndex = 1;
            this.rdF.Text = "Féminin";
            this.rdF.UseVisualStyleBackColor = true;
            // 
            // rdM
            // 
            this.rdM.AutoSize = true;
            this.rdM.Checked = true;
            this.rdM.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdM.Location = new System.Drawing.Point(23, 21);
            this.rdM.Name = "rdM";
            this.rdM.Size = new System.Drawing.Size(75, 19);
            this.rdM.TabIndex = 0;
            this.rdM.TabStop = true;
            this.rdM.Text = "Masculin";
            this.rdM.UseVisualStyleBackColor = true;
            // 
            // txtSommeP
            // 
            this.txtSommeP.BackColor = System.Drawing.Color.White;
            this.txtSommeP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSommeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSommeP.ForeColor = System.Drawing.Color.Black;
            this.txtSommeP.HintForeColor = System.Drawing.Color.Empty;
            this.txtSommeP.HintText = "";
            this.txtSommeP.isPassword = false;
            this.txtSommeP.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtSommeP.LineIdleColor = System.Drawing.Color.Black;
            this.txtSommeP.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtSommeP.LineThickness = 3;
            this.txtSommeP.Location = new System.Drawing.Point(436, 453);
            this.txtSommeP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSommeP.Name = "txtSommeP";
            this.txtSommeP.Size = new System.Drawing.Size(181, 33);
            this.txtSommeP.TabIndex = 44;
            this.txtSommeP.Text = "0";
            this.txtSommeP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtSommeP, "Entre Somme Payé");
            this.txtSommeP.Enter += new System.EventHandler(this.txtSommeP_Enter);
            this.txtSommeP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSommeP_KeyPress);
            this.txtSommeP.Leave += new System.EventHandler(this.txtSommeP_Leave);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.White;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.HintForeColor = System.Drawing.Color.Empty;
            this.txtTel.HintText = "";
            this.txtTel.isPassword = false;
            this.txtTel.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtTel.LineIdleColor = System.Drawing.Color.Black;
            this.txtTel.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtTel.LineThickness = 3;
            this.txtTel.Location = new System.Drawing.Point(126, 260);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(184, 33);
            this.txtTel.TabIndex = 43;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtTel, "Entre Telephone");
            this.txtTel.Enter += new System.EventHandler(this.txtTel_Enter);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            this.txtTel.Leave += new System.EventHandler(this.txtTel_Leave);
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtaddress.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtaddress.HintText = "";
            this.txtaddress.isPassword = false;
            this.txtaddress.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtaddress.LineIdleColor = System.Drawing.Color.Black;
            this.txtaddress.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtaddress.LineThickness = 3;
            this.txtaddress.Location = new System.Drawing.Point(129, 207);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(181, 33);
            this.txtaddress.TabIndex = 42;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtaddress, "Entre Adress");
            this.txtaddress.Enter += new System.EventHandler(this.txtaddress_Enter);
            this.txtaddress.Leave += new System.EventHandler(this.txtaddress_Leave);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.White;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNom.ForeColor = System.Drawing.Color.Black;
            this.txtNom.HintForeColor = System.Drawing.Color.Empty;
            this.txtNom.HintText = "";
            this.txtNom.isPassword = false;
            this.txtNom.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtNom.LineIdleColor = System.Drawing.Color.Black;
            this.txtNom.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtNom.LineThickness = 3;
            this.txtNom.Location = new System.Drawing.Point(129, 101);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(181, 33);
            this.txtNom.TabIndex = 45;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtNom, "Entre  name");
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // txtNbrmois
            // 
            this.txtNbrmois.BackColor = System.Drawing.Color.White;
            this.txtNbrmois.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNbrmois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNbrmois.ForeColor = System.Drawing.Color.Black;
            this.txtNbrmois.HintForeColor = System.Drawing.Color.Empty;
            this.txtNbrmois.HintText = "";
            this.txtNbrmois.isPassword = false;
            this.txtNbrmois.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtNbrmois.LineIdleColor = System.Drawing.Color.Black;
            this.txtNbrmois.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtNbrmois.LineThickness = 3;
            this.txtNbrmois.Location = new System.Drawing.Point(436, 512);
            this.txtNbrmois.Margin = new System.Windows.Forms.Padding(4);
            this.txtNbrmois.Name = "txtNbrmois";
            this.txtNbrmois.Size = new System.Drawing.Size(181, 33);
            this.txtNbrmois.TabIndex = 47;
            this.txtNbrmois.Text = "1";
            this.txtNbrmois.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtNbrmois, "Entre nombre mois payé");
            this.txtNbrmois.Enter += new System.EventHandler(this.txtNbrmois_Enter);
            this.txtNbrmois.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNbrmois_KeyPress);
            this.txtNbrmois.Leave += new System.EventHandler(this.txtNbrmois_Leave);
            // 
            // txtPren
            // 
            this.txtPren.BackColor = System.Drawing.Color.White;
            this.txtPren.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPren.ForeColor = System.Drawing.Color.Black;
            this.txtPren.HintForeColor = System.Drawing.Color.Empty;
            this.txtPren.HintText = "";
            this.txtPren.isPassword = false;
            this.txtPren.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtPren.LineIdleColor = System.Drawing.Color.Black;
            this.txtPren.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtPren.LineThickness = 3;
            this.txtPren.Location = new System.Drawing.Point(129, 154);
            this.txtPren.Margin = new System.Windows.Forms.Padding(4);
            this.txtPren.Name = "txtPren";
            this.txtPren.Size = new System.Drawing.Size(181, 33);
            this.txtPren.TabIndex = 48;
            this.txtPren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtPren, "Entre  prenom");
            this.txtPren.Enter += new System.EventHandler(this.txtPren_Enter);
            this.txtPren.Leave += new System.EventHandler(this.txtPren_Leave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // txtRemarque
            // 
            this.txtRemarque.BackColor = System.Drawing.Color.White;
            this.txtRemarque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtRemarque.ForeColor = System.Drawing.Color.Black;
            this.txtRemarque.Location = new System.Drawing.Point(126, 315);
            this.txtRemarque.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarque.Multiline = true;
            this.txtRemarque.Name = "txtRemarque";
            this.txtRemarque.Size = new System.Drawing.Size(278, 250);
            this.txtRemarque.TabIndex = 61;
            this.toolTip1.SetToolTip(this.txtRemarque, "Entre  remarque");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(433, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Somme payée (dh)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Reste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(185, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(193, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(192, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(202, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 55;
            // 
            // comboctgSport
            // 
            this.comboctgSport.FormattingEnabled = true;
            this.comboctgSport.Location = new System.Drawing.Point(431, 392);
            this.comboctgSport.Name = "comboctgSport";
            this.comboctgSport.Size = new System.Drawing.Size(184, 21);
            this.comboctgSport.TabIndex = 58;
            this.comboctgSport.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(435, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Type de soin";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ckCatgSport
            // 
            this.ckCatgSport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckCatgSport.BorderRadius = 0;
            this.ckCatgSport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckCatgSport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckCatgSport.Location = new System.Drawing.Point(572, 353);
            this.ckCatgSport.Name = "ckCatgSport";
            this.ckCatgSport.Oncolor = System.Drawing.Color.SeaGreen;
            this.ckCatgSport.Onoffcolor = System.Drawing.Color.DarkGray;
            this.ckCatgSport.Size = new System.Drawing.Size(51, 19);
            this.ckCatgSport.TabIndex = 60;
            this.ckCatgSport.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckCatgSport.Value = false;
            this.ckCatgSport.Click += new System.EventHandler(this.ckCatgSport_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture.BackgroundImage")));
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture.ErrorImage = null;
            this.picture.Location = new System.Drawing.Point(409, 49);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(241, 241);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // minimaze
            // 
            this.minimaze.BackColor = System.Drawing.Color.Black;
            this.minimaze.BackgroundImage = global::salleSport.Properties.Resources.minimize__1_;
            this.minimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimaze.Location = new System.Drawing.Point(835, 26);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(28, 29);
            this.minimaze.TabIndex = 4;
            this.minimaze.TabStop = false;
            this.minimaze.Click += new System.EventHandler(this.minimaze_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Black;
            this.close.BackgroundImage = global::salleSport.Properties.Resources.close__3_;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(867, 26);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 29);
            this.close.TabIndex = 3;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // retuurn
            // 
            this.retuurn.BackColor = System.Drawing.Color.Gainsboro;
            this.retuurn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retuurn.BackgroundImage")));
            this.retuurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.retuurn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retuurn.Location = new System.Drawing.Point(14, 26);
            this.retuurn.Name = "retuurn";
            this.retuurn.Size = new System.Drawing.Size(30, 29);
            this.retuurn.TabIndex = 0;
            this.retuurn.TabStop = false;
            this.retuurn.Click += new System.EventHandler(this.retuurn_Click);
            // 
            // addAdhrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::salleSport.Properties.Resources.flat_dental_care_concept_23_2148984320;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 646);
            this.Controls.Add(this.txtRemarque);
            this.Controls.Add(this.ckCatgSport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboctgSport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPren);
            this.Controls.Add(this.txtNbrmois);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSommeP);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.bare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.minimaze);
            this.Controls.Add(this.close);
            this.Controls.Add(this.retuurn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addAdhrent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.addAdhrent_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retuurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox retuurn;
        private System.Windows.Forms.PictureBox minimaze;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
         
        private System.Windows.Forms.Panel bare;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdF;
        private System.Windows.Forms.RadioButton rdM;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSommeP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtaddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNbrmois;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPren;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboctgSport;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuSwitch ckCatgSport;
        private TextBox txtRemarque;
    }
}