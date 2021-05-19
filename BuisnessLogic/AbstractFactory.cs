using System;

namespace AbstractFactory
{
    abstract class AbstractRatedObjectFactory
    {
        public abstract AbstractObject CreateObject();
        public abstract AbstractCreator CreateCreator();
    }
    class StudentCreatedObjects : AbstractRatedObjectFactory
    {
        public override AbstractObject CreateObject()
        {
            return new SomeEvent();
        }

        public override AbstractCreator CreateCreator()
        {
            return new Student();
        }
    }
    class TeacherCreatedObjects : AbstractRatedObjectFactory
    {
        public override AbstractObject CreateObject()
        {
            return new Lecture();
        }

        public override AbstractCreator CreateCreator()
        {
            return new Teacher();
        }
    }

    abstract class AbstractCreator
    {
        int id;
        string name;

        public abstract void GetCreator();
    }

    abstract class AbstractObject
    {
        int id;
        string title;

        public abstract void GetObject();
    }

    class Student : AbstractCreator
    {
        public override void GetCreator()
        {
            System.Console.Write("Student created activity: ");
        }
    }

    class Teacher : AbstractCreator
    {
        public override void GetCreator()
        {
            System.Console.Write("Teacher created activity: ");
        }
    }

    class Lecture : AbstractObject
    {
        public override void GetObject()
        {
            System.Console.WriteLine("Lecture");
        }
    }

    class SomeEvent : AbstractObject
    {
        public override void GetObject()
        {
            System.Console.WriteLine("Some event");
        }
    }

    class Resource
    {
        private AbstractObject objectToByRated;
        private AbstractCreator creator;

        public Resource(AbstractRatedObjectFactory factory)
        {
            objectToByRated = factory.CreateObject();
            creator = factory.CreateCreator();
        }
        public void GetInfo()
        {
            creator.GetCreator();
            objectToByRated.GetObject();
        }
    }
}