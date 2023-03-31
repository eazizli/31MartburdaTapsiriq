using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TapsMetod
{
    internal class Fronted : Developer
    {
        public int ReactExperienceYear;
        public Fronted()
        {

        }
        public Fronted(string Name):this()
        {

        }
        
        public Fronted(string Name,string Surname):this(Name)
        {

        }
        public Fronted(string Name, string Surname,byte Age):this(Name,Surname)
        {

        }
        public Fronted(string Name, string Surname, byte Age,byte Experience):this(Name,Surname,Age)
        {

        }
        public Fronted (string Name, string Surname, byte Age, byte Experience,int ReactExperienceYear) :this(Name,Surname,Age,Experience)
        {
           this. ReactExperienceYear = ReactExperienceYear; 
        }
        

        
    }
    
    
    

    

}
