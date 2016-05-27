using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample1_1.Models
{
    public class HelloPerson
    {
        public string Name { get; set; }
        private string _say;

        public string Say
        {
            get { return _say; }
            set { _say = value; }
        }




    }
}