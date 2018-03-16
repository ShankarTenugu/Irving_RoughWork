using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;
using Unity.Lifetime;

namespace Presentation
{
    public static class DependencyInjector
    {
        private static readonly UnityContainer _unityContainer = new UnityContainer();

        public static void Register<I,T>() where T:I //?
        {
            _unityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
        }

        //public static void InjectStub<I>(I instance) //?
        //{
        //    _unityContainer.RegisterInstance(instance, new ContainerControlledLifetimeManager());
        //}

        public static T Retrieve<T>() //?
        {
            return _unityContainer.Resolve<T>();
        }

        //this is mainly for the dependency class 'Data'
        public static void AddExtension<T>() where T : UnityContainerExtension
        {
            _unityContainer.AddNewExtension<T>();
        }

    
    }
}
