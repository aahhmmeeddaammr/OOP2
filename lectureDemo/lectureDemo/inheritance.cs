using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectureDemo
{
    internal class Parent
    {
        protected int x { get; set; }
        private protected int y { get; set; }

        public Parent(int X, int Y)
        {
            x = X; y = Y;
        }
        public Parent(int X) : this(X, X) { }
        public Parent() : this(0) { }

        public int product()
        {
            return x * y;
        }

        public override string ToString()
        {
            return $"{x} , {y}";
        }
    }

    class Child : Parent
    {
        public int z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        new public int product()
        {
            return z * base.product();
        }

        public override string ToString()
        {
            return base.ToString() + $",{z}";
        }
    }
}
