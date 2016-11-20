using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoDaForca
{
    class JogoClass : Jogo
    {
        Jogo jogo = new Jogo();
        //Vaiaveis todas PRIVATE
        public static string[] bancoDePalavras = {"BANANA", "SELVA", "CAJÚ", "PIPOCA", "ARARAQUARA", "DONINHA", 
                                           "PETRÓLEO", "PAPAGAIO", "BRASIL", "SKATE", "VOLKSWAGEN", "HYUNDAI"};

        //private static string V_palavraSorteada = "";
        //public static string palavraSorteada { 
        //    get{ return V_palavraSorteada;}
        //    set { V_palavraSorteada = value; } 
        //}
        //private static string StrDica = "";
        //public static string StringDica
        //{
        //    get { return StrDica; }
        //    set { StrDica = value; }
        //}    
        public static string palavraSorteada;
        public static char[] palavraManipulada;
        public static int tentativasRestantes = 6;
        public static bool debugOn = false;
        public static bool fimDeJogo = false;
        public static int qtdLetrasEncontradas = 0;
        
        #region "erro"
        //public static void PalavraDica()
        //    {
        //        Jogo jogo = new Jogo();
        //       // Dica -> palavraSorteada
        //        if (JogoClass.palavraSorteada == "BANANA" || JogoClass.palavraSorteada == "CAJÚ")
        //        {
        //            //Dica.Text = "Fruta";
        //            StrDica = "Fruta";
        //        }
        //else if (JogoClass.palavraSorteada == "SELVA")
        //{
        //    Dica.Text = "Reino Animal";
        //}
        //else if (JogoClass.palavraSorteada == "ARARAQUARA")
        //{
        //    Dica.Text = "Cidade";
        //}
        //else if (JogoClass.palavraSorteada == "VOLKSWAGEN" || JogoClass.palavraSorteada == "HYUNDAI")
        //{
        //    Dica.Text = "Marca De Carros";
        //}
        //else if (JogoClass.palavraSorteada == "DONINHA" || JogoClass.palavraSorteada == "PAPAGAIO")
        //{
        //    Dica.Text = "Animais";
        //}
        //else if (JogoClass.palavraSorteada == "BRASIL")
        //{
        //    Dica.Text = "País";
        //}
        //else if (JogoClass.palavraSorteada == "SKATE")
        //{
        //    Dica.Text = "Objeto";
        //}
        //else if (JogoClass.palavraSorteada == "PETRÓLEO")
        //{
        //    Dica.Text = "Matéria Orgânica";
        //}
        //else if (JogoClass.palavraSorteada == "PIPOCA")
        //{
        //    Dica.Text = "Comida";
        //}
    }
        #endregion
}

