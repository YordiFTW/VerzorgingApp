using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzorgingApp.Shared
{
   public class Caretaker : Person
    {

        //public ICollection<Supervisor> Supervisor { get; set; }
        public List<Elder> Elders { get; set; }
    }
}
