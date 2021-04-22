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
        public static void WriteToFile(List<List<Individual>> genList, int t, double d)
        {
            StreamWriter file = new StreamWriter("Plik1.txt");
            file.WriteLine($"Parametry T: {t} d: {d} \n");
            for (int i = 0; i < genList.Count; i++)
            {
                file.WriteLine("Iteracja " + i + "\n");
                file.WriteLine("lp| VcReal | VcBin         | f(VcReal)");
                for (int j = 0; j < genList[i].Count; j++)
                {
                    file.WriteLine($"{j} | {genList[i][j].Xreal} | {genList[i][j].Xbit} | {genList[i][j].Fx}");
                }
                file.WriteLine("\n");
            }
            file.Close();
        }
    }
}
