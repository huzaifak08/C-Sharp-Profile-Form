namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved Successfully", "Profile Saved", MessageBoxButtons.OKCancel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DO You Want to Exit?","Confirm",MessageBoxButtons.YesNo);
        }
    }
}