using System;
using EstudosVeica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEstudosVeica
{
    [TestClass]
    public class UnitTestEstudosVeica
    {
        [TestMethod]
        public void TestaMultiplesof3and5()
        {
            Multiplesof3and5 multiplesof3And5 = new Multiplesof3and5();
            Assert.AreEqual(multiplesof3And5.executar(), 233168);
        }

        [TestMethod]
        public void TestaEvenFibonaccinumbers()
        {
            EvenFibonaccinumbers evenFibonaccinumbers = new EvenFibonaccinumbers();
            Assert.AreEqual(evenFibonaccinumbers.executar(), 4613732);
        }

        [TestMethod]
        public void TestaLargestprimefactor()
        {
            Largestprimefactor largestprimefactor = new Largestprimefactor();
            Assert.AreEqual(largestprimefactor.executar(), 6857);
        }
    }
}
