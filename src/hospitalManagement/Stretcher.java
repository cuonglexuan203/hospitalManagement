package hospitalManagement;

public class Stretcher extends NonEmergencyTransportation {
	 //Field
    // Infor field
    //  Management field
    // Dynamic field
    // Properties
    // Constructors
    public Stretcher() { }
    public Stretcher(
       String id
       , String name
       , String description
       , float price
       , boolean state
       , String origin
       , int quantity
       , int numberOfSeat
       , String destination
        , String clientRequiremnt
        , String purpose
       )
    {
    	  super(id, name, description, price, state, origin, quantity, numberOfSeat, destination, clientRequiremnt, purpose);
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
        System.out.println("\nThe information: " + this.getClass().getSimpleName());

        super.Output();
    }
    // General method
    // Other method
    // Overriding
    public  String ToString()
    {
        return super.ToString();
    }
}
