package hospitalManagement;

import java.util.ArrayList;
//import java.util.Scanner;
public class Nurses implements IBasicActivities<Nurse>
{
    //field
    private ArrayList<Nurse> nurseList;
    private long count;


    // Information field
    //  Management field
    // Dynamic 
    // Properties

    // Constructors

    public ArrayList<Nurse> getNurseList() {
        return nurseList;
    }
    public void setNurseList(ArrayList<Nurse> nurseList) {
        this.nurseList = nurseList;
    }
    public long getCount() {
        return count;
    }
    public void setCount(long count) {
        this.count = count;
    }
    public Nurses()
    {
        nurseList = new ArrayList<Nurse>();
        count = 0;
    }
    public Nurses(ArrayList<Nurse> nurseList, long count)
    {
        this.nurseList = nurseList;
        this.count = count;
    }

    

    public void AddItem()
    {
        System.out.println("Add nurse");

        Nurse nurse = new Nurse();
        nurse.Input();
        nurseList.add(nurse);
        this.count++;
        System.out.println("Done!");

    }

    public void AddItem(Nurse value)
    {
        System.out.println("Add nurse");

        nurseList.add(value);
        this.count++;
        System.out.println("Done!");

    }

    public boolean Clear()
    {
        System.out.println("Clear all nurses");

        nurseList.clear();
        
        System.out.println("Done!");
        return true;
    }

    public Nurse FindItem(String id)
    {
        Nurse res = null;
        for (Nurse i : nurseList) {
			if( i.getId() == id)
			{
				res = i;
			}
		}
        if (res == null)
        {
            System.out.println("Not found nurse with id: " + id);

        }
        else
        {
            System.out.println("Done!");

        }
        return res;
    }

    public boolean RemoveItem(String id)
    {
        System.out.println("Remove the nurse");

        boolean res = false;
        for (Nurse i : nurseList) {
            if( i.getId() == id)
            {
                nurseList.remove(i);
                this.count--;
            }
        }
        if (res == false)
        {
            System.out.println("Not found nurse with id: " + id);

        }
        else
        {
            System.out.println("Done!");

        }
        return res;
    }

    public void ShowInformation()
    {
        System.out.println("Show information of all nurses");

        nurseList.forEach(value -> { value.Output(); System.out.println(); });
        System.out.println("Done!");
    }

    public Nurse UpdateItem(String id)
    {
        System.out.println("Update the nurse");

        Nurse res = null;
        for (Nurse i : nurseList) {
            if( i.getId() == id)
            {
                i.Input();
                res = i;
            }
        }
        if (res == null)
        {
            System.out.println("Not found the nurse with id: " + id);

        }
        else
        {
            System.out.println("Done!");

        }
        return res;
    }
}