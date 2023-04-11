using System;

abstract class IBaseClass
        {
            public abstract void Print();
            public abstract IBaseClass Clone();
        }

        class DerivedOne : IBaseClass
        {
            public override void Print()
            {
                Console.WriteLine("Derived class one");
            }

            public override IBaseClass Clone()
            {
                return new DerivedOne();
            }
        }

        class DerivedTwo : IBaseClass
        {
            public override void Print()
            {
                Console.WriteLine("Derived class two");
            }

            public override IBaseClass Clone()
            {
                return new DerivedTwo();
            }
        }

        class Factory
        {
            public static IBaseClass GetObject()
            {
                Random random = new Random();
                if (random.Next(2) == 0)
                    return new DerivedOne();
                else
                    return new DerivedTwo();
            }
        }