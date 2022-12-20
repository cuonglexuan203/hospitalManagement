package hospitalManagement;

public abstract class MovementEquipment extends Equipment {
	 //Field
    private int numberOfSeat;
    private String destination;

    // Infor field
    //  Management field
    // Dynamic field
    // Properties
    public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
    public String Destination { get => destination; set => destination = value; }

    // Constructors
    public MovementEquipment() { }
    public MovementEquipment(
        String id
        , String name
        , String description
        , float price
        , bool state
        , String origin
        , int quantity
        , int numberOfSeat
        , String destination
        ) : base(id, name, description, price, state, origin, quantity)
    {
        this.numberOfSeat = numberOfSeat;
        this.destination = destination;
        this.Quantity = quantity;
    }
    // Destructors
    ~MovementEquipment() { }
    // Methods
    // in, output
    public override void Input()
    {
        base.Input();

        Console.Write("Number of seat:");
        numberOfSeat = Int32.Parse(Console.ReadLine());
        if (State == false)
        {
            Console.Write("Destination: ");
            destination = Console.ReadLine();
        }
        else
        {
            destination = "";
        }

    }
    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Number of seat: {numberOfSeat}");
        if (State == true)
        {
            Console.WriteLine($"Destination: {destination}");

        }
    }
    // General method
    // Other method
    // Overriding


    public override String ToString()
    => base.ToString()
        + $"\nNumber of seat: {numberOfSeat}"
        + ((State == true) ? $"\nDestination: {destination}" : "");

}
