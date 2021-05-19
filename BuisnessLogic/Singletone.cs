using System.Collections.Generic;
using System;

using AbstractFactory;

namespace Singletone
{
    class ResourcesSingleton
    {
        private static ResourcesSingleton instance;

        List<Resource> Resources = new();

        private ResourcesSingleton()
        {
            System.Console.WriteLine("\nDownloading a resource list...\n");
        }

        public static ResourcesSingleton getInstance()
        {
            if (instance == null)
                instance = new ResourcesSingleton();
            return instance;
        }

        public void GetData()
        {
            System.Console.WriteLine("\n\nLIST OF THINGS\n");
            int i = 0;
            foreach (var item in Resources)
            {
                System.Console.Write($"\n {++i} : ");
                item.GetInfo();
            }
        }

        public void AddData(Resource res)
        {
            Resources.Add(res);
        }

        public void AddData(List<Resource> res)
        {
            Resources.AddRange(res);
        }
    }
}
