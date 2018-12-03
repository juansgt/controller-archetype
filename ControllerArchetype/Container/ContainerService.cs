using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Container
{
    public sealed class ContainerService
    {
        private static readonly Lazy<ContainerService> lazy = new Lazy<ContainerService>(() => new ContainerService());
        private IUnityContainer container;

        public static ContainerService Instance
        {
            get { return lazy.Value; }
        }

        private ContainerService()
        {
            container = new UnityContainer();
        }

        public IUnityContainer GetUnityContainer()
        {
            return container;
        }
    }
}
