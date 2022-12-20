package hospitalManagement;

import java.util.ArrayList;

public class Medicines implements IBasicActivities<Medicine> {

	 //Field
    private ArrayList<Medicine> medicineList;
	private long count;

    // Infor field
    //  Management field
    // Dynamic 
    // Properties
	public ArrayList<Medicine> getMedicineList() {
		return medicineList;
	}
	public void setMedicineList(ArrayList<Medicine> medicineList) {
		this.medicineList = medicineList;
	}
	public long getCount() {
		return count;
	}
	public void setCount(long count) {
		this.count = count;
	}
    // Constructors
    public Medicines()
    {
        medicineList = new ArrayList<Medicine>();
        count = 0;
    }
    public Medicines(ArrayList<Medicine> medicineList, long count)
    {
        this.medicineList = medicineList;
        this.count = count;

    }
    // Destructors
    // Methods
    // in, output
    // General method
    // Other method
    public void AddItem()
    {
        System.out.println("Add medicine:");
        Medicine medicine = new Medicine();
        medicine.Input();
        medicineList.add(medicine);
        this.count++;
        System.out.println("Done!");

    }
    public void AddItem(Medicine value)
    {
        System.out.println("Add medicine");
        medicineList.add(value);
        this.count++;
        System.out.println("Done!");

    }
    public void ShowInformation()
    {
        System.out.println("\tShow information of all medicines");
        medicineList.forEach(value -> { value.Output(); System.out.println(); });
        System.out.println("Done!");
    }

    public Medicine UpdateItem(String id)
    {
        System.out.println("Update the medicine");

        Medicine res = null;
        for (Medicine i : medicineList) {
			if( i.getId() == id)
			{
				i.Input();
				res = i;
			}
		}
        if (res == null)
        {
            System.out.format("Not found the medicine with id: %s", id);
        }
        else
        {
            System.out.println("Done!");

        }
        return res;
    }

    public boolean RemoveItem(String id)
    {
        System.out.println("Remove the medicine");

        boolean res = false;
        for (Medicine i : medicineList) {
			if( i.getId() == id)
			{
				medicineList.remove(i);
				this.count--;
			}
		}
        if (res == false)
        {
            System.out.format("Not found medicine with id: ", id);

        }
        else
        {
            System.out.println("Done!");
        }
        return res;
    }

    public Medicine FindItem(String id)
    {
        System.out.println("Find the medicine");
        Medicine res = null;
        for (Medicine i : medicineList) {
			if( i.getId() == id)
			{
				res = i;
			}
		}
        if (res == null)
        {
            System.out.format("Not found medicine with id: ", id);

        }
        else
        {
            System.out.println("Done!");

        }
        return res;
    }

    public boolean Clear()
    {
        System.out.println("Clear all medicines");

        medicineList.clear();
        return true;
    }

    // Overriding

}
