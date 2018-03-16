using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class BusinessClass:IBusiness
    {
        IData _dataClass;
        public BusinessClass(IData dataClass)
        {
            _dataClass = dataClass;
        }

        public string GetBusinessData()
        {
            return _dataClass.GetData();
        }
    }
}
