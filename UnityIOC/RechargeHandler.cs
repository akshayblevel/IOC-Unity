using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIOC
{
    public class RechargeHandler : IRechargeHandler
    {
        public void DoRecharge()
        {
            Console.WriteLine("Recharge is done successfully.");
        }
    }
}
