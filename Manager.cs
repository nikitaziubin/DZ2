

using System;

namespace DZ2
{
    internal class Manager : Worker
    {
        private Random rnd = new Random();
           
        public Manager(string name) : base(name)
        {
            position = "Manager";            
        }
        public override void FillWorkDay()
        {
            int random = rnd.Next(1, 10);
            for (int i = 0; i < random; i++)
            {
                Call();
            }
            Relax();
            random = rnd.Next(1, 5);
            for (int i = 0; i < random; i++)
            {
                Call();
            }
        }

    }
}
