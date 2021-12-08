using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exx1
{
    public class Programer
    {
        public string Lastname;
        public int numprogram;
        public int numlang;
        public int genqual;
        public int quality(int numprogram, int numlang)
        {
            return genqual = numprogram * numlang;
        }

        public void information(string Lastname, int numprogram, int numlang)
        {
            Console.WriteLine("Ваша фамилия: {0}\nЧисло написанных Вами программ: {1}\nВы знаете {2} языка(ов)", Lastname, numprogram, numlang);
        }
    }

    public class tyly : Programer
    {
        public int workprog;

        public int quanprog(int genqua, int workprog, int numprogram)
        {
            return genqua * workprog / numprogram;
        }

    }
}
