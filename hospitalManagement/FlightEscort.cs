using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class FlightEscort : NonEmergencyTransportation
    {
        //Field
        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        // Constructors
        public FlightEscort() { }
        public FlightEscort(
           string id
           , string name
           , string description
           , float price
           , bool state
           , string origin
           , int quantity
           , int numberOfSeat
           , string destination
            , string clientRequiremnt
            , string purpose
           ) : base(id, name, description, price, state, origin, quantity, numberOfSeat, destination, clientRequiremnt, purpose)
        {

        }
        // Destructors
        ~FlightEscort() { }
        // Methods
        // in, output
        public override void Input()
        {
            base.Input();
        }
        public override void Output()
        {
            Console.WriteLine($"\nThe information: {this.GetType().Name}");

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
