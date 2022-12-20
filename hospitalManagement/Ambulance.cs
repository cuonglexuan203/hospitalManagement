using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Ambulance : EmergencyTransportation
    {
        //Field
        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        // Constructors
        public Ambulance() { }
        public Ambulance(
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
            ) : base(id, name, description, price, state, origin, quantity, numberOfSeat, destination, level)
        {

        }
        // Destructors
        ~Ambulance() { }
        // Methods
        // in, output
        public override void Input()
        {
            base.Input();
        }
        public override void Output()
        {

            Console.WriteLine($"\nThe information of {this.GetType().Name}");

            base.Output();
        }
        // General method
        // Other method
        // Overriding
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
