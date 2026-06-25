using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class Room
    {
        public String Name {  get; set; }
        public String Email { get; set; }
        public int NumRoom { get; set; }

        public override string ToString()
        {
            return Name + " " +
                   Email + " " + 
                   NumRoom ;
        }
        
    }
}
