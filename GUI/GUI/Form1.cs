namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Plabon   ");
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Test";
            button2.Text = "close";
        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult dr=MessageBox.Show("do you want to close", "question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                this.Close();
            else
                button1.Text = "success";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}