using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            byte n1 = 10;  //0 a255
            int num = 1000;  //
            char letra = 'x';
            float valor = 5.3f;
            string nome = "Leo";

            var Aux = nome;



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //CASO QUEIRA CRIAR UM NOVA INSTANCIA DE FORM1

            /*
             Form1 form = new Form1(); // Cria uma instância de Form1
             form.button1.Text = nome; // Define o texto do botão através da instância
            
            //aqui a forma de executar o formulário 
             Application.Run(form); // Inicia o aplicativo com o formulário
            */
            Application.Run(new Form1());


        }
    }
}
