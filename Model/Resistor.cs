using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Resistor : IElement
    {
        /// <summary>
        /// объявление значения
        /// </summary>
        private double _value;

        /// <summary>
        /// описание свойства имени
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// описание свойства значения
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
        /// описание функции импеданс
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public Complex GetImpedance(double frequency)
        {
            var impedance = new Complex(_value, 0.0);
            return impedance;
        }
     }
}
