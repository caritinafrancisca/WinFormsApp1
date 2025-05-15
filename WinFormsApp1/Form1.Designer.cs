namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnSalvarComo = new Button();
            btnAbrirArquivo = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 94);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(591, 325);
            textBox1.TabIndex = 0;
            // 
            // btnSalvarComo
            // 
            btnSalvarComo.Location = new Point(311, 41);
            btnSalvarComo.Name = "btnSalvarComo";
            btnSalvarComo.Size = new Size(115, 23);
            btnSalvarComo.TabIndex = 1;
            btnSalvarComo.Text = "Salvar Como...";
            btnSalvarComo.UseVisualStyleBackColor = true;
            btnSalvarComo.Click += btnSalvarComo_Click;
            // 
            // btnAbrirArquivo
            // 
            btnAbrirArquivo.Location = new Point(104, 41);
            btnAbrirArquivo.Name = "btnAbrirArquivo";
            btnAbrirArquivo.Size = new Size(139, 23);
            btnAbrirArquivo.TabIndex = 1;
            btnAbrirArquivo.Text = "Abrir arquivo...";
            btnAbrirArquivo.UseVisualStyleBackColor = true;
            btnAbrirArquivo.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAbrirArquivo);
            Controls.Add(btnSalvarComo);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnSalvarComo;
        private Button btnAbrirArquivo;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
