using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> slovar = new Dictionary<string, string>();
            slovar.Add("подонок", "подонки");
            slovar.Add("ребенок", "дети");
            slovar.Add("бесенок", "бесенята");
            slovar.Add("опенок", "опята");
            slovar.Add("звонок", "звонки");
            slovar.Add("позвонок", "позвонки");
            slovar.Add("колонок", "колонки");
            slovar.Add("жаворонок", "жаворонки");
            slovar.Add("бочонок", "бочонки");
            Console.Write("Введите существительное оканчивающееся на -онок или -енок\n");
            string slovo=Convert.ToString(Console.ReadLine());
            string soglasniesh = "жшчщ";
            string soglasnie = "бвгдзйклмнпрстфхц";

            if (slovar.ContainsKey(slovo))
            {
                Console.Write("{0}", slovar[slovo]);
                goto exit;
            }

            for (int i = 0; i < soglasniesh.Length; i++)
            {
                if (soglasniesh[i] == slovo[slovo.Length - 5])
                {
                    slovo = slovo.Remove(slovo.Length - 4, 4);
                    slovo = slovo + "ата";
                    Console.WriteLine(slovo);
                    goto exit;
                }
            }

            for (int i = 0; i < soglasnie.Length; i++)
            {
                if (soglasnie[i] == slovo[slovo.Length - 5])
                {
                    slovo = slovo.Remove(slovo.Length - 4, 4);
                    slovo = slovo + "ята";
                    Console.WriteLine(slovo);
                    goto exit;
                }
            }

            Console.Write("Неправильно введено слово");
            exit:Console.ReadLine();
        }
    }
}
