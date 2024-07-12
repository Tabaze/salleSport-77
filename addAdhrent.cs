
using salleSport.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace salleSport
{
    public partial class addAdhrent : Form
    {
        gestionSalleSprortEntities db = new gestionSalleSprortEntities();
        public addAdhrent()
        {
            InitializeComponent();
        }


        private bool mouseDown = false;
        private Point lastLocation;


        private void bare_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            this.Cursor = Cursors.Hand;
        }

        private void bare_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Cursor = Cursors.Default;
        }

        private void bare_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = (this.Location.X - lastLocation.X) + e.X;
                int y = (this.Location.Y - lastLocation.Y) + e.Y;
                this.Location = new Point(x, y);
            }
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
        //
        placeholder p = new placeholder();


        private void addAdhrent_Load(object sender, EventArgs e)
        {
            t_function Dsn = db.t_function.Where(x => x.id == 3).FirstOrDefault();
            txtSommeP.Text = Dsn.column1;
            txtNbrmois.Text = Dsn.column2;


            var req2 = db.categorie.Select(x => new { nom = x.sportCateg });
            comboctgSport.DataSource = req2.ToList();
            comboctgSport.DisplayMember = "nom";


        }
        private void txtNom_Enter(object sender, EventArgs e)
        {
            p.enter(txtNom, "nom", "white", "black");
            label7.Text = "nom";

        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtNom.Text == "nom")
            {
                label7.Text = "";
            }
            p.leave(txtNom, "nom", "black", "white");

        }

        private void txtPren_Enter(object sender, EventArgs e)
        {
            p.enter(txtPren, "prenom", "white", "black");
            label6.Text = "prenom";
        }

        private void txtPren_Leave(object sender, EventArgs e)
        {
            if (txtPren.Text == "" || txtPren.Text == "prenom")
            {
                label6.Text = "";
            }
            p.leave(txtPren, "prenom", "black", "white");

        }

        private void txtaddress_Enter(object sender, EventArgs e)
        {
            p.enter(txtaddress, "address", "white", "black");
            label5.Text = "address";
        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {
            if (txtaddress.Text == "")
            {
                label5.Text = "";
            }
            p.leave(txtaddress, "address", "black", "white");
        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            p.enter(txtTel, "telephone", "white", "black");
            label4.Text = "telephone";
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {
                label4.Text = "";
            }
            p.leave(txtTel, "telephone", "black", "white");

        }

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
        //
        string path = "";
        private void picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                path = o.FileName.ToString();
                picture.ImageLocation = path;
            }
        }

        //  DateTime dd;







        private void btnValider_Click(object sender, EventArgs e)
        {

            //-----------------------------------------------------------
            //verification vide
            if (txtSommeP.Text == "somme payé (dh)"
                || txtNbrmois.Text == "nombre mois payé"
                || txtTel.Text == "telephone"
                || txtaddress.Text == "address"
                || txtPren.Text == "prenom"
                || txtNom.Text == "nom")
            {
                MessageBox.Show("veillez entrer tout les donnes"); return;
            }

            Adherent ad = new Adherent();



            if (ckCatgSport.Value)
            {
                ad.sportCatg = comboctgSport.Text;
            }


            ad.nomAdh = txtNom.Text;
            ad.prenomAdh = txtPren.Text;
            ad.telephone = txtTel.Text;
            ad.adress = txtaddress.Text;

            ad.sexe = (rdM.Checked) ? "masculin" : "fiminin";
            //date
            // DateTime dN=DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime dN = DateTime.Today;
            ad.dateInscription = dN;
            ad.datePayement = dN;

            // calcule nbrMonth

            //
            //for (int i = 0; i < int.Parse(txtNbrmois.Text); i++)
            //{
            //    dN = dN.AddDays(DateTime.DaysInMonth(dN.Year,dN.Month));
            //}

            dN = dN.AddMonths(int.Parse(txtNbrmois.Text));
            ad.reste = int.Parse(txtNbrmois.Text);
            ad.dateNextPayement = dN;
            ad.etatPyement = true;
            ad.active = true;
            ad.dejatDesactiver = false;
            ad.remarque=txtRemarque.Text;


            //add picture
            if (path != "")
            {
                byte[] p = null;
                FileStream s = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(s);
                p = brs.ReadBytes((int)s.Length);
                ad.pic = p;



            }
            else
            {
                MessageBox.Show("vieller  ajouter une photo");

                return;
            }

            db.Adherent.Add(ad);
            db.SaveChanges();



            int m = (db.Adherent.Select(x => x.idAdh)).Max();



            //add benifice
            benifice b = new benifice();

            b.matriculeAdh = txtNom.Text + "-" + txtPren.Text;
            //---
            b.somme = float.Parse(txtSommeP.Text, CultureInfo.InvariantCulture);
            b.datepayement = DateTime.Parse(DateTime.Today.ToShortDateString());
            db.benifice.Add(b);
            db.SaveChanges();


            MessageBox.Show("les information est ben enregister");


            //vider
            txtSommeP.Text = "somme payé (dh)";
            txtNbrmois.Text = "nombre mois payé";
            txtTel.Text = "telephone";
            txtaddress.Text = "address";
            txtPren.Text = "prenom";
            txtNom.Text = "nom";
            picture.ImageLocation = Resources.add.ToString();

            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";







        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }

        private void txtSommeP_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); if (txtSommeP.Text.Contains(".") == false && txtSommeP.Text.Contains(",") == false && txtSommeP.Text != "") { if (e.KeyChar == ',') { e.Handled = char.IsControl(e.KeyChar); } if (e.KeyChar == '.') { e.Handled = char.IsControl(e.KeyChar); } } }

        private void txtNbrmois_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }



        private void close_Click(object sender, EventArgs e) { this.Close(); Application.OpenForms[1].Show(); }





        private void ckCatgSport_Click(object sender, EventArgs e)
        { if (ckCatgSport.Value) { comboctgSport.Visible = true; } else { comboctgSport.Visible = false; } }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
