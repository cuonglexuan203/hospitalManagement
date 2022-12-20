using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal abstract class NonEmergencyTransportation : MovementEquipment
    {

        //Field
        private string clientRequirement;
        private string purpose;
        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        public string ClientRequiremnt
        {
            get => clientRequirement; set => clientRequirement = value;
        }
        public string Purpose
        {
            get => purpose; set => purpose = value;
        }

        // Constructors
        public NonEmergencyTransportation(
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
           ) : base(id, name, description, price, state, origin, quantity, numberOfSeat, destination)
        {
            ClientRequiremnt = clientRequiremnt;
            Purpose = purpose;
        }

        protected NonEmergencyTransportation()
        {
        }

        // Destructors
        ~NonEmergencyTransportation() { }
        // Methods
        // in, output
        public override void Input()
        {
            base.Input();
            Console.Write("Requirement: ");
            ClientRequiremnt = Console.ReadLine();
            Console.Write("Purpose: ");
            purpose = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Requirement: {clientRequirement}");
            Console.WriteLine($"Purpose: {purpose}");
        }
        // General method
        // Other method
        // Overriding
        public override string ToString()
        {
            return base.ToString()
                + $"Requirement: {clientRequirement}"
                + $"Client's purpose: {purpose}";
        }
    }
}
