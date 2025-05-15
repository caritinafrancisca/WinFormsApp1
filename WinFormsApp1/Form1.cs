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
            //se o retorno do m�todo ShowDialog() for ok
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //instancia StreamReader para ler o arquivo
                StreamReader arq = new StreamReader(openFileDialog1.FileName);
                //grava o nome do arquivo na propriedade text do formul�rio
                this.Text = openFileDialog1.FileName;
                //armazena o conte�do do arquivo em um array de string
                string[] str = { arq.ReadToEnd() };
                //atribui a vari�vel str � propriedade lines do arquivo
                textBox1.Lines = str;
                //fecha o arquivo
                arq.Close();
            }

        }

        private void btnSalvarComo_Click(object sender, EventArgs e)
        {
            //se o retorno do m�todo ShowDialog() for ok
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //declara��o da vari�vel que vai salvar o arquivo
                StreamWriter Arq = new StreamWriter(saveFileDialog1.FileName);
                //Para cada linha no TexBox
                foreach (string s in textBox1.Lines)
                {
                    //escreve uma linha no arquivo
                    Arq.WriteLine(s);
                }
                //fecha o arquivo
                Arq.Close();
            }
        }
    }
}
