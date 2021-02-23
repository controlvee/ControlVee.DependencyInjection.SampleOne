using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIandJquery
{
    /// <summary>
    /// How ae the non-public interfaces being called?
    /// </summary>
    public interface ITest
    {
        string Data { get; }
    }

    public interface ISingleton : ITest
    {
    }
    
    public interface IScoped : ITest
    {
    }

    public interface ITransient : ITest
    {
    }

    public class Test : ITest, IScoped, ITransient, ISingleton
    {
        static int count = 1;

        int _count;
        string _data;
        DateTime _now;

        public string Data
        {
            get
            {
                return $"{_count} of {count} > {_data} at ";
            }
            set
            {
                _data = value;
            }
        }

        public Test()
        {
            _data = "Default";
            _count = count++;
            _now = DateTime.Now;

            System.Threading.Thread.Sleep(1500);
        }

        public Test(string data)
        {
            _data = data;
            _count = count++;
            _now = DateTime.Now;

            System.Threading.Thread.Sleep(1500);
        }
    }
}
