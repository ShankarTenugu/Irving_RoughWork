using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;
using Data;

namespace Business
{
    public class DependencyOfDependencyExtension:UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IData, DataClass>();
        }
    }
}
