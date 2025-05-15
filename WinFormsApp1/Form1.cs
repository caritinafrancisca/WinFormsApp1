namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se o retorno do método ShowDialog() for ok
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //instancia StreamReader para ler o arquivo
                StreamReader arq = new StreamReader(openFileDialog1.FileName);
                //grava o nome do arquivo na propriedade text do formulàrio
                this.Text = openFileDialog1.FileName;
                //armazena o conteúdo do arquivo em um array de string
                string[] str = { arq.ReadToEnd() };
                //atribui a variável str à propriedade lines do arquivo
                textBox1.Lines = str;
                //fecha o arquivo
                arq.Close();
            }

        }
    }    
}
