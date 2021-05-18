using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaAnagrama
{
    public class Anagrama
    {
        public bool AreAnagram(string uno, string dos)
        {
            if (uno is null || dos is null)
            {
                throw new ArgumentNullException();
            }

            return true;
        }
    }
}
