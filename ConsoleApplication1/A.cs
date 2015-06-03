using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    public abstract class A
    {
        public abstract void add(A newA);

        public abstract A getIndex(int index);

        public abstract void getInfor();
       
    }
    public class B : A
    {
        ArrayList list = new ArrayList();
        string name;
        public B(string name)
        {
            this.name = name;
        }
        public override void add(A newA)
        {
            list.Add(newA);
        }
        public override A getIndex(int index)
        {
            return (A)list[index];
        }
    }
}
