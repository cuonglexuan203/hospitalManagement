using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Fee
    {
        //Field
        private float drugCosts;

        private float treatmnetCosts;

        private float advanceFee;


        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        public float DrugCosts { get => drugCosts; set => drugCosts = value; }
        public float TreatmnetCosts { get => treatmnetCosts; set => treatmnetCosts = value; }
        public float AdvanceFee { get => advanceFee; set => advanceFee = value; }
        // Constructors
        public Fee() { }
        public Fee(float drugCosts
                    , float treatmnetCosts
                    , float advanceFee)
        {
            DrugCosts = drugCosts;
            TreatmnetCosts = treatmnetCosts;
            AdvanceFee = advanceFee;

        }
        // Destructors
        ~Fee() { }
        // Methods
        // in, output
        public void input()
        {
            System.Console.WriteLine("The drug costs: ");
            DrugCosts = float.Parse(Console.ReadLine());
            System.Console.WriteLine("The treatmnet costs: ");
            TreatmnetCosts = float.Parse(Console.ReadLine());
            System.Console.WriteLine("The advance fee: ");
            AdvanceFee = float.Parse(Console.ReadLine());
        }
        public void output()
        {
            System.Console.WriteLine($"The drug costs: {DrugCosts}");
            System.Console.WriteLine($"The treatmnet costs: {TreatmnetCosts}");
            System.Console.WriteLine($"The advance fee: {AdvanceFee}");
        }
        // General method
        // Other method
        // Overriding
    }
}
