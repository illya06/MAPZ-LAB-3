using System;

namespace Builder_
{
    class Person
    {
        private string Status, FullName, Group;

        public Person()
        {
            Status = string.Empty;
            FullName = string.Empty;
            Group = string.Empty;
        }

        public void GetInfo()
        {
            System.Console.Write($"{Status} | {FullName} | {Group}");
        }

        public void SetStatus(string Status)
        {
            this.Status = Status;
        }

        public void SetFullName(string FullName)
        {
            this.FullName = FullName;
        }

        public void SetGroup(string Group)
        {
            this.Group = Group;
        }
    }

    abstract class Builder
    {
        public abstract void CreatePerson();

        public abstract void BuildPart1(string part);
        public abstract void BuildPart2(string part);
        public abstract void BuildPart3(string part);

        public abstract Person GetPerson();
    }

    class PersonBuilder : Builder
    {
        private Person currentBuilder;

        public override void CreatePerson()
        {
            currentBuilder = new Person();
        }

        public override void BuildPart1(string part)
        {
            currentBuilder.SetStatus(part);
        }

        public override void BuildPart2(string part)
        {
            currentBuilder.SetFullName(part);
        }

        public override void BuildPart3(string part)
        {
            currentBuilder.SetGroup(part);
        }

        public override Person GetPerson()
        {
            return currentBuilder;
        }
    }

    class Director
    {
        private Builder builder;

        public Director(Builder _builder)
        {
            builder = _builder;
        }

        public void Construct(string[] credentials)
        {
            builder.CreatePerson();
            builder.BuildPart1(credentials[0]);
            builder.BuildPart2(credentials[1]);
            builder.BuildPart3(credentials[2]);
        }
    }
}