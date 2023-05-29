using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Services
{
    /// <summary>
    /// Класс помогает в передаче перечисления.
    /// </summary>
    static class EnumGetter
    {
        /// <summary>
        /// Метод создает словарь с ключем перечисления и значением строки.
        /// </summary>
        /// <returns>Готовый словарь.</returns>
        public static Dictionary<Model.DeliveryTime, string> GetDeliveryTime()
        {
            Dictionary<Model.DeliveryTime, string> dict = new Dictionary<Model.DeliveryTime, string>();
            var content = Enum.GetValues(typeof(Model.DeliveryTime));
            string[] time = {
                "9:00-11:00",
                "11:00-13:00",
                "13:00-15:00",
                "15:00-17:00",
                "17:00-19:00",
                "19:00-21:00",
                "21:00-23:00" };
            int index = 0;
            foreach (var item in content)
            {
                dict.Add((Model.DeliveryTime)item, time[index]);
                index++;
            }
            return dict;
        }
    }
}
