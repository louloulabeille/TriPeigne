using System;

namespace TriPeigne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabATrier = new int[] { 25,1,88,65,4,59,87,5,28,1,0 };
            TriPeigne(ref tabATrier );
            foreach (int value in tabATrier)
            {
                Console.WriteLine(value);
            }
        }
        /// <summary>
        /// trie a peigne ressemble au tri a bulle 
        /// mais on calcule un intervale à la place de prende occurance à coté pour 
        /// verifié s'il l'un est supérieur à l'autre 
        /// on prendre l'occurence qui se trouve Nboccurence totale/1.3
        /// </summary>
        /// <param name="tabAtri"></param>
        public static void TriPeigne( ref int[] tabAtri )
        {
            int intervale = tabAtri.Length;
            int nbTotal = tabAtri.Length;
            bool finTri = false;

            while ( intervale > 1 || finTri )
            {
                int tmp;
                intervale = (int)(intervale / 1.3);
                int nbTraite = nbTotal - intervale;
                finTri = false;
                
                for(int i = 0; i < nbTraite; i++ )
                {
                    if (tabAtri [i] > tabAtri [i+intervale] )
                    {
                        tmp = tabAtri[i];
                        tabAtri[i] = tabAtri[i+intervale];
                        tabAtri[i + intervale] = tmp;
                        finTri = true;
                    }
                }
            }
            


        }
    }
}
