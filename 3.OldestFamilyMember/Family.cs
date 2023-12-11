using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {

        private List<Person> allFamilyMembers;

        public Family() 
        
        { 
        this.allFamilyMembers = new ();
        }

        public List<Person> AllFamilyMembers
           
    
        { 
            get 
            {
               return this.allFamilyMembers;
            } 
            set 
            { 
                this.allFamilyMembers = value; 
            }
        
        }

        

        public void AddMember(Person member) 
        
        { 
        allFamilyMembers.Add (member);
        }

        public Person GetOldestMember() 
        {
            return this.AllFamilyMembers.MaxBy(x => x.Age); 
        }

    }
}
