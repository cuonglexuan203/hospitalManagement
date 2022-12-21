package hospitalManagement;

import java.util.Scanner;

public class Hospital implements IHospitalActivities {
	//Field
    private Faculties faculties;
    private Repositories repo;

    // Infor field
    private String name;
    private String description;
    private String address;

    //  Management field
    // Dynamic field
    // Properties

    public Faculties getFaculties() {
		return faculties;
	}
	public void setFaculties(Faculties faculties) {
		this.faculties = faculties;
	}
	public Repositories getRepo() {
		return repo;
	}
	public void setRepo(Repositories repo) {
		this.repo = repo;
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
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	// Constructors
    public Hospital()
    {
        faculties = new Faculties();
        repo = new Repositories();
    }
    public Hospital(Faculties faculties, Repositories repo)
    {
        this.faculties = faculties;
        this.repo = repo;
    }
    // Destructors

    // Methods
    // in, output
    public void Input()
    {
    	Scanner ip = new Scanner(System.in);
        System.out.println("Some basic information of hospital:");
        System.out.print("Name: ");
        this.name = ip.nextLine();
        System.out.print("Description: ");
        this.description = ip.nextLine();
        System.out.print("Address: ");
        this.address = ip.nextLine();
        ip.close();
    }
    public void Output()
    {
        System.out.println("The information of hospital: ");
        System.out.format("Name: %s\n", name);
        System.out.format("Description: %s\n", description);
        System.out.format("Address: %s\n",address);
        System.out.format("Number of faculty: %d\n", faculties.getCount());
        System.out.format("Number of repository: %d\n", repo.getCount());
        System.out.print("Do you want to show the faculty information?(1.yes, 0.no): ");
        Scanner ip = new Scanner(System.in);
        int choice = ip.nextInt();
        if (choice == 1)
        {
            faculties.ShowInformation();
        }
        System.out.print("Do you want to show the repository information?(1.yes, 0.no): ");
        choice = ip.nextInt();

        if (choice == 1)
        {
            repo.ShowInformation();
        }
        ip.close();
    }
    // General method

    // Other method
    public void AddFaculty()
    {
        this.faculties.AddItem();
    }
    public void AddRepository()
    {
        this.repo.AddItem();
    }
    public void RemoveFaculty(String id)
    {
        this.faculties.RemoveItem(id);
    }
    public void RemoveRepository(String id)
    {
        this.repo.RemoveItem(id);
    }
    public void ShowFaculty(String id)
    {
        this.faculties.FindItem(id).Output();
    }
    public void ShowRepository(String id)
    {
        this.repo.FindItem(id).Output();
    }
    public void ShowAllFaculty()
    {
        this.faculties.ShowInformation();
    }
    public void ShowAllRepository()
    {
        this.repo.ShowInformation();
    }
    // Overriding

}
