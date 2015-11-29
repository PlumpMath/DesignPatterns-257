using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Tests;

namespace DesignPatterns.Classes
{
    public class Singleton
    {
        private static readonly Singleton _instance = new Singleton(); // lock handling is performed by .NET Framework

        public static Singleton Instance
        {
            get { return _instance; }
        }

        internal ConnectionData ConnectionData { get; set; } // Singleton can have it's internal state

        private  Singleton() {}

    }
}
