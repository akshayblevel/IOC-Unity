using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Unity;

namespace UnityIOC
{
    public class DependencyResolver
    {
        public static IUnityContainer Container
        {
            get;
            set;
        }

        private static readonly object obj = new Object();
        private DependencyResolver()
        {
        }

        private static void GetContainer()
        {
            if (Container == null)
                lock (obj)
                {
                    Container = new UnityContainer();
                    Container.LoadConfiguration();
                }
        }

        public static T LoadDependency<T>()
        {
            GetContainer();
            return Container.Resolve<T>();
        }
    }
}
