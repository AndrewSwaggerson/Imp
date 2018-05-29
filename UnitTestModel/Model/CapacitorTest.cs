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
    // Тесты для конденсатора

    [TestFixture]

    class CapacitorTest
    {
        /// <summary>
        /// Тестирование value (должно быть больше 0)
        /// </summary>   
        [Test]
        [TestCase(2.2, TestName = "Тестирование при попытке присвоить полжительное значение ")]
        public void PositiveValue(double value)
        {
            var capValue = new Inductor();
            capValue.Value = value;
        }

        [Test]
        [TestCase(Double.PositiveInfinity, typeof(ArgumentException), TestName = "Тестирование при попытке присвоить PositiveInfinity")]
        [TestCase(Double.NaN, typeof(ArgumentException), TestName = "Тестирование при попытке присвоить NaN")]
        [TestCase(-2.2, typeof(ArgumentException), TestName = "Тестирование при попытке присвоить отрицательное значение")]
        public void NegativeValue(double value, Type expectedException)
        {
            var capValue = new Inductor();
            Assert.Throws(expectedException, () => capValue.Value = value);
        }

        /// <summary>
        /// Тестирование Capacitor.GetImpedance()
        /// </summary>

        [Test]
        [TestCase(5, 10, TestName = "Тестирование функции GetImpedance")]
        public void capacitorImpedanceTest(double _value, double _freq)
        {
            IElement impCapacitor = new Capacitor();
            impCapacitor.Value = _value;
            Complex capComplex = new Complex(0.0, 100 * Math.PI);
            Assert.AreEqual(impCapacitor.GetImpedance(_freq), capComplex);
        }
    }

}

