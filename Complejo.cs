using System;

namespace FormComplejosG2_2024_1
{
    internal class Complejo
    {
        private float real;
        private float imaginaria;

        public Complejo(float real, float imaginaria)
        {
            this.real = real;
            this.imaginaria = imaginaria;
        }
        public static Complejo operator +(Complejo c1, Complejo c2)
        {
            //Complejo c3 = new Complejo(c1.real + c2.real, c1.imaginaria + c2.imaginaria);
            //return c3;
            return new Complejo(c1.real + c2.real, c1.imaginaria + c2.imaginaria);
        }
        public static Complejo operator -(Complejo c1, Complejo c2)
        {
            return new Complejo(c1.real - c2.real, c1.imaginaria - c2.imaginaria);
        }
        public static Complejo operator *(Complejo c1, Complejo c2)
        {
            return new Complejo(c1.real * c2.real + c1.imaginaria * c2.imaginaria * -1, c1.imaginaria * c2.real + c1.real * c2.imaginaria);
        }
        public static Complejo operator ~(Complejo c)
        {
            return new Complejo(c.real, -c.imaginaria);
        }
        public override string ToString()
        {
            if (imaginaria>=0)
                return String.Format(" {0}+{1}i", real, imaginaria);
            else
                return String.Format(" {0}{1}i", real, imaginaria);
        }
    }
}