using ConversorSMS.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConversorSMS.UnitTest
{
    [TestClass]
    public class Conversor
    {
        [TestMethod]
        public void Converter_umaletra()
        {
            //arrange
            ConsoleApp.Conversor conversor = new ConsoleApp.Conversor();
            string mensagemTexto = "S";

            //act
            string resultado = conversor.Converter(mensagemTexto);

            //assert
            Assert.AreEqual("7777",resultado);
        }
        [TestMethod]
        public void Converter_frase()
        {
            //arrange
            ConsoleApp.Conversor conversor = new ConsoleApp.Conversor();
            string mensagemTexto = "SEMPRE ACESSO O DOJOPUZZLES";

            //act
            string resultado = conversor.Converter(mensagemTexto);

            //assert
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", resultado);
        }
        [TestMethod]
        public void Converter_palavra()
        {
            //arrange
            ConsoleApp.Conversor conversor = new ConsoleApp.Conversor();
            string mensagemTexto = "SEMPRE";

            //act
            string resultado = conversor.Converter(mensagemTexto);

            //assert
            Assert.AreEqual("77773367_77733", resultado);
        }
        [TestMethod]
        public void Converter_duasletras()
        {
            //arrange
            ConsoleApp.Conversor conversor = new ConsoleApp.Conversor();
            string mensagemTexto = "Se";

            //act
            string resultado = conversor.Converter(mensagemTexto);

            //assert
            Assert.AreEqual("777733", resultado);
        }
        [TestMethod]
        public void Converter_256letras()
        {
            //arrange
            ConsoleApp.Conversor conversor = new ConsoleApp.Conversor();
            string mensagemTexto = "asda                                                                                                                                                                                                                                                                                                                                                             ";

            //act
            bool resultado = conversor.Validador(mensagemTexto);

            //assert
            Assert.IsFalse(resultado);
            
        }
        [TestMethod]
        public void Converter_0letras()
        {
            //arrange
            ConsoleApp.Conversor conversor = new ConsoleApp.Conversor();
            string mensagemTexto = "";

            //act
            bool resultado = conversor.Validador(mensagemTexto);

            //assert
            Assert.IsFalse(resultado);

        }
    }
}
