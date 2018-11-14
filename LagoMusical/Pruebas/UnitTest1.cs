using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LagoMusical.Clases;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EjecutarBrr()
        {
            GeneraCancion obj = new GeneraCancion();
            List<Datos> sound = new List<Datos>();


            Assert.IsTrue(obj.LlenarLista(out sound));

        }
    }
}
