using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathSite.Models
{
    public class UserName
    {
        private string name = "n/a";

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public override string ToString()
        {
            string aMessage = " ";
            aMessage = aMessage + " UserName: " + this.Name + "\n";
            return aMessage;
        }
    }
}