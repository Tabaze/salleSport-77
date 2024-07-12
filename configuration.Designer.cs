namespace salleSport
{
    partial class configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configuration));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bar = new System.Windows.Forms.Panel();
            this.minimaze = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.retuurn = new System.Windows.Forms.PictureBox();
            this.btnBenifice = new System.Windows.Forms.Button();
            this.valueYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listP = new System.Windows.Forms.Button();
            this.btnMsj = new System.Windows.Forms.Button();
            this.gridd = new System.Windows.Forms.DataGridView();
            this.combo_adh = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblCredit = new System.Windows.Forms.Label();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retuurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridd)).BeginInit();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.bar.Controls.Add(this.minimaze);
            this.bar.Controls.Add(this.close);
            this.bar.Controls.Add(this.retuurn);
            this.bar.Location = new System.Drawing.Point(-5, -6);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1123, 51);
            this.bar.TabIndex = 74;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            this.bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bar_MouseMove);
            this.bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bar_MouseUp);
            // 
            // minimaze
            // 
            this.minimaze.BackColor = System.Drawing.Color.Transparent;
            this.minimaze.BackgroundImage = global::salleSport.Properties.Resources.minimize__1_;
            this.minimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimaze.Location = new System.Drawing.Point(873, 13);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(30, 33);
            this.minimaze.TabIndex = 99;
            this.minimaze.TabStop = false;
            this.minimaze.Click += new System.EventHandler(this.minimaze_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::salleSport.Properties.Resources.close__3_;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(920, 13);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 33);
            this.close.TabIndex = 98;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // retuurn
            // 
            this.retuurn.BackColor = System.Drawing.Color.Transparent;
            this.retuurn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retuurn.BackgroundImage")));
            this.retuurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.retuurn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retuurn.Location = new System.Drawing.Point(33, 13);
            this.retuurn.Name = "retuurn";
            this.retuurn.Size = new System.Drawing.Size(35, 33);
            this.retuurn.TabIndex = 100;
            this.retuurn.TabStop = false;
            this.retuurn.Click += new System.EventHandler(this.retuurn_Click);
            // 
            // btnBenifice
            // 
            this.btnBenifice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.btnBenifice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBenifice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenifice.ForeColor = System.Drawing.Color.White;
            this.btnBenifice.Location = new System.Drawing.Point(812, 106);
            this.btnBenifice.Name = "btnBenifice";
            this.btnBenifice.Size = new System.Drawing.Size(114, 28);
            this.btnBenifice.TabIndex = 102;
            this.btnBenifice.Text = "Bénifices";
            this.btnBenifice.UseVisualStyleBackColor = false;
            this.btnBenifice.Click += new System.EventHandler(this.btnBenifice_Click);
            // 
            // valueYear
            // 
            this.valueYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueYear.Location = new System.Drawing.Point(719, 106);
            this.valueYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.valueYear.Minimum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.valueYear.Name = "valueYear";
            this.valueYear.Size = new System.Drawing.Size(66, 24);
            this.valueYear.TabIndex = 106;
            this.valueYear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 107;
            this.label1.Text = "Année";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "bnf";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(629, 189);
            this.chart1.Name = "chart1";
            series4.ChartArea = "bnf";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "benific";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(329, 305);
            this.chart1.TabIndex = 109;
            this.chart1.Text = "chart1";
            // 
            // listP
            // 
            this.listP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.listP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listP.ForeColor = System.Drawing.Color.White;
            this.listP.Location = new System.Drawing.Point(290, 111);
            this.listP.Name = "listP";
            this.listP.Size = new System.Drawing.Size(156, 33);
            this.listP.TabIndex = 114;
            this.listP.Text = "Liste du paiement";
            this.listP.UseVisualStyleBackColor = false;
            this.listP.Click += new System.EventHandler(this.listP_Click);
            // 
            // btnMsj
            // 
            this.btnMsj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.btnMsj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMsj.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsj.ForeColor = System.Drawing.Color.White;
            this.btnMsj.Location = new System.Drawing.Point(29, 250);
            this.btnMsj.Name = "btnMsj";
            this.btnMsj.Size = new System.Drawing.Size(229, 39);
            this.btnMsj.TabIndex = 117;
            this.btnMsj.Text = "Modifier mot de passe";
            this.btnMsj.UseVisualStyleBackColor = false;
            this.btnMsj.Click += new System.EventHandler(this.btnMsj_Click_1);
            // 
            // gridd
            // 
            this.gridd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridd.Location = new System.Drawing.Point(290, 209);
            this.gridd.Name = "gridd";
            this.gridd.Size = new System.Drawing.Size(327, 272);
            this.gridd.TabIndex = 119;
            // 
            // combo_adh
            // 
            this.combo_adh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_adh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_adh.FormattingEnabled = true;
            this.combo_adh.Location = new System.Drawing.Point(290, 164);
            this.combo_adh.Name = "combo_adh";
            this.combo_adh.Size = new System.Drawing.Size(182, 23);
            this.combo_adh.TabIndex = 121;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(481, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 29);
            this.button2.TabIndex = 122;
            this.button2.Text = "Rechercher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(28, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 44);
            this.button3.TabIndex = 123;
            this.button3.Text = "Ajouter catégorie";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::salleSport.Properties.Resources.upload;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(28, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 44);
            this.button1.TabIndex = 120;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(28, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 44);
            this.button4.TabIndex = 124;
            this.button4.Text = "Nom de salle de sport";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtlogin.Location = new System.Drawing.Point(290, 78);
            this.txtlogin.MaxLength = 25;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(315, 22);
            this.txtlogin.TabIndex = 125;
            this.txtlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtlogin.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(365, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 126;
            this.label2.Text = "Entrer le nom de cabinet";
            this.label2.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(452, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 33);
            this.button5.TabIndex = 127;
            this.button5.Text = "Liste de credit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.BackColor = System.Drawing.Color.White;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.ForeColor = System.Drawing.Color.Red;
            this.lblCredit.Location = new System.Drawing.Point(681, 204);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(168, 18);
            this.lblCredit.TabIndex = 128;
            this.lblCredit.Text = "Entrer le nom de cabinet";
            // 
            // configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::salleSport.Properties.Resources._4;
            this.ClientSize = new System.Drawing.Size(972, 508);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.combo_adh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridd);
            this.Controls.Add(this.btnMsj);
            this.Controls.Add(this.listP);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueYear);
            this.Controls.Add(this.btnBenifice);
            this.Controls.Add(this.bar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user gestion";
            this.Load += new System.EventHandler(this.configuration_Load);
            this.bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retuurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.PictureBox retuurn;
        private System.Windows.Forms.PictureBox minimaze;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button btnBenifice;
        private System.Windows.Forms.NumericUpDown valueYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button listP;
        private System.Windows.Forms.Button btnMsj;
        private System.Windows.Forms.DataGridView gridd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_adh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblCredit;
    }
}