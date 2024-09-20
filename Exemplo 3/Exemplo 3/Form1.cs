namespace Exemplo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                value = value / 10;
                // Adiciona 550 ao valor se a primeira CheckBox estiver marcada
                if (checkBox1.Checked)
                {
                    value += 550;
                }

                // Adiciona 350 ao valor se a segunda CheckBox estiver marcada
                if (checkBox2.Checked)
                {
                    value += 350;
                }
                value = Math.Round(value, 2);
                // Exibe o resultado no Label
                label1.Text = "Resultado: " + value.ToString();
            }
            else
            {
                // Exibe uma mensagem de erro se o valor não for um número válido
                MessageBox.Show("Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}