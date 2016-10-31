using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    #region Basic Singleton
    class Singleton
    {
        private static Singleton _instance;

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }

    class SingletonChecker
    {
        public static void Run()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            
            if(s1 == s2)
            {
                Console.WriteLine("Object are of the same instance");
            }

            Console.ReadKey();
        }
    }
    #endregion

    #region Static Initialization
    class SingletonTwo
    {
        private static readonly SingletonTwo _instance = new SingletonTwo();

        private SingletonTwo()
        {
        }

        public static SingletonTwo Instance
        {
            get
            {
                return _instance;
            }
        }
    }
    

    class SingletonTwoChecker
    {
        public static void Run()
        {
            SingletonTwo singletonObject1 = SingletonTwo.Instance;
            SingletonTwo singletonObject2 = SingletonTwo.Instance;

            if(singletonObject1 == singletonObject2)
            {
                Console.WriteLine("Objects are the same, again :))");
            }

            Console.ReadKey();
        }
    }
    #endregion
}
