using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace salleSport
{
    public partial class configuration : Form
    {
        public configuration()
        {
            InitializeComponent();
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

        private void retuurn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Refresh();
            Application.OpenForms[1].Show();

        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }

        private void configuration_Load(object sender, EventArgs e)
        {
            t_function df = db.t_function.Where(x => x.id == 3).FirstOrDefault();
            chart();


            var req2 = db.Adherent.Select(x => new { matricule = x.nomAdh + "-" + x.prenomAdh, id = x.idAdh });
            combo_adh.DataSource = req2.ToList();
            combo_adh.DisplayMember = "matricule";
            combo_adh.ValueMember = "id";

            t_function D = db.t_function.Find(2);

            if (D != null)
            { txtlogin.Text = D.column1; }
        }
        public void chart()
        {
            var bb = db.Adherent.Sum(x => x.reste);
            lblCredit.Text = "Total Credit : " + bb;
            lblCredit.Visible = true;
            var b = db.benifice.Where(x => x.datepayement.Value.Year == valueYear.Value).GroupBy(p => p.datepayement.Value.Month, q => q.somme).Select(x => new { datep = x.Key, sal = x.Sum(s => s) });
            gridd.DataSource = b.ToList();
            gridd.Columns[0].HeaderText = "Mois";
            gridd.Columns[1].HeaderText = "Benifice en Dirhame";


            chart1.DataSource = b.ToList();
            chart1.Series["benific"].XValueMember = "datep";
            chart1.Series["benific"].YValueMembers = "sal";
            chart1.Series["benific"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;


        }
        private void btnBenifice_Click(object sender, EventArgs e)
        {

            chart();

        }



        private void listP_Click(object sender, EventArgs e)
        {
            var b = db.benifice.Select(x => new { x.matriculeAdh, x.datepayement, x.somme });

            gridd.DataSource = b.ToList();
            gridd.Columns[0].Width = 100;
            gridd.Columns[1].Width = 80;
            gridd.Columns[2].Width = 55;

        }













        private void btnMsj_Click_1(object sender, EventArgs e)
        {
            updatloginUser u = new updatloginUser();
            this.Hide();
            u.Show();
        }

        private void btncopieList_Click(object sender, EventArgs e)
        {


        }

        private void btnDefault_Click_1(object sender, EventArgs e)
        {

            t_function df = db.t_function.Where(x => x.id == 3).FirstOrDefault();
            db.SaveChanges();
            MessageBox.Show("les information est bien enregistrer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            backUp b = new backUp();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (combo_adh.Text == "")
            {

                return;
            }
            if (combo_adh.SelectedIndex == -1)
            {
                MessageBox.Show("select adherant");
                combo_adh.Text = "";
                combo_adh.SelectedIndex = 0;
                return;
            }
            else
            {

                string matricule = combo_adh.Text;
                var b = db.benifice.Where(x => x.matriculeAdh == matricule).Select(x => new { x.matriculeAdh, x.datepayement, x.somme });



                gridd.DataSource = b.ToList();
                gridd.Columns[0].Width = 100;
                gridd.Columns[1].Width = 80;
                gridd.Columns[2].Width = 55;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoryOfSport c = new categoryOfSport();
            c.Show();
            this.Opacity = 0.5;
        }
        bool c = false;

        private void button4_Click(object sender, EventArgs e)
        {


            if (c == false)
            {
                txtlogin.Visible = true;
                label2.Visible = true;
                c = true;
                button4.Focus();

            }
            else
            {


                txtlogin.Visible = false;
                label2.Visible = false;
                c = false;

                t_function D = db.t_function.Find(2);

                if (D == null)
                {



                    t_function md = new t_function();

                    md.id = 2;
                    md.column1 = txtlogin.Text;

                    db.t_function.Add(md);
                    db.SaveChanges();



                }
                else
                {
                    D.column1 = txtlogin.Text;

                    db.SaveChanges();
                }
                MessageBox.Show("les information est bien enregistrer");



            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            var b = db.Adherent.Select(x => new { x.nomAdh, x.reste });

            gridd.DataSource = b.ToList();
            gridd.Columns[0].Width = 100;
            gridd.Columns[1].Width = 80;
        }
    }
}

