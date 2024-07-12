using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace salleSport
{
    public partial class updatloginUser : Form
    {
        public updatloginUser()
        {
            InitializeComponent();
        }
        gestionSalleSprortEntities db = new gestionSalleSprortEntities();
        private void updatloginUser_Load(object sender, EventArgs e)
        {
            gridd.DataSource = db.utilisateur.Where(x => x.licenceType != "DASM").Select(x => x).ToList();
            gridd.Columns[0].Visible = false;
            gridd.Columns[1].Visible = false;
        }

        int id = -1;
        private void gridd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(gridd.CurrentRow.Cells[0].Value.ToString());

            txtNom.Text = gridd.CurrentRow.Cells[2].Value.ToString();
            txtpass1.Text = gridd.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                if (MessageBox.Show("voullez vous modifier application ?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("vous aver memoriser bien le nom de utilisateur et le mot de pass ! ", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {

                        utilisateur u = db.utilisateur.Find(id);
                        if (u != null)
                        {
                            u.username = txtNom.Text;
                            u.motDePasse = txtpass1.Text;

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
                        gridd.DataSource = db.utilisateur.Where(x => x.licenceType != "default").Select(x => x).ToList();
                        gridd.Columns[0].Visible = false;
                        gridd.Columns[1].Visible = false;

                    }
                }
            }
            else
                MessageBox.Show("selectionne un compte pour la modifier  ");

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (gridd.Rows.Count < 2)
            {
                MessageBox.Show("la supprition est annulé , il faux que exist au moin deux compte dans la base de donne");
                return;
            }

            if (id != -1)
            {
                utilisateur u = db.utilisateur.Find(id);
                if (u != null)
                {
                    db.utilisateur.Remove(u);

                }
                db.SaveChanges();
                MessageBox.Show("la  supprition est bien fait ");
                gridd.DataSource = db.utilisateur.Where(x => x.licenceType != "default").Select(x => x).ToList(); ;
                gridd.Columns[0].Visible = false;
                gridd.Columns[1].Visible = false;
            }
            else
                MessageBox.Show("selectionne un compte pour la supprimer  ");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[2].Show();
        }

        private void retuurn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[2].Show();
        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool mouseDown = false;
        private Point lastLocation;



        private void bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = (this.Location.X - lastLocation.X) + e.X;
                int y = (this.Location.Y - lastLocation.Y) + e.Y;
                this.Location = new Point(x, y);
            }
        }

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

        private void bar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
