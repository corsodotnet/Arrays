using System.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banca b = new Banca();
            Conto c1 = new Conto();
            c1.intestatario = "Bruno";
            Conto c2 = new Conto();
            c2.intestatario = "Marco";
            b.addConto(c1);
            b.addConto(c2);

        }
        static void DichiareArray()
        {

            int[] myArray = new int[4];
            myArray[3] = 1;

            string[] array = new string[4];
        }

        static void DichiaraEInizializza()
        {
            int[] mynumbers = new int[4] { 1, 2, 3, 4 };
            string[] cities = new string[4] { "Milano", "Roma", "Napoli", "Genova" };
        }

        static void ArrayConVar()
        {
            //var MyArray = new int[4] { 1, 2, 3, 4 };
            //int[] array = new int[5] {1,2};
            //var Array2 = {1,2};

        }
        static void InizializzaDopo()
        {
            const int n = 3;
            int[] myArray = new int[n]
            { 2, 4, 5 };

            for (int i = 0; i < myArray.Length; i++)
            {

            }

        }
        static public void LinqMethods()
        {
            int[] nums = new int[5] { 1, 2, 3, 4, 5 };

            nums.Max(); // return 5 
            nums.Min(); // return 1
            nums.Sum(); // totale 
            nums.Average(); //Media
        }


    }

    public class Banca
    {
        int arrLenght = 0;
        Conto[] conti = new Conto[5];
        public void addConto(Conto conto)
        {
            conti[arrLenght] = conto;
            arrLenght++;
        }
    }
    public class Conto
    {
        public string intestatario;
    }



}
