package hospitalManagement;

import java.util.Scanner;

public abstract class EmergencyTransportation extends MovementEquipment {

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
    public DangerousLevel getLevel() {
		return level;
	}
	public void setLevel(DangerousLevel level) {
		this.level = level;
	}
    // Constructors
    public EmergencyTransportation() { }
    public EmergencyTransportation(

         String id
        , String name
        , String description
        , float price
        , boolean state
        , String origin
        , int quantity
        , int numberOfSeat
        , String destination
        , DangerousLevel level
        ) 
    {
    	super(id, name, description, price, state, origin, quantity, numberOfSeat, destination);
        this.level = level;
    }
    // Destructors

    // Methods
    // in, output
    public  void Input()
    {
    	Scanner ip = new Scanner(System.in);
        super.Input();
        System.out.print("Dangerous level ( 0.Minor, 1.Moderate, 2.Considerable, 3.High, 4.Very high): ");
        int choice = ip.nextInt();
        switch (choice) {
        case 0:
        	this.level = DangerousLevel.Minor;
        	break;
        case 1:
        	this.level = DangerousLevel.Moderate;
        	break;
        case 2:
        	this.level = DangerousLevel.Considerable;
        	break;
        case 3:
        	this.level = DangerousLevel.High;
        	break;
        case 4:
        	this.level = DangerousLevel.VeryHigh;
        	break;
        }
        ip.close();
    }
    public  void Output()
    {
        super.Output();
        System.out.println("Dangerous level : " + level);
    }
    // General method
    // Other method
    // Overriding
    public  String ToString()
    {
        return super.toString()
            + "\nDangerous level: " + level;
    }
}
