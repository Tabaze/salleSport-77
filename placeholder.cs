using System.Drawing;
using System.Windows.Forms;

namespace salleSport
{
    class placeholder
    {

        public void enter(Control c, string text, string foreColor = "black", string backColor = "white")
        {
            if (c.Text == text)
            {
                c.Text = "";
            }
            //--
            if (foreColor.ToLower() == "black")
            {
                c.ForeColor = Color.Black;
            }
            else
                c.ForeColor = Color.White;
            //--
            if (backColor.ToLower() == "white")
            {
                c.BackColor = Color.White;
            }
            else
                c.BackColor = Color.Black;



        }

        public void leave(Control c, string text, string foreColor = "white", string backColor = "black")
        {
            if (c.Text == "")
            {
                c.Text = text;
            }
            //--
            if (foreColor.ToLower() == "white")
            {
                c.ForeColor = Color.White;
            }
            else
                c.ForeColor = Color.Black;
            //--
            if (backColor.ToLower() == "black")
            {
                c.BackColor = Color.Black;
            }
            else
                c.BackColor = Color.White;


        }

    }
}
