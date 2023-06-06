using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model.Enums
{
    /// <summary>
    /// Перечисление хранит состояния заказа.
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
