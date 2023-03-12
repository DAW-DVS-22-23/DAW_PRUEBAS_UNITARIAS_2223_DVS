using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestionBancariaAppNS;
using System.Windows.Forms;

namespace GestionBancariaTestDVS
{
    [TestClass]
    public class GestionBancariaTestDVS
    {
        [TestMethod]
        public void ValidarReintegro()
        {
            //Preparación de caso de prueba DVS 22/23
            double saldoInicial = 1000;
            double reintegro = 250;
            double saldoEsperado = 750;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

            //Método a probar DVS 22/23

            miApp.RealizarReintegro(reintegro);

            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
        }


    }
}
