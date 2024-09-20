namespace Exemplo_4
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
                double valorfinal = value;
                if (checkBox1.Checked)
                {
                    valorfinal -= (value * 0.2);
                }


                if (checkBox2.Checked)
                {
                    valorfinal -= (value * 0.1);
                }
                if (checkBox3.Checked)
                {
                    valorfinal -= (value * 0.7);
                }
                // Exibe o resultado no Label
                label1.Text = "Resultado: " + valorfinal.ToString();
            }
            else
            {
                // Exibe uma mensagem de erro se o valor não for um número válido
                MessageBox.Show("Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}