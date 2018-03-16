using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class Initiator
    {
        Business.IBusiness _businessClass;
        public Initiator(Business.IBusiness businessClass)
        {
            _businessClass = businessClass;            
        }
        public string FetchData()
        {
            return _businessClass.GetBusinessData();
        }
    }
}
