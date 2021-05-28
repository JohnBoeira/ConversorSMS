using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorSMS.ConsoleApp
{
    public class Conversor
    {
        public string Converter(string sequenciaTexto)
        {
            sequenciaTexto = sequenciaTexto.ToUpper();

            if (Validador(sequenciaTexto))
            {
                return ConverterMensagem(sequenciaTexto);
            }
            else
            {
                throw new FormatException("Mensagem inválida!");
            }
        }

        public bool Validador(string sequenciaTexto)
        {
            if (sequenciaTexto.Length > 255)
                return false;
            else if (sequenciaTexto.Length <= 0)
                return false;
            else return true;
        }

        private string ConverterMensagem(string mensagem)
        {
            string sequencianumerica = null;
            string ultimasequencia = "1";

            foreach (var letra in mensagem)
            {
                if (ultimasequencia.Contains(ConverterLetra(letra).ToCharArray()[0])) //if ("222" COntém '2') 
                {
                    sequencianumerica += "_"+ ConverterLetra(letra);
                }
                else
                {
                    sequencianumerica += ConverterLetra(letra);
                    ultimasequencia = ConverterLetra(letra);
                }               
            }
            return sequencianumerica;

        }

        private string ConverterLetra(char letra)
        {
            switch (letra)
            {
                case 'A': return "2";
                case 'B': return "22";
                case 'C': return "222";
                case 'D': return "3";
                case 'E': return "33";
                case 'F': return "333";
                case 'G': return "4";
                case 'H': return "44";
                case 'I': return "444";
                case 'J': return "5";
                case 'K': return "55";
                case 'L': return "555";
                case 'M': return "6";
                case 'N': return "66";
                case 'O': return "666";
                case 'P': return "7";
                case 'Q': return "77";
                case 'R': return "777";
                case 'S': return "7777";
                case 'T': return "8";
                case 'U': return "88";
                case 'V': return "888";
                case 'W': return "9";
                case 'X': return "99";
                case 'Y': return "999";
                case 'Z': return "9999";
                case ' ': return "0";
                default: throw new FormatException("Valor inválido para letra!");
            }
        }


    }
}
