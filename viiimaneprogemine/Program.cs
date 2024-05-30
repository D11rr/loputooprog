using System.IO.Pipes;

namespace viiimaneprogemine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("see on minu lõputöö, palun andke 5!");

            string ch = Console.ReadLine();

            switch (ch)
            {
                case "1":
                    ReaderAndWriter();
                    break;
                case "2":
                    numpüramiid();
                    break;
                case "3":
                    GroupByLINQ();
                    break;
                case "4":
                    FirstOrDefault();
                    break;
                default:
                    Console.WriteLine("pane õige number");
                    break;
            }
        }
        static void ReaderAndWriter()
        {
            Console.WriteLine("kirjuta yes et kirjutada faili ja no et mitte kirjutada");
            string p = "yes";
            string s = "no";
            string ps = Console.ReadLine();
            try
            {
                if (ps == p)
                {

                    Console.WriteLine("Kirjuta faili läbi konsooli");

                    string filePath = @"C:/Kasutajad/opilane/Desktop/WriteToFile.txt";
                    string inputText = Console.ReadLine();

                    File.WriteAllText(filePath, inputText);

                }
                else
                {
                    Console.WriteLine("valisid no");

                }



            }
            catch (Exception e)
            {
                Console.WriteLine("Mingi error");
                Console.WriteLine(e.Message);
            }
        }
        static void numpüramiid()
        {
            int i, j, rows;
            int t = 1;
            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 1 * i - 1; j++)
                {
                    Console.Write("{0} ", t++);
                    //Console.Write("*"); //kui paned selle, siis saad püramiidi
                }
                Console.Write("\n");
            }
        }
        static void GroupByLINQ()
        {
            //start
            var result = PeopleList.peoples
                .GroupBy(x => x.Age);

            foreach (var age in result)
            {
                Console.WriteLine("Age group " + age.Key);

                foreach (var p in age)
                {
                    Console.WriteLine("People name: " + p.Name);
                }
            }
        }
        public static void FirstOrDefault()
        {
            string firstLongName = PeopleList.peoples
                .FirstOrDefault(person => person.Name.Length > 3)?.Name;

            Console.WriteLine("The first long name is '{0}'.", firstLongName);
        }
    }
}
