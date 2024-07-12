using salleSport.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace salleSport
{
    public partial class updatList : Form
    {
        string MS = "MS";
        public updatList(string i)
        {

            InitializeComponent();
            MS = i;
        }
        public updatList()
        {
            InitializeComponent();
        }

        private void updatList_Load(object sender, EventArgs e)
        {

            all();


            var req1 = db.categorie.Select(x => new { nom = x.sportCateg });
            comboBox2.DataSource = req1.ToList();
            comboBox2.DisplayMember = "nom";


            var req2 = db.Adherent.Select(x => new { matricule = x.nomAdh + "-" + x.prenomAdh, id = x.idAdh });
            comboBox1.DataSource = req2.ToList();
            comboBox1.DisplayMember = "matricule";
            comboBox1.ValueMember = "id";
        }



        gestionSalleSprortEntities db = new gestionSalleSprortEntities();
        private bool mouseDown = false;
        private Point lastLocation;



        private void bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Cursor = Cursors.Default;
        }

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            this.Cursor = Cursors.Hand;
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
        //**********
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void returne_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }

        public void all()
        {
            flowLayoutPanel1.Controls.Clear();
            var a = db.Adherent.Select(x => x).ToList();

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

                    panel1.Visible = false;
                    int idd = int.Parse(i.idAdh.ToString());
                    Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                    if (p != null)
                    {
                        MemoryStream m = new MemoryStream(p.pic);
                        Image Image = Image.FromStream(m);
                        picture.Image = Image;



                    }

                    comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();
                    //**
                    txtNom.Text = p.nomAdh;
                    txtPren.Text = p.prenomAdh;
                    txtaddress.Text = p.adress;
                    txtTel.Text = p.telephone;
                    txtRemarque.Text = p.remarque;
                    txtNbrmois.Text = p.reste.ToString();
                    DateInscription.Value = p.dateInscription.Value;
                    DatePayement.Value = p.datePayement.Value;
                    DateNextPayement.Value = p.dateNextPayement.Value;
                    chActive.Value = (bool)p.active;
                    if (p.sexe == "masculin")
                    {

                        rdM.Checked = true;

                    }
                    else rdF.Checked = true;




                    if (p.sportCatg == null)
                    {
                        checkCategorie.Value = false;
                        comboBox2.Visible = false;
                    }
                    else
                    {
                        checkCategorie.Value = true;
                        comboBox2.Visible = true;
                        comboBox2.Text = p.sportCatg;
                    }



                };
                flowLayoutPanel1.Controls.Add(d);
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtTel.Text = " ";
            txtaddress.Text = " ";
            txtPren.Text = " ";
            txtNom.Text = " ";

            if (btnd.Text == "Personnes  desactiver")
            {
                flowLayoutPanel1.Controls.Clear();
                var a = db.Adherent.Where(x => x.active == false).Select(x => x).ToList();

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

                        panel1.Visible = false;
                        int idd = int.Parse(i.idAdh.ToString());
                        Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                        if (p != null)
                        {
                            MemoryStream m = new MemoryStream(p.pic);
                            Image Image = Image.FromStream(m);
                            picture.Image = Image;



                        }

                        comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();
                        //**
                        txtNom.Text = p.nomAdh;
                        txtPren.Text = p.prenomAdh;
                        txtaddress.Text = p.adress;
                        txtTel.Text = p.telephone;
                        DateInscription.Value = p.dateInscription.Value;
                        DatePayement.Value = p.datePayement.Value;
                        DateNextPayement.Value = p.dateNextPayement.Value;
                        chActive.Value = (bool)p.active;
                        if (p.sexe == "masculin")
                        {
                            rdM.Checked = true;
                        }
                        else rdF.Checked = true;

                        if (p.sportCatg == null)
                        {
                            checkCategorie.Value = false;
                            comboBox2.Visible = false;
                        }
                        else
                        {
                            checkCategorie.Value = true;
                            comboBox2.Visible = true;
                            comboBox2.Text = p.sportCatg;
                        }

                    };
                    flowLayoutPanel1.Controls.Add(d);

                }

                //****


                btnd.Text = "all Personnes";


                //------------
            }
            else
            {
                btnd.Text = "Personnes  desactiver";
                all();









            }


            //**********





        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTel.Text = " ";
            txtaddress.Text = " ";
            txtPren.Text = " ";
            txtNom.Text = " ";
            txtRemarque.Text = "";
            picture.ImageLocation = Resources.round_account_button_with_user_inside.ToString();
            if (button2.Text == "rechercher")
            {
                if (comboBox1.SelectedIndex == -1 || comboBox1.Text == "")
                {
                    MessageBox.Show("select Nom de adherent");
                    comboBox1.Text = "";
                    if (comboBox1.Text != "")
                    {
                        comboBox1.SelectedIndex = 0;
                    }

                    return;

                }
                else
                {

                  int id=int.Parse(comboBox1.SelectedValue.ToString());

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

                        ///////////////////////// d.Size.Width.;
                        d.Cursor = Cursors.Hand;
                        d.Click += delegate
                        {
                            panel1.Visible = false;
                            int idd = int.Parse(ad.idAdh.ToString());
                            Adherent p = db.Adherent.Where(x => x.idAdh == idd).FirstOrDefault();
                            if (p != null)
                            {
                                MemoryStream m = new MemoryStream(p.pic);
                                Image Image = Image.FromStream(m);
                                picture.Image = Image;

                                //**
                                txtNom.Text = p.nomAdh;
                                txtPren.Text = p.prenomAdh;
                                txtaddress.Text = p.adress;
                                txtTel.Text = p.telephone;
                                txtRemarque.Text = p.remarque;
                                DateInscription.Value = p.dateInscription.Value;
                                DatePayement.Value = p.datePayement.Value;
                                DateNextPayement.Value = p.dateNextPayement.Value;
                                chActive.Value = (bool)p.active;
                                if (p.sexe == "masculin")
                                {

                                    rdM.Checked = true;

                                }
                                else rdF.Checked = true;


                                if (p.sportCatg == null)
                                {
                                    checkCategorie.Value = false;
                                    comboBox2.Visible = false;
                                }
                                else
                                {
                                    checkCategorie.Value = true;
                                    comboBox2.Visible = true;
                                    comboBox2.Text = p.sportCatg;
                                }

                            }
                            comboBox1.Text = p.nomAdh.ToString() + "-" + p.prenomAdh.ToString();
                        };
                        flowLayoutPanel1.Controls.Add(d);

                    }


                    panel1.Visible = true;

                }


                button2.Text = "all list";


                //------------
            }
            else
            {

                button2.Text = "rechercher";
                all();

            }
        }
        string path = "";
        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                return;
            }


            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                path = o.FileName.ToString();
                picture.ImageLocation = path;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtTel.Text == ""
                  || txtaddress.Text == ""
                  || txtPren.Text == ""
                  || txtNom.Text == ""


                  )
            {
                MessageBox.Show("veillez entrer tout les donnees"); return;
            }


            if (MS.Contains('M'))
            {

                btnModifier.Cursor = Cursors.Hand;








                if (MessageBox.Show("vous avez sur de maudifier ce adhérent", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("select matricule");
                        comboBox1.Text = "";

                        comboBox1.SelectedIndex = 0;
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("vous avez verifier date payement et date next payement !!?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (DateInscription.Value <= DatePayement.Value && DatePayement.Value < DateNextPayement.Value)
                            {




                              int idA=  int.Parse(comboBox1.SelectedValue.ToString());

                                Adherent d = db.Adherent.Find(idA);
                                if (d != null)
                                {
                                    d.nomAdh = txtNom.Text;
                                    d.prenomAdh = txtPren.Text;
                                    d.adress = txtaddress.Text;
                                    d.reste = int.Parse(txtNbrmois.Text);
                                    d.dateInscription = DateInscription.Value;
                                    d.datePayement = DatePayement.Value;
                                    d.dateNextPayement = DateNextPayement.Value;

                                    d.active = chActive.Value;
                                    d.sexe = (rdM.Checked) ? "masculin" : "fiminin";


                                    if (checkCategorie.Value)
                                    {
                                        if (comboBox2.Text == "")
                                        {
                                            MessageBox.Show("choisir une categorie de sport");
                                            return;

                                        }
                                        else
                                        {

                                            d.sportCatg = comboBox2.Text;
                                        }

                                    }
                                    if (path != "")
                                    {
                                        byte[] p = null;
                                        FileStream s = new FileStream(path, FileMode.Open, FileAccess.Read);
                                        BinaryReader brs = new BinaryReader(s);
                                        p = brs.ReadBytes((int)s.Length);
                                        d.pic = p;
                                    }

                                }

                                db.SaveChanges();
                                MessageBox.Show("les information est bien modifier !");


                                txtTel.Text = "";
                                txtaddress.Text = "";
                                txtPren.Text = "";
                                txtNom.Text = "";
                                txtNbrmois.Text = "";
                                picture.ImageLocation = Resources.round_account_button_with_user_inside.ToString();
                                all();



                                var req2 = db.Adherent.Select(x => new { matricule = x.nomAdh + "-" + x.prenomAdh,id=x.idAdh });
                                comboBox1.DataSource = req2.ToList();
                                comboBox1.DisplayMember = "matricule";
                                comboBox1.ValueMember = "id";
                                /*---------------------*/
                                panel1.Visible = true;

                            }
                            else
                            {
                                MessageBox.Show("verifier que la date de inscription doit etre inferieur ou bien egat la date de payment et la date de la prochain payment doit etre superieur a la date de payment !!!!");
                                return;
                            }

                        }
                        else
                        {

                            return;


                        }

                    }
                }

                else
                {
                    return;

                }

            }
            else
            {

                btnModifier.Cursor = Cursors.No;
                MessageBox.Show(" utilisateur n'est pas   sautoriser a modifier");
            }




        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (MS.Contains('S'))
            {

                btnSupp.Cursor = Cursors.Hand;




                if (MessageBox.Show("vous avez sur de supprimer ce adhérent", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                 int idA= int.Parse(comboBox1.SelectedValue.ToString());

                    Adherent d = db.Adherent.Find(idA);


                    if (d != null)
                    {
                        db.Adherent.Remove(d);
                    }
                    db.SaveChanges();


                    all();


                    var req2 = db.Adherent.Select(x => new { matricule =  x.nomAdh + "-" + x.prenomAdh,id=x.idAdh });
                    comboBox1.DataSource = req2.ToList();
                    comboBox1.DisplayMember = "matricule";
                    comboBox1.ValueMember = "id";



                    MessageBox.Show("adherent delete ");




                    picture.ImageLocation = Resources.round_account_button_with_user_inside.ToString();
                    txtTel.Text = "";
                    txtaddress.Text = "";
                    txtPren.Text = "";
                    txtNom.Text = "";

                    /*--------------*/
                    panel1.Visible = false;


                }
                else return;
            }
            else
            {
                btnSupp.Cursor = Cursors.No;
                MessageBox.Show(" utilisateur n'est pas sautoriser a supprimer");

            }

        }

        private void btnModifier_MouseHover(object sender, EventArgs e)
        {
            if (MS.Contains('M'))
            {

                btnModifier.Cursor = Cursors.Hand;








            }
            else
            {

                btnModifier.Cursor = Cursors.No;
                MessageBox.Show(" utilisateur n'est pas sautoriser a modifier");

            }

        }

        private void btnSupp_MouseHover(object sender, EventArgs e)
        {

            if (MS.Contains('S'))
            {

                btnSupp.Cursor = Cursors.Hand;





            }
            else
            {
                btnSupp.Cursor = Cursors.No;

                MessageBox.Show(" utilisateur n'est pas sautoriser a supprimer");
            }
        }

        private void checkCategorie_Click(object sender, EventArgs e)
        {
            if (checkCategorie.Value)
            {
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
            }
        }
    }
}
