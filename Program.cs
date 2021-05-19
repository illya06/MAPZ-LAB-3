using System;
using System.Collections.Generic;

using AbstractFactory;
using Singletone;
using Builder_;

namespace MAPZ_LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Builder B = new PersonBuilder();
            Director D = new Director(B);
            D.Construct(new string[] {"Antoniy Antonych", "Chad", "Heaven"});

            var person = B.GetPerson();

            System.Console.WriteLine("All this Events were made thanks to");
            person.GetInfo();

            List<Resource> res = new() //Factory created objects
            {
                new Resource(new StudentCreatedObjects()),
                new Resource(new StudentCreatedObjects()),
                new Resource(new TeacherCreatedObjects()),
                new Resource(new TeacherCreatedObjects())
            };

            var list = ResourcesSingleton.getInstance();

            list.AddData(res);
            list.GetData();
        }
    }
}
