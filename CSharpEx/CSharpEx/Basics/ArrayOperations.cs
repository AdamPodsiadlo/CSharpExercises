using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Basics
{
    class ArrayOperations
    {
        public ArrayOperations(int[] array)
        {
            this.Array = array;
        }

        public int[] Array { get; set; }

        public string Print()
        {
            var string1 = new StringBuilder();
            for (int i = 0; i < Array.Length; i++)
            {
                string1.Append($"{Array[i]} ");
            }

            return string1.ToString().Trim();
        }


        public int Min()
        {
            int result = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (result > Array[i])
                {
                    result = Array[i];
                }

            }

            return result;
        }

        public int Max()
        {
            int result = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (result < Array[i])
                {
                    result = Array[i];
                }
            }

            return result;
        }


        public int[] Reversed()
        {
            var tab = new int[Array.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                int index = Array.Length - 1;
                index = index - i;
                tab[i] = Array[index];
                
            }

            return tab;
        }

        public int EvenCount()
        {
            int result = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    result = result + 1;
                }
                    
            }

            return result;
        }

        public int[] Add(int add)
        {
            var tab = new int[Array.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                tab[i] = Array[i] + add;
              
            }

            return tab;
        }

        public int Sum()

        {

            int result = 0;
            
            for (int i = 0; i < Array.Length; i++)
            {
                result = result + Array[i];
                
            }

            return result;

        }

        public int[] Copy()
        {
            int[] result = new int[Array.Length];
            for (int i = 0; i < Array.Length; i++)
            {

                result[i] = Array[i];


            }

            return result;
        }
    }
}
