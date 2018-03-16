using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    interface IFileLog
    {
        string writeLog();
    }

    interface IDataBaseLog
    {
        string writeLog();
    }

    class MyLogClass:IFileLog,IDataBaseLog
    {
        public string writeLog() //it should have 'public' access specifier
        {
            return "I am logger method";
        }

        string IFileLog.writeLog()
        {
            return "I am logger method from IFileLog";
        }

        string IDataBaseLog.writeLog()
        {
            return "I am logger method from IDataBaseLog";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyLogClass _log = new MyLogClass();
            IFileLog _logF = new MyLogClass();
            IDataBaseLog _logD = new MyLogClass();

            Console.WriteLine("Logger File from object" + _log.writeLog());
            Console.WriteLine("Logger File from object" + _logF.writeLog());
            Console.WriteLine("Logger File from object" + _logD.writeLog());

            Console.ReadLine();


        }
    }
}
