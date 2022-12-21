package hospitalManagement;

import java.util.Scanner;

public abstract class NonEmergencyTransportation extends MovementEquipment {
	//Field
    private String clientRequirement;
    private String purpose;
    // Information field
    //  Management field
    // Dynamic field
    // Properties
    

    // Constructors
    public String getClientRequirement() {
		return clientRequirement;
	}

	public void setClientRequirement(String clientRequirement) {
		this.clientRequirement = clientRequirement;
	}

	public String getPurpose() {
		return purpose;
	}

	public void setPurpose(String purpose) {
		this.purpose = purpose;
	}

	public NonEmergencyTransportation(
       String id
       , String name
       , String description
       , float price
       , boolean state
       , String origin
       , int quantity
       , int numberOfSeat
       , String destination
        , String clientRequirement
        , String purpose
       )
    {
		super(id, name, description, price, state, origin, quantity, numberOfSeat, destination);
        this.clientRequirement = clientRequirement;
        this.purpose = purpose;
    }

    public NonEmergencyTransportation()
    {
    }

    // Destructors

    // Methods
    // in, output
    public  void Input()
    {
        super.Input();
        Scanner ip = new Scanner(System.in);
        System.out.print("Requirement: ");
        clientRequirement = ip.nextLine();
        System.out.print("Purpose: ");
        purpose = ip.nextLine();
        ip.close();
    }
    public  void Output()
    {
        super.Output();
        System.out.format("Requirement: %s", clientRequirement);
        System.out.format("Purpose: %s", purpose);
    }
    // General method
    // Other method
    // Overriding
    public  String ToString()
    {
        return super.ToString()
            + "Requirement: " + clientRequirement
            + "Client's purpose: " + purpose;
    }
}
