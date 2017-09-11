using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Compilador
{
    class Lexico
    {
        int iterador = 0;
        ArrayList lista1 = new ArrayList();
        ArrayList lista2 = new ArrayList();
        public void Inicio(string textBox1)
        {

            //aqui se trata o inicio dessa bagaça, faz a converção do texto de string pra char 
            //pra poder trabalhar na pilha e iterar na fita e comparar os resultados obtidos.
            textBox1 += "$";
            char[] entrada = new char[textBox1.Length];
            entrada = textBox1.ToCharArray();
            string teste = entrada[0].ToString();
            
            
            MessageBox.Show("");
            
            MessageBox.Show(textBox1); 
        }
        void S0()
        {

        }
        void S1()
        {

        }
        void S2() { }
        void S3() { }
        void S4() { }
        void S5() { }
        void S6() { }
        void S7() { }
        void S8() { }
        void S9() { }
        void S10() { }
        void S11() { }
        void S12() { }
        void S13() { }





    }
}
