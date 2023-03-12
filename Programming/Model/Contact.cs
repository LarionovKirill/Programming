using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Contact
    {
        private int Number;
        private String Name;
        private String Surename;

        public int number
        {
            set 
            {
                try
                {
                    Number = Convert.ToInt32(value);
                }
                catch 
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Number;
            }
        }
        public String name 
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
            }
        }
        public String surename 
        {
            set
            {
                Surename = value;
            }
            get
            {
                return Surename;
            }
        }

        public Contact()
        {
            
        }

        public Contact(int Number, String Name, String Surename)
        {
            this.name = Name;
            this.number = Number;
            this.surename = Surename;
        }
    }
}
