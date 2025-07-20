using System;
using System.Windows.Forms;

namespace WinFormsApp23
{
    public partial class Home : Form
    {
        private string _username;

        public Home(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblusername.Text = _username;
            HideAllUserControls();

            userControl111.Visible = true;
            userControl111.BringToFront();

            MovePanel(button1);
        }

        private void MovePanel(Control btn)
        {
            pnlMove.Top = btn.Top;
            pnlMove.Height = btn.Height;
        }

        private void HideAllUserControls()
        {
            userControl111.Visible = false;
            userControlBrand12.Visible = false;
            userControlCategory1.Visible = false;

            userControlBrand11.Visible = false;
            userControlOrder1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovePanel(button1);
            HideAllUserControls();

            userControl111.Visible = true;
            userControl111.BringToFront();
            userControl111.RefreshStats();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovePanel(button2);
            HideAllUserControls();

            userControlBrand12.Visible = true;
            userControlBrand12.BringToFront();
            userControlBrand12.EmptyBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovePanel(button3);
            HideAllUserControls();

            userControlCategory1.Visible = true;
            userControlCategory1.BringToFront();
            userControlCategory1.EmptyBox();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            MovePanel(button5);
            HideAllUserControls();
            userControlOrder1.Visible = true;
            userControlOrder1.BringToFront();


        }




        private void button7_Click_1(object sender, EventArgs e)
        {
            MovePanel(button7);
            HideAllUserControls();

            DialogResult dialogResult = MessageBox.Show(
                "Do you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        // Optional: remove duplicate Paint events if unused
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void userControl111_Load(object sender, EventArgs e) { }
        private void userControlCategory1_Load(object sender, EventArgs e) { }

        private void userControlOrder1_Load(object sender, EventArgs e)
        {

        }

        private void userControlBrand12_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
