using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace salleSport
{
    public partial class backUp : Form
    {
        public backUp()
        {
            InitializeComponent();
        }

        static gestionSalleSprortEntities db = new gestionSalleSprortEntities();
        SqlConnection cn = new SqlConnection(db.Database.Connection.ConnectionString);





        private void backUp_Load(object sender, EventArgs e)
        {

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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[2].Show();
        }

        private void bar_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool mouseDown = false;
        private Point lastLocation;





        private void bar_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = (this.Location.X - lastLocation.X) + e.X;
                int y = (this.Location.Y - lastLocation.Y) + e.Y;
                this.Location = new Point(x, y);
            }
        }

        private void bar_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            this.Cursor = Cursors.Hand;
        }

        private void bar_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Cursor = Cursors.Default;
        }




        private void btn_browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog(); if (fd.ShowDialog() == DialogResult.OK) { txt_foder_backup.Text = fd.SelectedPath; }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            try { if (txt_foder_backup.Text == "") { MessageBox.Show("choisi le Chemin de deplacement de cette Sauvegarde"); btn_browser.BackColor = Color.Gray; return; } progressBar1.Value = 70; lb_progress.Text = "70 %"; cn.Open(); string backupName = "\\SAUVGARDE" + "_" + DateTime.Now.ToString("ddMMyyyy_HH.mm.ss") + ".bak"; string req = "BACKUP DATABASE [" + cn.Database + "] TO DISK = N'" + txt_foder_backup.Text + backupName + "'"; SqlCommand cmd = new SqlCommand(req, cn); cmd.ExecuteNonQuery(); cn.Close(); lb_progress.Text = "Sauvegarde est bien fait ...."; progressBar1.Value = 100; } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }




        private void btn_restore_Click(object sender, EventArgs e)
        {
            try { OpenFileDialog op = new OpenFileDialog(); op.Filter = "Backup File(*.bak) | *.bak"; op.Title = "select backup File"; if (op.ShowDialog() == DialogResult.OK) { progressBar1.Value = 70; lb_progress.Text = "70 %"; cn.Open(); string req = "alter database [" + cn.Database + "] set offline with rollback immediate RESTORE DATABASE [" + cn.Database + "] FROM DISK = N'" + op.FileName + "'WITH FILE = 1, NOUNLOAD, STATS = 5 alter database [" + cn.Database + "] set online with rollback immediate "; SqlCommand cmd = new SqlCommand(req, cn); cmd.ExecuteNonQuery(); cn.Close(); progressBar1.Value = 100; lb_progress.Text = "les informations de la base de donne est bien Restaurer ...."; } } catch (Exception ex) { MessageBox.Show(ex.Message); } finally { cn.Close(); }
        }


    }
}
