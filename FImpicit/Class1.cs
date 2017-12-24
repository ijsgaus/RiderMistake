using System;
using Lib;

namespace FImpicit
{
    public class Test1
    {
        public Test1(int value)
        {
            Value = value;
        }

        public int Value { get; }
        
        public static implicit operator Test1(int v) => new Test1(v);
    }
    
    
    public class Class1
    {
        public static void Tester()
        {
            Test test = 5;
            Test1 t = 6;
        }
    }
}