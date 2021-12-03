using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task15
{
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public int startValue;
        public int x;

        public void setStart(int x)
        {
            this.startValue = x;
            this.x = x;
        }

        public int getNext()
        {
            this.x += 10;
            return this.x;
        }

        public void reset()
        {
            this.x = this.startValue;
        }

    }
    class GeomProgression : ISeries
    {
        public int startValue;
        public int x;

        public void setStart(int x)
        {
            this.startValue = x;
            this.x = x;
        }

        public int getNext()
        {
            this.x *= 2;
            return this.x;
        }

        public void reset()
        {
            this.x = this.startValue;
        }

    }

    internal class Program
    {
        static void Main()
        {
            int x = 0;

            ArithProgression ap = new ArithProgression();
            GeomProgression gp = new GeomProgression();

            Console.WriteLine("Арифметическая  прогрессия ");
            ap.setStart(1);
            for (int i = 0; i < 10; i++)
            {
                x = ap.getNext();
                Console.WriteLine(x);
            }
            ap.reset();

            Console.WriteLine("Геометрическая прогрессия ");
            gp.setStart(1);
            for (int i = 0; i < 10; i++)
            {
                x = gp.getNext();
                Console.WriteLine(x);
            }
            gp.reset();

            Console.ReadKey();
        }
    }
}
