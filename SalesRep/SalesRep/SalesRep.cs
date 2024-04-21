using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesRep
{
    public class SalesRep
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string TelNo { get; set; }   
        public string Gender { get; set; }
       public string Team { get; set; }

        

        public SalesRep( int ID, String Name, string LastName, string TelNo, string Gender, string Team )
        {
            this.ID = ID;
            this.Name = Name;
            this.LastName = LastName;
            this.TelNo = TelNo;
            this.Gender = Gender;
            this.Team = Team;
            
            
        }
        
    }
    
   
}
