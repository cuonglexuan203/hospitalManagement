using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Salary
    {
        //Field
        private float basic;
        private float bonus;
        private float allowance;

        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        public float Basic { get => basic; set => basic = value; }
        public float Bonus { get => bonus; set => bonus = value; }
        public float Allowance { get => allowance; set => allowance = value; }
        // Constructors
        public Salary() { }
        public Salary(float basic, float bonus, float allowance)
        {
            this.basic = basic;
            this.bonus = bonus;
            this.allowance = allowance;
        }

        // Destructors
        ~Salary()
        {
        }
        // Methods
        // in, output
        public void Input()
        {
            Console.Write("Basic: ");
            Basic = float.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            Bonus = float.Parse(Console.ReadLine());
            Console.Write("Allowance: ");
            Allowance = float.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Basic: {0}", Basic);
            Console.WriteLine("Bonus: {0}", Bonus);
            Console.WriteLine("Allowance: {0}", Allowance);
        }
        // General method
        // Other method
        // Overriding
        public override string ToString()
        => $"\nThe basic: {basic}" +
            $"\nThe bonus: {bonus}" +
            $"\nThe allowance: {allowance}";
    }
}
