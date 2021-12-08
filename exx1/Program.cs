using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exx1
{
   

    internal class Program
    {
        static void Main(string[] args)
        {
            tyly rt = new tyly();           
            try
            {
                Console.WriteLine("Введите Вашу фамилию:");
                rt.Lastname = Console.ReadLine();
                Console.WriteLine("Сколько прорамм Вы написали?");
                rt.numprogram = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сколько языков Вы знаете?");
                rt.numlang = Convert.ToInt32(Console.ReadLine());
                rt.information(rt.Lastname, rt.numprogram, rt.numlang);
                int forcons = rt.quality(rt.numprogram, rt.numlang);
                Console.WriteLine("Качество объекта - {0}", forcons);
                Console.WriteLine("Сколько программ работают правильно?");
                rt.workprog = Convert.ToInt32(Console.ReadLine());
                int ert = rt.quanprog(forcons, rt.workprog, rt.numprogram);
                Console.WriteLine("Число всех программ: {0}", ert);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
