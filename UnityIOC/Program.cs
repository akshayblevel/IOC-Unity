using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            IRechargeHandler rHandler = DependencyResolver.LoadDependency<IRechargeHandler>();
            rHandler.DoRecharge();
            Console.ReadLine();
        }
    }
}
