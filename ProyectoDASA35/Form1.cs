using System.Diagnostics.Contracts;

namespace ProyectoDASA35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Monster" && textBox2.Text == "2015000412")
            {
                CRUD frm = new CRUD();
                this.Hide();
                frm.Show();
                MessageBox.Show("Usuario y Constraseña correctos, adelante!");
                
            }
            else
            {
                MessageBox.Show("Algun Dato esta incorrecto");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
