
namespace salleSport
{
    partial class categoryOfSport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoryOfSport));
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gridd = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.bar = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.minimaze = new System.Windows.Forms.PictureBox();
            this.retuurn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridd)).BeginInit();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retuurn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.White;
            this.btnSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupp.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.ForeColor = System.Drawing.Color.Black;
            this.btnSupp.Location = new System.Drawing.Point(143, 244);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(132, 31);
            this.btnSupp.TabIndex = 118;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.White;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(143, 281);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(132, 31);
            this.btnModifier.TabIndex = 117;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            this.txtNom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNom.LineIdleColor = System.Drawing.Color.Black;
            this.txtNom.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNom.LineThickness = 3;
            this.txtNom.Location = new System.Drawing.Point(143, 78);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(132, 30);
            this.txtNom.TabIndex = 113;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridd
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridd.BackgroundColor = System.Drawing.Color.White;
            this.gridd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridd.DoubleBuffered = true;
            this.gridd.EnableHeadersVisualStyles = false;
            this.gridd.HeaderBgColor = System.Drawing.Color.Black;
            this.gridd.HeaderForeColor = System.Drawing.Color.White;
            this.gridd.Location = new System.Drawing.Point(14, 65);
            this.gridd.Name = "gridd";
            this.gridd.ReadOnly = true;
            this.gridd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridd.Size = new System.Drawing.Size(116, 261);
            this.gridd.TabIndex = 112;
            this.gridd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridd_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(143, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 119;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.bar.Controls.Add(this.close);
            this.bar.Controls.Add(this.minimaze);
            this.bar.Controls.Add(this.retuurn);
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(286, 40);
            this.bar.TabIndex = 120;
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
            this.close.Location = new System.Drawing.Point(241, 7);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.TabIndex = 113;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimaze
            // 
            this.minimaze.BackColor = System.Drawing.Color.Transparent;
            this.minimaze.BackgroundImage = global::salleSport.Properties.Resources.minimize__1_;
            this.minimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimaze.Location = new System.Drawing.Point(210, 7);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(25, 25);
            this.minimaze.TabIndex = 114;
            this.minimaze.TabStop = false;
            this.minimaze.Click += new System.EventHandler(this.minimaze_Click);
            // 
            // retuurn
            // 
            this.retuurn.BackColor = System.Drawing.Color.Transparent;
            this.retuurn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retuurn.BackgroundImage")));
            this.retuurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.retuurn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retuurn.Location = new System.Drawing.Point(14, 8);
            this.retuurn.Name = "retuurn";
            this.retuurn.Size = new System.Drawing.Size(28, 25);
            this.retuurn.TabIndex = 115;
            this.retuurn.TabStop = false;
            this.retuurn.Click += new System.EventHandler(this.retuurn_Click);
            // 
            // categoryOfSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 366);
            this.ControlBox = false;
            this.Controls.Add(this.bar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.gridd);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoryOfSport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoryOfSport";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.categoryOfSport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridd)).EndInit();
            this.bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retuurn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModifier;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNom;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimaze;
        private System.Windows.Forms.PictureBox retuurn;
    }
}