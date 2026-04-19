using ETCS.DependencyInjection;
using ETCS.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCS // 1294701 - NAkibul Islam Fahim - E-Toll Collection System
{
    public class Program
    {
        static void Main(string[] args)
        {
            IRepoFactory repoFactory = new RepoFactory();
            DependencyClass dependencyClass = new DependencyClass(repoFactory);
            dependencyClass.startUp();

            Console.ReadKey();
        }
    }
}
