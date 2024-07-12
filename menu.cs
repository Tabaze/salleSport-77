using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace salleSport
{
    public partial class menu : Form
    {
        string r = "US";
        string u = "";
        string m = "";
        public menu(string role, string nom, string md)
        {
            r = role;
            u = nom;
            m = md;

            InitializeComponent();
        }
        public menu()
        {

            InitializeComponent();
        }

        private bool mouseDown = false;
        private Point lastLocation;



        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
            this.Cursor = Cursors.Default;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            this.Cursor = Cursors.Hand;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                int x = (this.Location.X - lastLocation.X) + e.X;
                int y = (this.Location.Y - lastLocation.Y) + e.Y;
                this.Location = new Point(x, y);
            }
        }
        private void AjjAdherent_Click(object sender, EventArgs e)
        {
            if (r.Contains('A'))
            {

                AjjAdherent.Cursor = Cursors.Hand;
                addAdhrent a = new addAdhrent();
                this.Hide();
                a.Show();

            }
            else
            {

                AjjAdherent.Cursor = Cursors.No;
                MessageBox.Show("user ne as autoriser a ajouter adherent ");

            }

        }

        private void menu_Load(object sender, EventArgs e)
        {

            t_function D = db.t_function.Find(2);
            if (D != null)
            {
                label1.Text = D.column1;
            }
            label3.Text = u;

        }

        private void btnpayement_Click(object sender, EventArgs e)
        {

            if (r.Contains('V'))
            {
                payement a = new payement(true);
                this.Hide();
                a.Show();

            }
            else
            {
                payement a = new payement(false);
                this.Hide();
                a.Show();
            }



        }

        private void btnMiseAjour_Click(object sender, EventArgs e)
        {

            if (r.Contains('S') && r.Contains('M'))
            {
                updatList a = new updatList("MS");
                this.Hide();
                a.Show();
                return;
            }
            else if (r.Contains('S') == false && r.Contains('M') == false)
            {
                btnMiseAjour.Cursor = Cursors.No;
                MessageBox.Show("user ne as autoriser a ajouter adherent ");
            }



            if (r.Contains('M'))
            {
                updatList a = new updatList("M");
                this.Hide();
                a.Show();

            }

            else

            if (r.Contains('S'))
            {
                updatList a = new updatList("S");
                this.Hide();
                a.Show();
            }


        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            if (r.Contains('D'))
            {

                btnConfiguration.Cursor = Cursors.Hand;
                configuration a = new configuration();
                this.Hide();
                a.Show();
            }
            else
            {

                btnConfiguration.Cursor = Cursors.No;
                MessageBox.Show("vous etes pas admin pour acces a configuration");




            }

        }
        gestionSalleSprortEntities db = new gestionSalleSprortEntities();

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("voullez vous quitter application ?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (d == DialogResult.Yes)
            {


                t_function act = db.t_function.Find(99);
                if (act != null)
                {


                    if (act.column2 == "try")
                    {
                        Application.Exit();
                    }


                }








                DialogResult d2 = MessageBox.Show("voullez vous reste connecter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (d2 == DialogResult.Yes)
                {
                    utilisateur u1 = db.utilisateur.Where(x => x.username == u && x.motDePasse == m).FirstOrDefault();
                    t_function md = db.t_function.Find(1);

                    if (md != null)
                    {
                        if (u1 != null)
                        {
                            md.column1 = u1.username;
                            md.column2 = u1.motDePasse;
                            db.SaveChanges();
                        }
                    }

                    Application.Exit();

                }

                if (d2 == DialogResult.No)
                {

                    t_function md = db.t_function.Find(1);
                    md.column1 = "xxx";
                    md.column2 = "xxx";
                    db.SaveChanges();
                    Application.Exit();

                }



            }
            if (d == DialogResult.No)
            {
                DialogResult d2 = MessageBox.Show("voullez vous reste connecter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (d2 == DialogResult.Yes)
                {
                    utilisateur u1 = db.utilisateur.Where(x => x.username == u && x.motDePasse == m).FirstOrDefault();
                    t_function md = db.t_function.Find(1);

                    if (md != null)
                    {
                        if (u1 != null)
                        {
                            md.column1 = u1.username;
                            md.column2 = u1.motDePasse;
                            db.SaveChanges();
                        }
                    }


                    Application.Restart();

                }

                if (d2 == DialogResult.No)
                {

                    t_function md = db.t_function.Find(1);
                    md.column1 = "xxx";
                    md.column2 = "xxx";
                    db.SaveChanges();

                    Application.Restart();

                }

                //**



            }
        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AjjAdherent_MouseHover(object sender, EventArgs e)
        {
            b1.BackColor = Color.Black;
            if (r.Contains('A'))
            {

                AjjAdherent.Cursor = Cursors.Hand;



            }
            else
            {

                AjjAdherent.Cursor = Cursors.No;


            }


        }
        private void AjjAdherent_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = Color.Transparent;
        }

        private void btnpayement_MouseHover(object sender, EventArgs e)
        {
            b2.BackColor = Color.Black;
        }
        private void btnpayement_MouseLeave(object sender, EventArgs e)
        {
            b2.BackColor = Color.Transparent;
        }
        private void btnMiseAjour_MouseHover(object sender, EventArgs e)
        {
            b3.BackColor = Color.Black;
            if (r.Contains('S') == false && r.Contains('M') == false)
            {
                btnMiseAjour.Cursor = Cursors.No;

            }
        }
        private void btnMiseAjour_MouseLeave(object sender, EventArgs e)
        {
            b3.BackColor = Color.Transparent;
        }
        private void btnConfiguration_MouseHover(object sender, EventArgs e)
        {
            if (r.Contains('D'))
            {
                btnConfiguration.Cursor = Cursors.Hand;
            }
            else
            { btnConfiguration.Cursor = Cursors.No; }

            b4.BackColor = Color.Black;
        }

        private void btnConfiguration_MouseLeave(object sender, EventArgs e)
        {
            b4.BackColor = Color.Transparent;
        }



        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            t_function D = db.t_function.Find(2);
            if (D != null)
            {
                label1.Text = D.column1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
