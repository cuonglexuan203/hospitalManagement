package hospitalManagement;

import java.util.Scanner;

public class Equipment {
	 //Field
    private String id;

    // Infor field
    private String name;
    private String description;
    private float price;
    private boolean state;
    private String origin;
    private int quantity;

    //  Management field
    // Dynamic field
    // Properties

    

    public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getDescription() {
		return description;
	}
	public void setDescription(String description) {
		this.description = description;
	}
	public float getPrice() {
		return price;
	}
	public void setPrice(float price) {
		this.price = price;
	}
	public boolean getState() {
		return state;
	}
	public void setState(boolean state) {
		this.state = state;
	}
	public String getOrigin() {
		return origin;
	}
	public void setOrigin(String origin) {
		this.origin = origin;
	}
	public int getQuantity() {
		return quantity;
	}
	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}
	// Constructors
    public Equipment() { }
    public Equipment(String id
        , String name
        , String description
        , float price
        , boolean state
        , String origin
        , int quantity
        )
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.price = price;
        this.state = state;
        this.origin = origin;
        this.quantity = quantity;
    }
    // Destructors

    // Methods
    // in, output
    public void Input()
    {
    	Scanner input = new Scanner(System.in);
        System.out.print("ID: ");
        id = input.nextLine();
        System.out.print("Name: ");
        name = input.nextLine();
        System.out.print("Description: ");
        description = input.nextLine();
        System.out.print("Price: ");
        price = input.nextFloat();
        System.out.print("State(1: free, 0: other): ");
        state = input.nextInt() == 1 ? true : false;
        System.out.print("Origin: ");
        origin = input.nextLine();
        System.out.print("Quantity: ");
        quantity = input.nextInt();
        input.close();
    }
    public  void Output()
    {
        System.out.format("Id: %s",id);
        System.out.format("Name: %s",name);
        System.out.format("Description: %s",description);
        System.out.format("Price: %.2f",price);
        System.out.format("State: %s",(state ? "Free" : "InWork"));
        System.out.format("Origin: %s",origin);
        System.out.format("Quantity: %s",quantity);
    }


    // General method
    // Other method

    // Overriding
    public  String toString()
    {return  "Id: "+id
    + "\nName: "+name
    + "\nDescription: "+description
    + "\nPrice: "+price
    + "\nState: "+state
    + "\nOrigin: "+origin
    + "\nQuantity: "+quantity;}
}
