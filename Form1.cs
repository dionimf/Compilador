using System;
using System.IO;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();


            if (File.Exists(openFileDialog1.FileName)) {
                textBox1.Text = "";
                
                StreamReader leitor = new StreamReader(openFileDialog1.FileName);
                while (!leitor.EndOfStream)
                {
                    textBox1.Text += leitor.ReadLine();

                    
                }
                leitor.Close();
                leitor.Dispose();
            }




        }
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                textBox1.Text = "";
            }
            else
            {
              
                
                MessageBoxButtons botao = MessageBoxButtons.YesNo;
                DialogResult resultado= MessageBox.Show("Deseja Salvar o Arquivo?", "Novo Arquivo",botao);
                if (resultado==DialogResult.Yes)
                {
                    saveFileDialog1.Filter = "Text File| .txt";
                    saveFileDialog1.ShowDialog();

                    if (!(saveFileDialog1.FileName).Equals(""))
                    {
                        StreamWriter escrita = new StreamWriter(saveFileDialog1.FileName);

                        escrita.Write(textBox1.Text);
                        escrita.Flush();
                        escrita.Close();
                    }



                }
                else
                {
                    textBox1.Text = "";
                }


            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File| .txt";
            saveFileDialog1.ShowDialog();

            if (!(saveFileDialog1.FileName).Equals("")) { 
                StreamWriter escrita = new StreamWriter(saveFileDialog1.FileName);

                escrita.Write(textBox1.Text);
                escrita.Flush();
                escrita.Close();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void executarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia e passa os dados da textbox pro lexico pra executar
            Lexico lexi = new Lexico();
            lexi.Inicio(textBox1.Text);
            
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manual Disponivel em: https://goo.gl/PXSe1e");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compilador dessenvolvido na Disciplina de Compiladores da Faculdade UNESC\nAcademico: Dioni Machado Ferreira");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
