using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Model
{/// <summary>
/// 
/// </summary>
    public class Inductor : IElement
    {   /// <summary>
        /// объявление значения и частоты
        /// </summary>
        private double _value;
        

        /// <summary>
        /// описание свойста имени
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
        /// описание функции расчета импеданса
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public Complex GetImpedance(double frequency)
        {
            var impedance = new Complex(0.0, -1/_value * frequency * 2 * Math.PI);
            return impedance;
        }
    }
}