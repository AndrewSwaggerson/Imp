using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Model
{
    /// <summary>
    /// объявление класса катушки индуктивности
    /// </summary>
    public class Capacitor : IElement
    {/// <summary>
     /// значение индуктивности
     /// </summary>
        private double _value;
        /// <summary>
        /// свойство имени
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// свойство значения
        /// </summary>
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value < 0 || double.IsNaN(value) || double.IsInfinity(value))
                {
                    throw new ArgumentException();
                }
                _value = value;
            }
        }
        /// <summary>
        /// функция расчета импеданса
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public Complex GetImpedance(double frequency)
        {
            var impedance = new Complex(0.0, _value * frequency * 2 * Math.PI);
            return impedance;
        }
    }
}



















