using salleSport.Properties;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace salleSport
{
    public partial class payement : Form
    {
        bool valid = true;

        public payement(bool v)
        {
            valid = v;
            InitializeComponent();
        }
        public payement()
        {
            InitializeComponent();
        }
        gestionSalleSprortEntities db = new gestionSalleSprortEntities();


        public void nbrAd()
        {
            lbl1.Text = db.Adherent.Where(x => x.active == true).Select(x => x).Count().ToString();
            lbl2.Text = db.Adherent.Where(x => x.reste == 0 || x.reste == null).Select(x => x).Count().ToString();
            lbl3.Text = db.Adherent.Where(x => x.reste != 0 && x.reste != null).Select(x => x).Count().ToString();
            //lbl_F.Text = db.Adherent.Where(x => x.sexe == "fiminin" && x.active == true).Select(x => x).Count().ToString();
            //lbl_M.Text = db.Adherent.Where(x => x.sexe == "masculin" && x.active == true).Select(x => x).Count().ToString();
        }

        public void verifierdate()
        {
            DateTime d;
            var a = db.Adherent.Where(x => x.active == true).Select(x => x).ToList();

            foreach (var i in a)
            {

                d = DateTime.Parse(i.dateNextPayement.ToString());
                if (DateTime.Parse(DateTime.Now.ToShortDateString()) >= DateTime.Parse(d.Date.ToShortDateString()))
                {
                    i.etatPyement = false;

                }

                db.SaveChanges();
            }
        }



        public bool paye()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("select matricule");
                comboBox1.SelectAll();
                return false;
            }
            else
            {




                string[] a = new string[2];
                a = comboBox1.Text.Split('-');
                int id = int.Parse(comboBox1.SelectedValue.ToString());
                Adherent ad = db.Adherent.Find(id);



                if (ad.etatPyement == true)
                {
                    DateTime dDeja = (DateTime)ad.datePayement;
                    MessageBox.Show(a[0] + " " + a[1] + " est dejat payé le mois " + dDeja.Month);
                    return false;
                }


                if (ad.dejatDesactiver == true)
                {
                    DateTime dN = DateTime.Today;
                    ad.datePayement = DateTime.Parse(dN.Date.ToShortDateString());

                    // calcule nbrMonth
                    for (int j = 0; j < int.Parse(txtNbrmois.Text); j++)
                    {
                        dN = dN.AddDays(DateTime.DaysInMonth(dN.Year, dN.Month));
                    }
                    ad.dateNextPayement = DateTime.Parse(dN.Date.ToShortDateString());
                    ad.dejatDesactiver = false;
                }
                else
                {
                    DateTime dN = (DateTime)ad.dateNextPayement;
                    ad.datePayement = DateTime.Parse(dN.Date.ToShortDateString());
                    // calcule nbrMonth
                    for (int j = 0; j < int.Parse(txtNbrmois.Text); j++)
                    {
                        dN = dN.AddDays(DateTime.DaysInMonth(dN.Year, dN.Month));
                    }
                    ad.dateNextPayement = DateTime.Parse(dN.Date.ToShortDateString());

                }








                MessageBox.Show(a[0] + " " + a[1] + " paye avec sucsee");
                ad.etatPyement = true;


                db.SaveChanges();
                return true;
            }




        }




        //*********************************

        private void Form1_Load(object sender, EventArgs e)
        {
            t_function df = db.t_function.Where(x => x.id == 3).FirstOrDefault();
            txtSommeP.Text = df.column1;
            txtNbrmois.Text = df.column2;



            var req2 = db.Adherent.Select(x => new { matricule = x.nomAdh + "-" + x.prenomAdh, id = x.idAdh });
            comboBox1.DataSource = req2.ToList();
            comboBox1.DisplayMember = "matricule";
            comboBox1.ValueMember = "id";

            verifierdate();
            nbrAd();

            flowLayoutPanel1.Controls.Clear();
            var a = db.Adherent.Where(x => x.active == true).Select(x => x).ToList();

            foreach (var i in a)
            {


                MemoryStream ms = new MemoryStream(i.pic);
                Image returnImage = Image.FromStream(ms);

                PictureBox d = new PictureBox();


                d.BackgroundImageLayout = ImageLayout.Stretch;
                d.BackgroundImage = returnImage;
                d.Name = i.idAdh.ToString();

                d.BorderStyle = BorderStyle.FixedSingle;
                d.Size = new Size(140, 140);
                d.Margin = new Padding(4);

                flowLayoutPanel1.AutoScroll = true;

                d.Cursor = Cursors.Hand;
                d.Click += delegate
                {
                    panelRetard.Visible = false; panelRetard2.Visible = false; panelRetard.Visible = false; panelRetard2.Visible = false;
                    int idd = int.Parse(i.idAdh.ToString());
                    Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                    if (p != null)
                    {
                        txtNbrmois.Text = p.reste.ToString();
                        MemoryStream m = new MemoryStream(p.pic);
                        Image Image = Image.FromStream(m);
                        picture.Image = returnImage;

                        if (p.etatPyement == true)
                        {
                            bar1.BackColor = Color.Lime;
                        }
                        else bar1.BackColor = Color.Red;

                        TimeSpan ts = DateTime.Today.Date - (DateTime)p.dateNextPayement;

                        if (p.active == true)
                        {
                            if (p.etatPyement == false)
                            {
                                panelRetard2.Visible = false;
                                panelRetard.Visible = true;
                                bar1.BackColor = Color.Red;
                                jj.Text = ts.TotalDays.ToString();
                                lbltel.Text = p.telephone;
                            }

                        }
                        else
                        {
                            panelRetard.Visible = false;

                            if ((bool)p.etatPyement)
                            {
                                bar1.BackColor = Color.Lime;
                            }
                            else
                            {
                                bar1.BackColor = Color.Red;
                                if (ts.TotalDays > 0)
                                {
                                    panelRetard2.Visible = true;
                                    jj2.Text = ts.TotalDays.ToString(); lbltel.Text = p.telephone;
                                }
                            }


                        }

                    }

                    comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();


                };
                flowLayoutPanel1.Controls.Add(d);
                txtNbrmois.Text = "";
            }
        }

        private void payement_Activated(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            var a = db.Adherent.Where(x => x.active == true).Select(x => x).ToList();

            foreach (var i in a)
            {


                MemoryStream ms = new MemoryStream(i.pic);
                Image returnImage = Image.FromStream(ms);

                PictureBox d = new PictureBox();


                d.BackgroundImageLayout = ImageLayout.Stretch;
                d.BackgroundImage = returnImage;
                d.Name = i.idAdh.ToString();

                d.BorderStyle = BorderStyle.FixedSingle;
                d.Size = new Size(140, 140);
                d.Margin = new Padding(4);

                flowLayoutPanel1.AutoScroll = true;

                d.Cursor = Cursors.Hand;
                d.Click += delegate
                {
                    panelRetard.Visible = false; panelRetard2.Visible = false; panelRetard.Visible = false; panelRetard2.Visible = false;
                    int idd = int.Parse(i.idAdh.ToString());
                    Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                    if (p != null)
                    {
                        txtNbrmois.Text = p.reste.ToString();
                        MemoryStream m = new MemoryStream(p.pic);
                        Image Image = Image.FromStream(m);
                        picture.Image = returnImage;

                        if (p.etatPyement == true)
                        {
                            bar1.BackColor = Color.Lime;
                        }
                        else bar1.BackColor = Color.Red;

                        TimeSpan ts = DateTime.Today.Date - (DateTime)p.dateNextPayement;

                        if (p.active == true)
                        {
                            if (p.etatPyement == false)
                            {
                                panelRetard2.Visible = false;
                                panelRetard.Visible = true;
                                bar1.BackColor = Color.Red;
                                jj.Text = ts.TotalDays.ToString();
                                lbltel.Text = p.telephone;
                            }

                        }
                        else
                        {
                            panelRetard.Visible = false;

                            if ((bool)p.etatPyement)
                            {
                                bar1.BackColor = Color.Lime;
                            }
                            else
                            {
                                bar1.BackColor = Color.Red;
                                if (ts.TotalDays > 0)
                                {
                                    panelRetard2.Visible = true;
                                    jj2.Text = ts.TotalDays.ToString(); lbltel.Text = p.telephone;
                                }
                            }


                        }

                    }

                    comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();


                };
                flowLayoutPanel1.Controls.Add(d);
            }
        }

        public void list()
        {
            flowLayoutPanel1.Controls.Clear();
            var a = db.Adherent.Where(x => x.active == true).Select(x => x).ToList();

            foreach (var i in a)
            {

                MemoryStream ms = new MemoryStream(i.pic);
                Image returnImage = Image.FromStream(ms);

                PictureBox d = new PictureBox();


                d.BackgroundImageLayout = ImageLayout.Stretch;
                d.BorderStyle = BorderStyle.FixedSingle;
                d.BackgroundImage = returnImage;
                d.Name = i.idAdh.ToString();



                d.Size = new Size(140, 140);
                d.Margin = new Padding(4);


                flowLayoutPanel1.AutoScroll = true;

                // d.Size.Width.;
                d.Cursor = Cursors.Hand;
                d.Click += delegate
                {
                    panelRetard.Visible = false; panelRetard2.Visible = false;
                    int idd = int.Parse(i.idAdh.ToString());
                    Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                    if (p != null)
                    {
                        txtNbrmois.Text = p.reste.ToString();
                        MemoryStream m = new MemoryStream(p.pic);
                        Image Image = Image.FromStream(m);
                        picture.Image = returnImage;

                        TimeSpan ts = DateTime.Today.Date - (DateTime)p.dateNextPayement;

                        if (p.active == true)
                        {
                            if (p.etatPyement == false)
                            {
                                panelRetard2.Visible = false;
                                panelRetard.Visible = true;
                                bar1.BackColor = Color.Red;
                                jj.Text = ts.TotalDays.ToString();
                                lbltell.Text = p.telephone;
                                txtNbrmois.Text = p.reste.ToString();
                            }
                            else
                            {
                                bar1.BackColor = Color.Lime;
                            }

                        }
                        else
                        {
                            panelRetard.Visible = false;

                            if ((bool)p.etatPyement)
                            {
                                bar1.BackColor = Color.Lime;
                            }
                            else
                            {
                                bar1.BackColor = Color.Red;
                                if (ts.TotalDays > 0)
                                {
                                    panelRetard2.Visible = true;
                                    jj2.Text = ts.TotalDays.ToString();
                                    lbltel.Text = p.telephone;
                                }
                            }


                        }
                    }

                    //----------------------------------------------------//




                    //--

                    comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();
                };
                flowLayoutPanel1.Controls.Add(d);
                panel2.BackColor = Color.Black;
            }
            nbrAd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelRetard.Visible = false;
            list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelRetard.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            var a = db.Adherent.Where(x => x.reste == 0 || x.reste == null).Select(x => x).ToList();

            foreach (var i in a)
            {

                MemoryStream ms = new MemoryStream(i.pic);
                Image returnImage = Image.FromStream(ms);

                PictureBox d = new PictureBox();


                d.BorderStyle = BorderStyle.FixedSingle;
                d.BackgroundImageLayout = ImageLayout.Stretch;
                d.BackgroundImage = returnImage;
                d.Name = i.idAdh.ToString();

                d.Size = new Size(140, 140);
                d.Margin = new Padding(4);


                flowLayoutPanel1.AutoScroll = true;

                // d.Size.Width.;
                d.Cursor = Cursors.Hand;
                d.Click += delegate
                {
                    panelRetard.Visible = false; panelRetard2.Visible = false;
                    int idd = int.Parse(i.idAdh.ToString());
                    Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                    if (p != null)
                    {
                        MemoryStream m = new MemoryStream(p.pic);
                        Image Image = Image.FromStream(m);
                        picture.Image = returnImage;

                        if (p.etatPyement == true)
                        {
                            bar1.BackColor = Color.Lime;
                        }
                        else bar1.BackColor = Color.Red;



                    }
                    comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();
                };
                flowLayoutPanel1.Controls.Add(d);
                panel2.BackColor = Color.Green;
            }
            nbrAd();
        }

        public void adhNopaye()
        {
            flowLayoutPanel1.Controls.Clear();
            var a = db.Adherent.Where(x => x.reste != 0 && x.reste != null).Select(x => x).ToList();

            foreach (var i in a)
            {

                MemoryStream ms = new MemoryStream(i.pic);
                Image returnImage = Image.FromStream(ms);

                PictureBox d = new PictureBox();


                d.BackgroundImageLayout = ImageLayout.Stretch;
                d.BackgroundImage = returnImage;
                d.Name = i.idAdh.ToString();
                d.Size = new Size(140, 140);
                d.Margin = new Padding(4);
                d.BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanel1.AutoScroll = true;


                d.Cursor = Cursors.Hand;
                d.Click += delegate
                {
                    panelRetard.Visible = false; panelRetard2.Visible = false;
                    int idd = int.Parse(i.idAdh.ToString());
                    Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                    if (p != null)
                    {
                        txtNbrmois.Text = p.reste.ToString();
                        MemoryStream m = new MemoryStream(p.pic);
                        Image Image = Image.FromStream(m);
                        picture.Image = Image;

                        if (p.etatPyement == true)
                        {
                            bar1.BackColor = Color.Lime;
                        }
                        else bar1.BackColor = Color.Red;

                    }
                    comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();

                    TimeSpan ts = DateTime.Today.Date - (DateTime)p.dateNextPayement;

                    if (p.active == true)
                    {
                        if (p.etatPyement == false)
                        {
                            panelRetard2.Visible = false;
                            panelRetard.Visible = true;
                            bar1.BackColor = Color.Red;
                            jj.Text = ts.TotalDays.ToString();
                            lbltel.Text = p.telephone;
                            txtNbrmois.Text = p.reste.ToString();
                        }

                    }
                    else
                    {
                        panelRetard.Visible = false;

                        if ((bool)p.etatPyement)
                        {
                            bar1.BackColor = Color.Lime;
                        }
                        else
                        {
                            bar1.BackColor = Color.Red;
                            if (ts.TotalDays > 0)
                            {
                                panelRetard2.Visible = true;
                                jj2.Text = ts.TotalDays.ToString(); lbltell.Text = p.telephone;
                            }
                        }


                    }
                };
                flowLayoutPanel1.Controls.Add(d);

            }
            panel2.BackColor = Color.Red;
            nbrAd();
        }


        public bool verifierD()
        {
            id = int.Parse(comboBox1.SelectedValue.ToString());
            Adherent p = db.Adherent.Find(id);
            if (p != null)
            {
                return (bool)p.active;
            }
            return true;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            panelRetard.Visible = false;
            adhNopaye();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                return;
            }
            if (valid == true)
            {
                btnValider.Cursor = Cursors.Hand;
                string[] a = new string[2];
                a = comboBox1.Text.Split('-');
                id = int.Parse(comboBox1.SelectedValue.ToString());
                if (verifierD() == false)
                {
                    MessageBox.Show(a[0] + " " + a[1] + " est desactiver");
                    return;
                }
                if (MessageBox.Show("valider payement ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (txtNbrmois.Text == "nombre mois payé" || txtSommeP.Text == "somme payé (dh)")
                    {
                        MessageBox.Show("completer la saisi des donneés");
                        return;
                    }
                    //if (paye() == true)
                    //{
                    Adherent p = db.Adherent.Where(x => x.idAdh == (int)comboBox1.SelectedValue).FirstOrDefault();
                    benifice b = new benifice();
                    b.matriculeAdh = comboBox1.Text;
                    b.datepayement = DateTime.Parse(DateTime.Now.ToShortDateString());
                    b.somme = float.Parse(txtSommeP.Text);
                    db.benifice.Add(b);
                    p.reste = (int)((float)p.reste - float.Parse(txtSommeP.Text));

                    db.Adherent.AddOrUpdate(p);
                    db.SaveChanges();
                    bar1.BackColor = Color.Lime;
                    adhNopaye();
                    panelRetard.Visible = false;
                    MessageBox.Show("Paiment Success");
                    txtSommeP.Text = "";
                    txtNbrmois.Text = p.reste.ToString();
                    //}
                }
            }
            else
            {
                btnValider.Cursor = Cursors.No;
                MessageBox.Show("user ne pas autoriser a valider payement");
            }
            nbrAd();
        }






        private void btnValider_MouseHover(object sender, EventArgs e)
        {
            if (valid == true)
            {

                btnValider.Cursor = Cursors.Hand;


            }
            else
            {

                btnValider.Cursor = Cursors.No;

            }

        }

        int id;
        private void button2_Click(object sender, EventArgs e)
        {

            if (button2.Text == "rechercher")
            {
                if (comboBox1.Text == "" && comboBox1.Items.Count == 0)
                {
                    MessageBox.Show("il n'a pas encore des adhérents pour la rechercher");

                    return;
                }


                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("select matricule");
                    comboBox1.Text = "";
                    comboBox1.SelectedIndex = 0;
                    return;
                }
                else
                {
                    id = int.Parse(comboBox1.SelectedValue.ToString());

                    flowLayoutPanel1.Controls.Clear();
                    Adherent ad = db.Adherent.Find(id);

                    if (ad != null)
                    {

                        MemoryStream ms = new MemoryStream(ad.pic);
                        Image returnImage = Image.FromStream(ms);

                        PictureBox d = new PictureBox();


                        d.BackgroundImageLayout = ImageLayout.Stretch;
                        d.BackgroundImage = returnImage;
                        d.Name = ad.idAdh.ToString();
                        d.Size = new Size(140, 140);
                        d.Margin = new Padding(4);
                        d.BorderStyle = BorderStyle.FixedSingle;

                        flowLayoutPanel1.AutoScroll = true;

                        // d.Size.Width.;
                        d.Cursor = Cursors.Hand;
                        d.Click += delegate
                        {
                            panelRetard.Visible = false; panelRetard2.Visible = false;
                            int idd = int.Parse(ad.idAdh.ToString());
                            Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                            if (p != null)
                            {
                                txtNbrmois.Text = p.reste.ToString();
                                MemoryStream m = new MemoryStream(p.pic);
                                Image Image = Image.FromStream(m);
                                picture.Image = Image;
                                TimeSpan ts = DateTime.Today.Date - (DateTime)p.dateNextPayement;

                                if (p.active == true)
                                {
                                    if (p.etatPyement == false)
                                    {
                                        panelRetard2.Visible = false;
                                        panelRetard.Visible = true;
                                        bar1.BackColor = Color.Red;
                                        jj.Text = ts.TotalDays.ToString();
                                        lbltel.Text = p.telephone;
                                        txtNbrmois.Text = p.reste.ToString();
                                    }

                                }
                                else
                                {
                                    panelRetard.Visible = false;

                                    if ((bool)p.etatPyement)
                                    {
                                        bar1.BackColor = Color.Lime;
                                    }
                                    else
                                    {
                                        bar1.BackColor = Color.Red;
                                        if (ts.TotalDays > 0)
                                        {
                                            panelRetard2.Visible = true;
                                            jj2.Text = ts.TotalDays.ToString(); lbltell.Text = p.telephone;
                                        }
                                    }


                                }

                            }
                            comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();
                        };
                        flowLayoutPanel1.Controls.Add(d);
                        panel2.BackColor = Color.Black;
                    }




                }


                button2.Text = "all list";


                //------------
            }
            else
            {
                panelRetard2.Visible = false;
                panelRetard.Visible = false;
                button2.Text = "rechercher";
                list();

                bar1.BackColor = Color.Black;
                picture.ImageLocation = Resources.round_account_button_with_user_inside.ToString();
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void retuurn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }

        private bool mouseDown = false;
        private Point lastLocation;

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            this.Cursor = Cursors.Hand;
        }

        private void bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Cursor = Cursors.Default;
        }

        private void bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = (this.Location.X - lastLocation.X) + e.X;
                int y = (this.Location.Y - lastLocation.Y) + e.Y;
                this.Location = new Point(x, y);
            }
        }

        //btnDesaciver
        private void button5_Click(object sender, EventArgs e)
        {
            string[] a = new string[2];
            a = comboBox1.Text.Split('-');
            if (MessageBox.Show("vous avez desactiver " + a[0] + " " + a[1] + "   ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int idA = int.Parse(comboBox1.SelectedValue.ToString());

                Adherent d = db.Adherent.Find(idA);
                if (d != null)
                {
                    d.active = false;
                }

                db.SaveChanges();
                MessageBox.Show("les information est bien modifier !");
                t_function df = db.t_function.Where(x => x.id == 3).FirstOrDefault();
                txtSommeP.Text = df.column1;
                txtNbrmois.Text = df.column2;


                var req2 = db.Adherent.Select(x => new { matricule = x.nomAdh + "-" + x.prenomAdh, id = x.idAdh });
                comboBox1.DataSource = req2.ToList();
                comboBox1.DisplayMember = "matricule";
                comboBox1.ValueMember = "id";

                verifierdate();
                nbrAd();

                flowLayoutPanel1.Controls.Clear();
                var r = db.Adherent.Where(x => x.active == true).Select(x => x).ToList();

                foreach (var i in r)
                {


                    MemoryStream ms = new MemoryStream(i.pic);
                    Image returnImage = Image.FromStream(ms);

                    PictureBox b = new PictureBox();


                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.BackgroundImage = returnImage;
                    b.Name = i.idAdh.ToString();

                    b.BorderStyle = BorderStyle.FixedSingle;
                    b.Size = new Size(200, 200);
                    b.Margin = new Padding(6);

                    flowLayoutPanel1.AutoScroll = true;

                    // d.Size.Width.;
                    b.Cursor = Cursors.Hand;
                    b.Click += delegate
                    {
                        int idd = int.Parse(i.idAdh.ToString());
                        Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                        if (p != null)
                        {
                            txtNbrmois.Text = p.reste.ToString();
                            MemoryStream m = new MemoryStream(p.pic);
                            Image Image = Image.FromStream(m);
                            picture.Image = Image;

                            if (p.etatPyement == true)
                            {
                                bar1.BackColor = Color.Lime;
                            }
                            else bar1.BackColor = Color.Red;

                        }

                        comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();


                    };
                    flowLayoutPanel1.Controls.Add(b);
                    picture.ImageLocation = Resources.round_account_button_with_user_inside.ToString();
                }
            }
            panelRetard.Visible = false;
            panelRetard2.Visible = false;
        }



        //btnAciver
        private void button6_Click(object sender, EventArgs e)
        {
            string[] a = new string[2];
            a = comboBox1.Text.Split('-');
            if (MessageBox.Show("vous avez  activer " + a[0] + " " + a[1] + "   ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int idA = int.Parse(comboBox1.SelectedValue.ToString());

                Adherent d = db.Adherent.Find(idA);
                if (d != null)
                {
                    d.active = true;
                    //--
                    d.dejatDesactiver = true;
                }

                db.SaveChanges();
                MessageBox.Show("les information est bien modifier !");
                t_function df = db.t_function.Where(x => x.id == 3).FirstOrDefault();
                txtSommeP.Text = df.column1;
                txtNbrmois.Text = df.column2;



                var req2 = db.Adherent.Select(x => new { matricule = x.nomAdh + "-" + x.prenomAdh, id = x.idAdh });
                comboBox1.DataSource = req2.ToList();
                comboBox1.DisplayMember = "matricule";
                comboBox1.ValueMember = "id";

                verifierdate();
                nbrAd();

                flowLayoutPanel1.Controls.Clear();
                var r = db.Adherent.Where(x => x.active == true).Select(x => x).ToList();

                foreach (var i in r)
                {


                    MemoryStream ms = new MemoryStream(i.pic);
                    Image returnImage = Image.FromStream(ms);

                    PictureBox b = new PictureBox();


                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.BackgroundImage = returnImage;
                    b.Name = i.idAdh.ToString();

                    b.BorderStyle = BorderStyle.FixedSingle;
                    b.Size = new Size(200, 200);
                    b.Margin = new Padding(6);

                    flowLayoutPanel1.AutoScroll = true;

                    // d.Size.Width.;
                    b.Cursor = Cursors.Hand;
                    b.Click += delegate
                    {
                        int idd = int.Parse(i.idAdh.ToString());
                        Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                        if (p != null)
                        {
                            txtNbrmois.Text = p.reste.ToString();
                            MemoryStream m = new MemoryStream(p.pic);
                            Image Image = Image.FromStream(m);
                            picture.Image = returnImage;

                            if (p.etatPyement == true)
                            {
                                bar1.BackColor = Color.Lime;
                            }
                            else bar1.BackColor = Color.Red;

                        }

                        comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();


                    };
                    flowLayoutPanel1.Controls.Add(b);
                    picture.ImageLocation = Resources.round_account_button_with_user_inside.ToString();
                }

            }
            panelRetard.Visible = false;
            panelRetard2.Visible = false;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNbrmois_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panelRetard2_Paint(object sender, PaintEventArgs e)
        {

        }
        placeholder p = new placeholder();
        private void txtNbrmois_Enter(object sender, EventArgs e)
        {
            p.enter(txtNbrmois, "Reste", "white", "black");
            label3.Text = "Reste";
        }

        private void txtNbrmois_Leave(object sender, EventArgs e)
        {
            if (txtNbrmois.Text == "")
            {
                label3.Text = "";
            }

            p.leave(txtNbrmois, "Reste", "black", "white");
        }

        private void txtSommeP_Leave(object sender, EventArgs e)
        {
            if (txtSommeP.Text == "")
            {
                label2.Text = "";
            }


            p.leave(txtSommeP, "somme payé (dh)", "black", "white");
            if (txtSommeP.Text.Contains(".")) { txtSommeP.Text = txtSommeP.Text.Replace('.', ','); }
        }


        private void txtSommeP_Enter(object sender, EventArgs e)
        {
            p.enter(txtSommeP, "somme payé (dh)", "white", "black");
            label2.Text = "somme payé (dh)";
        }

        private void txtSommeP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (txtSommeP.Text.Contains(".") == false && txtSommeP.Text.Contains(",") == false && txtSommeP.Text != "")
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = char.IsControl(e.KeyChar);
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = char.IsControl(e.KeyChar);
                }
            }

        }
        private void txtNbrmois_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}

