namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            label4.Text = string.Empty;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool zgoda = checkBox1.Checked;
            if (zgoda)
            {
                checkBox1.Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            string haslo = textBox2.Text;
            string phaslo = textBox3.Text;
            string nazwa = textBox1.Text;
            bool zg = checkBox1.Checked;
            label4.ForeColor = Color.Red;
            if (string.IsNullOrEmpty(haslo) || !zg || string.IsNullOrEmpty(phaslo) || string.IsNullOrEmpty(nazwa))
            {
                label4.Text += "Wype³niij wszystkie pola! \n";
            }
            if (haslo != phaslo)
            {
                label4.Text += "Has³a nie s¹ identyczne \n";
            }

            if (haslo.Length < 8)
            {
                label4.Text += "Haslo musi posiadaæ conajmniej 8 znaków \n";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}