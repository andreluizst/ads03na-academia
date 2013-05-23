using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FACliente
{
    public class ComboBoxItemEx
    {


        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string displayValue;

        public string DisplayValue
        {
            get { return displayValue; }
            set { displayValue = value; }
        }

        public ComboBoxItemEx()
        {
        }

        public ComboBoxItemEx(int id, string displayValue)
        {
            this.id = id;
            this.displayValue = displayValue;
        }

        public override string ToString()
        {
            return displayValue;
        }
    }
}
