using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_builder
{
    internal class Roll
    {
        private string rice;
        private string filling;
        private string topping;

        public void SetRice(string rice)
        {
            this.rice = rice;
        }

        public void SetFilling(string filling)
        {
            this.filling = filling;
        }

        public void SetTopping(string topping)
        {
            this.topping = topping;
        }

        public override string ToString()
        {
            return $"Roll {{ Rice: {rice}, Filling: {filling}, Topping: {topping} }}";
        }
    }
}

