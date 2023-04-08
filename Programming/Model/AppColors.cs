using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Статический класс для инициализации цветов.
    /// </summary>
    static class AppColors
    {
        public static Color correctAnswer = Color.White;
        public static Color wrongAnswer = Color.LightPink;
        public static Color springColor = ColorTranslator.FromHtml("#559c45");
        public static Color autumnColor = ColorTranslator.FromHtml("#e29c45");
    }
}
