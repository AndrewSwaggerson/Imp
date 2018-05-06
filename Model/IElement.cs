using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Model
{
   /// <summary>
   /// описание интерфейса
   /// </summary>
    public interface IElement
    {

        string Name { get; set; }

        double Value { get; set; }

        Complex GetImpedance(double frequency);

    }
}
