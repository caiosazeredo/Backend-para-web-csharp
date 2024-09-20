using System.Drawing;
using System.Windows.Forms;

namespace aula_5
{
    public partial class Form1 : Form
    {
        public double acumulador;
        public double acumuladorqtd;

        public Form1()
        {
            InitializeComponent();
            acumulador = 0;
            acumuladorqtd = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se a quantidade inserida é um número válido
            if (int.TryParse(textBox2.Text, out int qtd) && qtd > 0 && double.TryParse(textBox3.Text, out double valor))
            {
                string itemNome = textBox1.Text;


                listBox1.Items.Add($"{itemNome} - Quantidade: {qtd} - RS{valor:F2}");


                acumulador += valor * qtd;
                acumuladorqtd += qtd;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (acumuladorqtd <= 30)
            {
                label6.Text = $"Total: RS${acumulador:F2}";

            }
            else
            {
                MessageBox.Show("Foram solicitados mais de 30 livros de uma vez", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
