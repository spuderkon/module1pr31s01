using System;


    public class Programer
    {
        public string Lastname;
        public int numprogram;
        public int numlang;
        public int genqua;
        public int quality(int numprogram, int numlang)
        {
            Console.WriteLine("Программист написал - {0} программ(у) \nПри этом он знает - {1} язык(ов)", numprogram, numlang);
            return genqua = numprogram * numlang;
        }

        public void information(string Lastname, int numprogram, int numlang)
        {
            Console.WriteLine("Ваша фамилия: {0}\nЧисло написанных Вами программ: {1}\nВы знаете {2} язык(ов)", Lastname, numprogram, numlang);
        }
    }

    public class tyly : Programer
    {
        public int workprog;

        public int quanprog(int genqua, int workprog)
        {
            return genqua * workprog;
        }

    }

