﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    /// <summary>
    /// Перечисление, содержащее категории товаров.
    /// </summary>
    [Serializable]
    public enum ItemCategory
    {
        Clothes,
        Elictronics,
        Food,
        Sport,
        Auto,
        Child,
        Books
    }
}
