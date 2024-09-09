using Microsoft.VisualStudio.TestTools.UnitTesting;
using tax_NathiNugget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tax_NathiNugget.Tests
{
    [TestClass()]
    public class TaxTests
    {
        private Tax _t; 
        [TestInitialize]
        public void Setup()
        {
            _t = null!; 
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(500)]
        [DataRow(20000)]
        public void TaxLowUnderviserTest(int income)
        {
            _t = new Tax(Role.Underviser, income); 
            int actual = (int) (0.1 * income); 
            Assert.AreEqual(_t.TaxToPay, actual); 
        }

        [TestMethod()]
        [DataRow(20001)]
        [DataRow(100000)]
        public void TaxHighUnderviserTest(int income)
        {
            _t = new Tax(Role.Underviser, income);
            int actual = (int)(0.2 * income);
            Assert.AreEqual(_t.TaxToPay, actual);
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(19999)]
        [DataRow(10000)]
        public void TaxStuderendeTest(int income)
        {
            _t = new Tax(Role.Studerende, income);
            int actual = (int)(0.05 * income);
            Assert.AreEqual(_t.TaxToPay, actual);
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(19999)]
        [DataRow(10000)]
        public void TaxPensionistTest(int income)
        {
            _t = new Tax(Role.Pensionist, income);
            int actual = (int)(0.05 * income);
            Assert.AreEqual(_t.TaxToPay, actual);
        }
    }
}