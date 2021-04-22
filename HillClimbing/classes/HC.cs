using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbing.classes
{
    public class HC
    {
        //oblicz Int z Real
        public static void IntFromReal(Individual individual, double a, double b, double l)
        {
            individual.Xint = (int)Math.Round(((1 / (b - a)) * (individual.Xreal - a) * (Math.Pow(2, l) - 1)));
        }

        //oblicz Int z Bit
        public static void IntFromXbit(Individual individual)
        {
            individual.Xint = int.Parse(Convert.ToString(Convert.ToInt32(individual.Xbit + "", 2), 10));
        }

        public static void RealFromInt(Individual individual, double a, double b, double l, int round)
        {
            individual.Xreal = Math.Round(a + ((b - a) * individual.Xint) / (Math.Pow(2, l) - 1), round);
        }

        public static void BinFromInt(Individual individual, double l)
        {
            string bin = Convert.ToString(individual.Xint, 2);
            for (int k = bin.Length; k < l; k++)
            {
                bin = "0" + bin;
            }
            individual.Xbit = bin;
        }

        public static void CountFx(Individual individual)
        {
            double x = individual.Xreal;
            individual.Fx = x % 1 * (Math.Cos(20 * Math.PI * x) - Math.Sin(x));
        }

        public static Individual MakeFirstInd(double a, double b, double d, double l, Random generator)
        {
            Individual individual = new Individual
            {
                Id = 0,
                Xreal = generator.Next((int)(a / d), (int)(b / d)) * d
            };


            IntFromReal(individual, a, b, l);
            BinFromInt(individual, l);
            CountFx(individual);

            return individual;
        }

        public static Individual MakeVn(Individual individual, double a, double b, double l, int round)
        {
            List<Individual> individuals = new List<Individual>();
            StringBuilder XbitP = new StringBuilder(individual.Xbit);
            StringBuilder newXbit;
            for (int i = 0; i < individual.Xbit.Length; i++)
            {
                newXbit = XbitP;
                newXbit[i] = newXbit[i].Equals('0') ? '1' : '0';
                Individual newInd = new Individual
                {
                    Id = i,
                    Xbit = newXbit.ToString()
                };

                IntFromXbit(newInd);
                RealFromInt(newInd, a, b, l, round);
                CountFx(newInd);

                individuals.Add(newInd);
            }

            individuals.Sort(delegate (Individual x, Individual y)
            {
                return y.Fx.CompareTo(x.Fx);
            });


            return individuals.First();
        }
    }
}
