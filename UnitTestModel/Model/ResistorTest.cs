using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using NUnit.Framework;

namespace UnitTestModel.Model
{
    //Тесты для Резистора

    [TestFixture]
   
    class ResistorTest
    {        
        /// <summary>
        /// Тестирование value (должно быть больше 0)
        /// </summary>
         
        [Test]
        [TestCase(2.2, TestName = "Тестирование при попытке присвоить полжительное значение ")]
        public void PositiveValue(double value)
        {
            var resValue = new Resistor();
            resValue.Value = value;
        }
        
        [Test]
        [TestCase(Double.NaN, typeof(ArgumentException), TestName = "Тестирование при попытке присвоить NaN")]
        [TestCase(Double.PositiveInfinity, typeof(ArgumentException), TestName = "Тестирование при попытке присвоить PositiveInfinity")]
        [TestCase(Double.PositiveInfinity, typeof(ArgumentException), TestName = "Тестирование при попытке присвоить PositiveInfinity")]
        public void PositiveinfinityValue(double value, Type expectedException)
        {
            var resValue = new Resistor();
            Assert.Throws(expectedException, () => resValue.Value = value);
        }
    }
}
