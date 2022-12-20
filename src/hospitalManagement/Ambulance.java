package hospitalManagement;

public class Ambulance extends EmergencyTransportation {
	//Field
    // Infor field
    //  Management field
    // Dynamic field
    // Properties
    // Constructors
    public Ambulance() { }
    public Ambulance(
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
    	super(id, name, description, price, state, origin, quantity, numberOfSeat, destination, level);
    }
    // Destructors

    // Methods
    // in, output
    public  void Input()
    {
        super.Input();
    }
    public  void Output()
    {

        System.out.format("\nThe information of %s\n", this.getClass().getSimpleName());
        super.Output();
    }
    // General method
    // Other method
    // Overriding
    public  String toString()
    {
        return super.toString();
    }
}
