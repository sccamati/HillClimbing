using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbing.classes
{
    class ToTxt
    {
        public static void WriteToFile(List<Individual> genList, int t, double d)
        {
            StreamWriter file = new StreamWriter("Plik1.txt");
            file.WriteLine($"Parametry T: {t} d: {d} \n");
            for (int i = 0; i < genList.Count; i++)
            {
                file.WriteLine("Pokolenie " + i + "\n");
                file.WriteLine("lp | VcReal | VcBin | f(VcReal)");
                file.WriteLine($"{i} | {genList[i].Xreal} | {genList[i].Xbit} | {genList[i].Fx}");
                file.WriteLine("\n");
            }
            file.Close();
        }
    }
}
