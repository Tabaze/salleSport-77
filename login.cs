using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace salleSport
{
    public partial class login : Form
    {

        gestionSalleSprortEntities db = new gestionSalleSprortEntities();
        public login()
        {
            InitializeComponent();
        }

        private bool mouseDown = false; private Point lastLocation; 
        private void Form1_MouseDown(object sender, MouseEventArgs e) { mouseDown = true; lastLocation = e.Location;
            this.Cursor = Cursors.Hand; }
        private void login_MouseUp(object sender, MouseEventArgs e) { mouseDown = false;
            this.Cursor = Cursors.Default; }
        private void login_MouseMove(object sender, MouseEventArgs e) { if (mouseDown) { int x = (this.Location.X - lastLocation.X) + e.X;
                int y = (this.Location.Y - lastLocation.Y) + e.Y; this.Location = new Point(x, y); } }
        private void pictureBox1_Click(object sender, EventArgs e) { if (MessageBox.Show("voullez vous quitter application ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) { Application.Exit(); } }
        private void minimaze_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }


        int userCount;
        private void login_Load(object sender, EventArgs e) { 
            try { 
                userCount = db.utilisateur.Count(); 
                if (userCount == 0) { 
                    btnLogin.Text = "active admin"; 
                    btnUser.Enabled = false; 
                    txtActivation.Visible = true; 
                    label3.Visible = true;
                } 
                else { 
                    label3.Visible = false; 
                    txtActivation.Visible = false;
                }
                t_function D = db.t_function.Find(1);
                if (D != null) {
                    if (D.column1 != "xxx" && D.column2 != "xxx") { 
                        label2.Visible = true;
                        label1.Visible = false; 
                        txtUserName.Visible = false; 
                        txtPassword.Visible = false;
                        btnUser.Visible = false;
                        btnLogin.Text = "enter";
                        show.Visible = false;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void show_CheckedChanged(object sender, EventArgs e) { if (show.Checked) { if (txtPassword.Text != "password") { txtPassword.isPassword = false; } } else { if (txtPassword.Text != "password") { txtPassword.isPassword = true; } } }
        placeholder p = new placeholder(); private void txtLogin_MouseEnter(object sender, EventArgs e) { btnLogin.BackColor = Color.Black;btnLogin.ForeColor = Color.White; }
        private void txtLogin_MouseLeave(object sender, EventArgs e) { btnLogin.ForeColor = Color.Black; btnLogin.BackColor = Color.Transparent; }
        private void txtUserName_Leave(object sender, EventArgs e) { p.leave(txtUserName, "user name", "black", "white"); }
        private void txtUserName_Enter(object sender, EventArgs e) { p.enter(txtUserName, "user name", "white", "black"); }
        private void txtPassword_Enter(object sender, EventArgs e) { p.enter(txtPassword, "password", "white", "black"); if (txtPassword.Text != "password") { txtPassword.isPassword = true; show.Checked = false; } }
        private void txtPassword_Leave(object sender, EventArgs e) { p.leave(txtPassword, "password", "black", "white"); if (txtPassword.Text == "password") { txtPassword.isPassword = false; } }
        private void btnUser_MouseEnter(object sender, EventArgs e) { btnUser.BackColor = Color.Black; btnUser.ForeColor = Color.White; }
        private void btnUser_MouseLeave(object sender, EventArgs e) { btnUser.ForeColor = Color.Black; btnUser.BackColor = Color.Transparent; }
        bool found;

        public bool FunctionActivation(string ActivationCode) { if (ActivationCode == "") { return false; } if (ActivationCode.Length != 19 || ActivationCode.Substring(4, 1) != "-" && ActivationCode.Substring(9, 1) != "-" && ActivationCode.Substring(14, 1) != "-") { return false; } string d = DateTime.Today.Day.ToString(); string d1 = (d.Length == 1) ? "0" : d.Substring(0, 1); string d2 = (d.Length == 1) ? d : d.Substring(1, 1); if (ActivationCode.Substring(0, 1) + ActivationCode.Substring(3, 1) != d1 + d2) { return false; } string m = DateTime.Today.Month.ToString(); string m1 = (m.Length == 1) ? "0" : m.Substring(0, 1); string m2 = (m.Length == 1) ? m : m.Substring(1, 1); if (ActivationCode.Substring(5, 1) + ActivationCode.Substring(8, 1) != m1 + m2) { return false; } string y = DateTime.Today.Year.ToString(); if (ActivationCode.Substring(10, 1) + ActivationCode.Substring(13, 1) != y.Substring(2, 1) + y.Substring(3, 1)) { return false; } string versiontryOrFull = ActivationCode.Substring(15, 1); t_function act = db.t_function.Find(99); if (act == null) { if (versiontryOrFull == "0") { t_function act1 = new t_function(); act1.id = 99; act1.column1 = DateTime.Today.ToString(); act1.column2 = "full"; db.t_function.Add(act1); db.SaveChanges(); return true; } else if (versiontryOrFull == "1") { t_function act2 = new t_function(); act2.id = 99; act2.column1 = DateTime.Today.AddDays(7).ToShortDateString(); act2.column2 = "try"; db.t_function.Add(act2); db.SaveChanges(); return true; } else { return false; } } else { if (versiontryOrFull == "0") { act.column1 = DateTime.Today.ToString(); act.column2 = "full"; db.SaveChanges(); return true; } else if (versiontryOrFull == "1") { act.column1 = DateTime.Today.ToString(); act.column2 = "try"; db.SaveChanges(); return true; } else { return false; } } }
        public bool PeriodTry() { t_function act = db.t_function.Find(99); if (act != null) { if (act.column2 == "try") { DateTime dv = DateTime.Parse(act.column1); if (dv < DateTime.Today) { return false; } else return true; } else { return true; } } return false; }



        private void btnLogin_Click(object sender, EventArgs e)
        {

            userCount = db.utilisateur.Count();

            if (userCount == 0)
            {
                string ac = txtActivation.Text.Trim();
                if (FunctionActivation(ac))
                {
                    MessageBox.Show("activation est bien fait");
                    txtActivation.Text = "";
                    txtActivation.Visible = false;
                    label3.Visible = false;
                    utilisateur u1 = new utilisateur();
                    u1.username = "admin";
                    u1.motDePasse = "admin";
                    u1.licenceType = "DASVM";
                    db.utilisateur.Add(u1);
                    db.SaveChanges();

                    utilisateur u2 = new utilisateur();
                    u2.username = "admin01";
                    u2.motDePasse = "admin01";
                    u2.licenceType = "DASVM";
                    db.utilisateur.Add(u2);
                    db.SaveChanges();

                    t_function md = new t_function();
                    md.id = 1;
                    md.column1 = "xxx";
                    md.column2 = "xxx";
                    db.t_function.Add(md);
                    db.SaveChanges();


                    t_function df = new t_function();
                    df.id = 3;
                    df.column1 = "0";
                    df.column2 = "1";
                    db.t_function.Add(df);
                    db.SaveChanges();








                    btnLogin.Text = "login";
                    btnUser.Enabled = true;
                    return;

                }
                else
                {
                    MessageBox.Show("licence key n'est pas valide");
                    return;
                }








            }

            if (PeriodTry() == false)
            {
                MessageBox.Show("votre période d’essai est terminer");
                btnLogin.Text = "active admin";
                btnUser.Enabled = false;
                txtActivation.Visible = true;
                label3.Visible = true;
                if (txtActivation.Text == "")
                {
                    MessageBox.Show("entrer licence key ");
                    return;
                }

                if (FunctionActivation(txtActivation.Text.Trim()))
                {

                    MessageBox.Show("activation est bien fait");
                    txtActivation.Visible = false;
                    label3.Visible = false;
                    return;
                }
                else
                {
                    MessageBox.Show("licence key n'est pas valide");
                    return;
                }

            }


            // direct entrer

            t_function D = db.t_function.Find(1);
            if (D != null)
            {
                if (D.column1 != "xxx" && D.column2 != "xxx")
                {
                    utilisateur u = db.utilisateur.Where(x => x.username == D.column1 && x.motDePasse == D.column2).FirstOrDefault();



                    txtUserName.Text = "user name"; txtPassword.Text = "password";
                    this.Cursor = Cursors.Default;

                    if (u != null)
                    {
                        menu me = new menu(u.licenceType, u.username, u.motDePasse);
                        ///MessageBox.Show("bienVenue  " + D.column1.ToString());
                        this.Hide();
                        me.Show();
                        return;
                    }


                }


            }


            //verifier vide
            if (txtUserName.Text == "user name" || txtPassword.Text == "password")
            {
                MessageBox.Show("veillez entrer tout les donnes"); return;
            }
            this.Cursor = Cursors.WaitCursor;

            //verifier pass et user
            found = false;

            //  var req = db.utilisateur.Select(x => x).ToList();





            utilisateur ul = db.utilisateur.Where(x => x.username == txtUserName.Text.Trim() && x.motDePasse == txtPassword.Text.Trim()).FirstOrDefault();

            if (ul != null)
            {
                t_function d = db.t_function.Find(1);
                if (d != null)
                {
                    d.column1 = txtUserName.Text.Trim();
                    d.column2 = txtPassword.Text.Trim();
                    db.SaveChanges();
                }


                txtUserName.Text = "user name"; txtPassword.Text = "password";
                this.Cursor = Cursors.Default;
                found = true;
                menu m = new menu(ul.licenceType, ul.username, ul.motDePasse);
                this.Hide();

                m.Show();
            }

            else
            {
                MessageBox.Show("le nom de utilisateur ou mot de pass incorrect ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Cursor = Cursors.Default;
        }


        private void btnUser_Click_1(object sender, EventArgs e) { if (txtUserName.Text == "user name" || txtPassword.Text == "password") { MessageBox.Show("veillez entrer tout les donnes"); return; } var req = db.utilisateur.Select(x => x).ToList(); foreach (var i in req) { if (i.username == txtUserName.Text.Trim() && i.motDePasse == txtPassword.Text.Trim() && i.licenceType.Contains('D')) { txtUserName.Text = "user name"; txtPassword.Text = "password"; this.Opacity = 0; createUser c = new createUser(); c.Show(); return; } } if (found == false) { MessageBox.Show("le nom de utilisateur ou mot de pass incorrect ou bien vous etes pas admin ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); } }

        private void txtActivation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
