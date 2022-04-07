using System;
using System.Linq;

namespace ArrayFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elimina();
        }
        static void FindItem()
        {
            string[] items = { "bruno", "marco", "Elena", "Fabio" };

            var result = Array.Find(items, element => element.Equals("bruno"));

        }
        static void startsWithB()
        {
            string[] items = { "BrunoFerreira", "Bruno2", "Elena", "Fabio" };
            var result = Array.Find(items, element => element.StartsWith("Bruno"));
        }

        static void FindBylength()
        {

            string[] items = { "BrunoFerreira", "Ada", "Elena", "Fabio", null };
            var result = Array.Find(items, element => (element.Length == 3) && element != null);
        }

        /// <summary>
        /// FIND ALL
        /// </summary>
        static void FindValues()
        {
            string[] items = { "BrunoFerreira", "Ada", "Ema", "Elena", "Fabio" };
            var result = Array.FindAll(items, element => (element.Length == 3) && element != null);
        }
        static void FindValuesstartWith()
        {
            string[] items = { "BrunoFerreira", "Eda", "Ema", "Elena", "Fabio" };
            var result = Array.FindAll(items, element => element.StartsWith("E"));
        }

        /// <summary>
        /// FIND LAST
        /// </summary>
        static void FindLastValuesstartWith()
        {
            string[] items = { "BrunoFerreira", "Eda", "Ema", "Elena", "Fabio" };
            var result = Array.FindLast(items, element => element.Contains("E"));
        }

        static void Elimina()
        {
            Conto[] conti = new Conto[10];
            conti[0] = new Conto { name = "Bruno" };
            conti[1] = new Conto { name = "Marco" };

            Conto[] result = conti.Where(i => i != null && !i.name.Equals("Bruno")).ToArray();

            conti = CopyArray(conti, result);
        }
        public static Conto[] CopyArray(Conto[] src, Conto[] dest)
        {
            var newArray = new Conto[src.Length];
            for (int i = 0; i < dest.Length; i++)
            {
                newArray[i] = dest[i];
            }
            return newArray;
        }
    }

    public class Conto
    {
        public string name;
    }


}
