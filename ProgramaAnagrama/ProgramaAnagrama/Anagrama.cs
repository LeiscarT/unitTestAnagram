using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaAnagrama
{
    public class Anagrama
    {
        public string sort(string cadena) 
        {
            char[] array = cadena.ToCharArray();
            Array.Sort(array);
            return new string(array);

        }
        
        public bool AreAnagram(string uno, string dos)
        {
            if (uno is null || dos is null)
            {
                throw new ArgumentNullException();
            }

            string ordenado1 = sort(uno);
            string ordenado2 = sort(dos);

            if (ordenado1.Equals(ordenado2))
            {
                return true;
            }
            else
            {
                return false;
            }




            
        }
    }
}
