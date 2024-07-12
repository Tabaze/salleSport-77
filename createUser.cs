using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace salleSport
{
    public partial class createUser : Form
    {
        public createUser()
        {
            InitializeComponent();
        }


        private bool mouseDown = false;
        private Point lastLocation;






        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Opacity = 1;
            Application.OpenForms[0].Show();

        }
        gestionSalleSprortEntities db = new gestionSalleSprortEntities();
        public string roles()
        {
            string r = "U";
            foreach (var c in groupBox1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        r += ((CheckBox)c).Name;
                    }
                }
            }

            return r;
        }


        public bool exit(string user)
        {

            var req = db.utilisateur.Select(x => x).ToList();
            foreach (var i in req)
            {
                if (i.username.Trim() == user)
                {

                    return true;
                }
            }
            return false;

        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "user name" || txtpass1.Text == "password" || txtpass2.Text == "repet password")
            {
                MessageBox.Show("complete all information"); return;
            }
            if (MessageBox.Show("you want to create this user ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (exit(txtUser.Text.Trim()) == true)
                {
                    MessageBox.Show("username exist");
                    return;
                }

                if (txtpass1.Text.Length < 8 || txtpass2.Text.Length < 8)
                {
                    MessageBox.Show("min lengh 8"); return;
                }

                if (txtpass1.Text.Trim() == txtpass2.Text.Trim())
                {
                    utilisateur u = new utilisateur();
                    u.licenceType = roles();
                    u.username = txtUser.Text;
                    u.motDePasse = txtpass1.Text;
                    db.utilisateur.Add(u);
                    db.SaveChanges();
                    MessageBox.Show("user is created successfully");
                    this.Close();
                    Application.OpenForms[0].Opacity = 1;
                    Application.OpenForms[0].Show();

                }
                else
                {
                    MessageBox.Show("password repeter est incorrect");
                }





            }
        }
        placeholder p = new placeholder();
        private void txtUser_Enter(object sender, EventArgs e)
        {
            p.enter(txtUser, "user name", "white", "black");
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            p.leave(txtUser, "user name", "black", "white");
        }

        private void txtpass1_Leave(object sender, EventArgs e)
        {
            p.leave(txtpass1, "password", "black", "white");
        }

        private void txtpass1_Enter(object sender, EventArgs e)
        {
            p.enter(txtpass1, "password", "white", "black");
        }

        private void txtpass2_Leave(object sender, EventArgs e)
        {
            p.leave(txtpass2, "repet password", "black", "white");
        }

        private void txtpass2_Enter(object sender, EventArgs e)
        {
            p.enter(txtpass2, "repet password", "white", "black");
        }

        private void createUser_Load(object sender, EventArgs e)
        {

        }

        private void createUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = (this.Location.X - lastLocation.X) + e.X;
                int y = (this.Location.Y - lastLocation.Y) + e.Y;
                this.Location = new Point(x, y);
            }
        }

        private void createUser_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void createUser_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }




    }
}
