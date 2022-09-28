using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
    class DHaromszog
    {
        private double aOldal;

        public double a
        {
            get { return aOldal; }
            set
            {
                if (value > 0)
                {
                    aOldal = value;
                }
                else
                {
                    throw new Exception("Az 'a' oldal nem lehet nulla vagy negatív!");
                }
            }
        }

        private double bOldal;

        public double b
        {
            get { return bOldal; }
            set
            {
                if (value > 0)
                {
                    bOldal = value;
                }
                else
                {
                    throw new Exception("Az 'b' oldal nem lehet nulla vagy negatív!");
                }
            }
        }

        private double cOldal;

        public double c
        {
            get { return cOldal; }
            set
            {
                if (value > 0)
                {
                    cOldal = value;
                }
                else
                {
                    throw new Exception("Az 'c' oldal nem lehet nulla vagy negatív!");
                }
            }
        }

        private bool EllDerekszogu
        {
            get
            {
                if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    return true;
                }
                else
                {
                    throw new Exception("A háromszög nem derékszögű!");
                }
            }
        }

        private bool EllMegszerkesztheto
        {
            get
            {
                if (a + b > c)
                {
                    return true;
                }
                else
                {
                    throw new Exception("A háromszöget nem lehet megszerkeszteni!");
                }
            }
        }

        private bool EllNovekvoSorrend
        {
            get
            {
                if (a <= b && b <= c)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Az adatok nincsenek növekvő rendben!");
                }
            }
        }

        public double Kerulet
        {
            get
            {
                return (a + b + c);
            }

        }

        public int SorSzama { get; set; }

        public double Terulet
        {
            get
            {
                return (a * b / 2);
            }

        }

        public DHaromszog(string sor, int sorSzama)
        {
            string[] tmp = sor.Split(' ');
            a = Convert.ToDouble(tmp[0]);
            b = Convert.ToDouble(tmp[1]);
            c = Convert.ToDouble(tmp[2]);

            SorSzama = sorSzama;

            if (EllNovekvoSorrend && EllMegszerkesztheto && EllDerekszogu) ;
        }

        public override string ToString()
        {
            return $"{SorSzama}. sor: a={a} b={b} c={c}";
        }
    }
}
