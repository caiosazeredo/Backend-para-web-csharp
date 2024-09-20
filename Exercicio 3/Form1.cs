namespace Exercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // Adiciona o conteúdo do TextBox à ListBox
                listBox1.Items.Add(textBox1.Text);
                // Limpa o TextBox após adicionar o conteúdo
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Pedido enviado com sucesso!";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Verifica se há um item selecionado
            if (listBox1.SelectedItem != null)
            {
                // Remove o item selecionado
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}