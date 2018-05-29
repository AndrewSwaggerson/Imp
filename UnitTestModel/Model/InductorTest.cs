using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Numerics;
using NUnit.Framework.Internal;

namespace UnitTestModel.Model
{

    //Тесты для катушки индуктивности
    
    [TestFixture]

    class InductorTest
    {
        /// <summary>
        /// Тестирование value (должно быть больше 0)
        /// </summary>   
        [Test]
        [TestCase(2.2, TestName = "Тестирование при попытке присвоить полжительное значение ")]
        public void PositiveValue(double value)
        {
            var indValue = new Inductor();
            indValue.Value = value;
        }

        [Test]
        [TestCase(-2.2, typeof(ArgumentException), TestName = "Тестирование при попытке присвоить отрицательное значение")]
        [TestCase(Double.PositiveInfinity, typeof(ArgumentException), TestName = "Тестирование при попытке присвоить PositiveInfinity")]
        [TestCase(Double.NaN, typeof(ArgumentException), TestName = "Тестирование при попытке присвоить NaN")]
        public void NanValue(double value, Type expectedException)
        {
            var indValue = new Inductor();
            Assert.Throws(expectedException, () => indValue.Value = value);
        }

        /// <summary>
        /// Тестирование Inductor.GetImpedance()
        /// </summary>

        [Test]
        [TestCase(10, 100, TestName = "Тестирование функции GetImpedance")]
        public void inductorImpedanceTest(double _value, double _freq)
        {
            IElement impInductor = new Inductor();
            impInductor.Value = _value;
            Complex impComplex = new Complex(0.0, -20*Math.PI);
            Assert.AreEqual(impInductor.GetImpedance(_freq), impComplex);
         }
    }
}
