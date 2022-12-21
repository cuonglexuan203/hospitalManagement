package hospitalManagement;

import java.util.Scanner;
public class Fee {
    //Field
    private float drugCosts;

    private float treatmentCosts;

    private float advanceFee;


    // Information field
    //  Management field
    // Dynamic field
    static Scanner input = new Scanner(System.in);

    // Properties
    
    public float getDrugCosts() {
        return drugCosts;
    }
    public void setDrugCosts(float drugCosts) {
        this.drugCosts = drugCosts;
    }
    public float getTreatmentCosts() {
        return treatmentCosts;
    }
    public void setTreatmentCosts(float treatmentCosts) {
        this.treatmentCosts = treatmentCosts;
    }
    public float getAdvanceFee() {
        return advanceFee;
    }
    public void setAdvanceFee(float advanceFee) {
        this.advanceFee = advanceFee;
    }
    // Constructors
    public Fee() 
    {
        
    }
    public Fee(float drugCosts
                , float treatmentCosts
                , float advanceFee)
    {
        this.drugCosts = drugCosts;
        this.treatmentCosts = treatmentCosts;
        this.advanceFee = advanceFee;

    }
    // Methods
    // in, Output
    public void Input()
    {
        System.out.println("The drug costs: ");
        drugCosts = input.nextFloat();
        System.out.println("The treatment costs: ");
        treatmentCosts = input.nextFloat();
        System.out.println("The advance fee: ");
        advanceFee = input.nextFloat();
    }
    public void Output()
    {
        System.out.println("The drug costs: " + drugCosts);
        System.out.println("The treatment costs: " + treatmentCosts);
        System.out.println("The advance fee: " + advanceFee);
    }
    // General method
    // Other method
    // Overriding
    public String ToString(){
    return "\nThe drug cost: " + drugCosts + "\nThe treatment cost: " + treatmentCosts + "\nThe advance fee: " + advanceFee;
    }
}
