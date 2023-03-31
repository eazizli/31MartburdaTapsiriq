using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapsMetod
{
    internal class Backend :Developer
    {

        public int SqlExperienceYear;

        public Backend()
        {

        }
        public Backend(string Name):this()
        {
            this.Name = Name;
        }
        public Backend(string Name,string Surname) :this(Name)
        {
            this.Surname = Surname; 
        }
        public Backend(string Name, string Surname,byte Age) :this(Name, Surname)
        {
            this.Age = Age;
        }



        public Backend(string Name, string Surname, byte Age, byte Experience) : this(Name, Surname, Age)
        { 
            
            this.Experince= Experience;
        }
            
    }
    
}
