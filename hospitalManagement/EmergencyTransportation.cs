using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal abstract class EmergencyTransportation : MovementEquipment
    {
        public enum DangerousLevel
        {
            Minor,
            Moderate,
            Considerable,
            High,
            VeryHigh
        }
        //Field
        private DangerousLevel level;
        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        public DangerousLevel Level
        {
            get => level; set => level = value;
        }
        // Constructors
        public EmergencyTransportation() { }
        public EmergencyTransportation(

             string id
            , string name
            , string description
            , float price
            , bool state
            , string origin
            , int quantity
            , int numberOfSeat
            , string destination
            , DangerousLevel level
            ) : base(id, name, description, price, state, origin, quantity, numberOfSeat, destination)
        {
            this.Level = level;
        }
        // Destructors
        ~EmergencyTransportation() { }
        // Methods
        // in, output
        public override void Input()
        {
            base.Input();
            Console.Write("Dangerous level ( 0.Minor, 1.Moderate, 2.Considerable, 3.High, 4.Very high): ");
            this.Level = (DangerousLevel)(Int32.Parse(Console.ReadLine()));
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Dangerous level : {Level}");
        }
        // General method
        // Other method
        // Overriding
        public override string ToString()
        {
            return base.ToString()
                + $"\nDangerous level: {Level}";
        }
    }
}
