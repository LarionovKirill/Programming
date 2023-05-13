using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    /// <summary>
    /// Время доставки.
    /// </summary>
    [Serializable]
    public enum DeliveryTime
    {
        Between9And11,
        Between11And13,
        Between13And15,
        Between15And17,
        Between17And19,
        Between19And21,
        Between21And23
    }
}
