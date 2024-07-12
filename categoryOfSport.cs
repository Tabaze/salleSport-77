using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace salleSport
{
    public partial class categoryOfSport : Form
    {
        public categoryOfSport()
        {
            InitializeComponent();
        }
        gestionSalleSprortEntities db = new gestionSalleSprortEntities();
        private bool mouseDown = false;
        private Point lastLocation;
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[2].Opacity = 1;
        }

        private void retuurn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[2].Opacity = 1;
        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bar_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Cursor = Cursors.Default;
        }

        private void bar_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            this.Cursor = Cursors.Hand;
        }

        private void bar_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = (this.Location.X - lastLocation.X) + e.X;
                int y = (this.Location.Y - lastLocation.Y) + e.Y;
                this.Location = new Point(x, y);
            }
        }

        private void categoryOfSport_Load(object sender, EventArgs e)
        {
            gridd.DataSource = db.categorie.Select(x => x).ToList();
            gridd.Columns[0].Visible = false;




        }
        int id = -1;
        private void btnSupp_Click(object sender, EventArgs e)
        {

            try
            {


                if (gridd.Rows.Count < 2)
                {
                    MessageBox.Show("la supprition est annulé , il faux que exist au moin deux compte dans la base de donne");
                    return;
                }

                if (id != -1)
                {
                    categorie u = db.categorie.Find(id);
                    if (u != null)
                    {
                        db.categorie.Remove(u);

                    }
                    db.SaveChanges();
                    MessageBox.Show("la  supprition est bien fait ");
                    gridd.DataSource = db.categorie.Select(x => x).ToList(); ;
                    gridd.Columns[0].Visible = false;

                }
                else
                    MessageBox.Show("selectionne un compte pour la supprimer  ");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            try
            {
                if (id != -1)
                {
                    if (MessageBox.Show("voullez vous modifier application ?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("vous aver memoriser bien le nom de utilisateur et le mot de pass ! ", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {

                            categorie u = db.categorie.Find(id);
                            if (u != null)
                            {
                                u.sportCateg = txtNom.Text;


                            }
                            db.SaveChanges();
                            t_function md = db.t_function.Find(1);
                            if (md != null)
                            {
                                md.column1 = "xxx";
                                md.column2 = "xxx";
                                db.SaveChanges();
                                Application.Restart();
                            }


                            MessageBox.Show(" la modification est bien fait ");
                            gridd.DataSource = db.categorie.Select(x => x).ToList();
                            gridd.Columns[0].Visible = false;
                            gridd.Columns[1].Visible = false;

                        }
                    }
                }
                else
                    MessageBox.Show("selectionne un compte pour la modifier  ");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(gridd.CurrentRow.Cells[0].Value.ToString());

            txtNom.Text = gridd.CurrentRow.Cells[1].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("voullez vous ajouter cette categorie  ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    categorie u = new categorie();
                    u.sportCateg = txtNom.Text;
                    db.categorie.Add(u);
                    db.SaveChanges();



                    MessageBox.Show("element est bien ajouter");
                    gridd.DataSource = db.categorie.Select(x => x).ToList();
                    gridd.Columns[0].Visible = false;



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
