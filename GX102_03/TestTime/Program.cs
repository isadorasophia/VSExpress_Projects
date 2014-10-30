using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTime
{
    // O que define classes "fazerem parte do mesmo assembly?"
    // O que define quais namespaces eu posso acessar no meu programa? - pode acessar fora do assembly...
    struct Time
    {
        private readonly int minutes;
        private readonly int hours;

        public int Minute { get { return this.minutes; } }
        public int Hour { get { return this.hours; } }

        //Constructor - cant create a noon Time struct... "qualify it with a type name instead"
        public Time(int hh, int mm)
        {
            this.hours = hh + mm/60;
            this.minutes = mm % 60;
        }

        public override String ToString()
        {
            return String.Format("{0:00}:{1:00}", this.Hour, this.Minute);
        }

        public static Time operator +(Time t1, Time t2)
        {
             return new Time(t1.Hour + t2.Hour, t1.Minute + t2.Minute);
        }

        public static Time operator -(Time t1, Time t2)
        {
            return new Time(t1.Hour - t2.Hour, t1.Minute - t2.Minute);
        }

        public static implicit operator Time(int minutes)
        {
            return new Time(0, minutes);
        }

        public static explicit operator int(Time time)
        {
            return time.Hour * 60 + time.Minute;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(9, 30);
            Time t2 = t1;

            //t1.minutes = 100;
            Console.WriteLine("t1={0} and t2={1}", t1, t2);

            //If it is a struct, I receive 9:100 and 9:30
            //If it is a class, I receive 9:100 and 9:100 - t2 becomes a pointer to t1, and if I modify t1, it modifies t2

            // Finaliza o programa
            Console.ReadKey();
        }
    }
}
