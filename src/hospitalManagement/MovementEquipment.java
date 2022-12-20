package hospitalManagement;

import java.util.Scanner;

public abstract class MovementEquipment extends Equipment {
	 //Field
    private int numberOfSeat;
    private String destination;

    // Infor field
    //  Management field
    // Dynamic field
    // Properties
   

    public int getNumberOfSeat() {
		return numberOfSeat;
	}
	public void setNumberOfSeat(int numberOfSeat) {
		this.numberOfSeat = numberOfSeat;
	}
	public String getDestination() {
		return destination;
	}
	public void setDestination(String destination) {
		this.destination = destination;
	}
	// Constructors
    public MovementEquipment() { }
    public MovementEquipment(
        String id
        , String name
        , String description
        , float price
        , boolean state
        , String origin
        , int quantity
        , int numberOfSeat
        , String destination
        )
    {
    	super(id, name, description, price, state, origin, quantity);
        this.numberOfSeat = numberOfSeat;
        this.destination = destination;
    }
    // Destructors

    // Methods
    // in, output
    public  void Input()
    {
        super.Input();
        Scanner ip = new Scanner(System.in);
        System.out.print("Number of seat:");
        numberOfSeat = ip.nextInt();
        if ( super.getState() == false)
        {
            System.out.print("Destination: ");
            destination = ip.nextLine();
        }
        else
        {
            destination = "";
        }
        ip.close();
    }
    public  void Output()
    {
        super.Output();
        System.out.format("Number of seat: %d\n", numberOfSeat);
        if (super.getState() == false)
        {
            System.out.format("Destination: %s\n",destination);

        }
    }
    // General method
    // Other method
    // Overriding


    public  String ToString()
    {
    	return  super.toString()
        + "\nNumber of seat: " + numberOfSeat
        + ((super.getState() == false) ? "\nDestination: " + destination : "");
    }
}
