package hospitalManagement;

import java.util.ArrayList;

public class Repositories implements IBasicActivities<Repository> {
	//Field
    private ArrayList<Repository> repositoryList;
    private long count;

    // Infor field
    //  Management field
    // Dynamic field
    // Properties


    

    public ArrayList<Repository> getRepositoryList() {
		return repositoryList;
	}
	public void setRepositoryList(ArrayList<Repository> repositoryList) {
		this.repositoryList = repositoryList;
	}
	public long getCount() {
		return count;
	}
	public void setCount(long count) {
		this.count = count;
	}
	// Constructors
    public Repositories()
    {
        repositoryList = new ArrayList<Repository>();
        this.count = 0;
    }
    public Repositories(ArrayList<Repository> repositoryList, long count)
    {
        this.repositoryList = repositoryList;
        this.count = count;
    }

    // Destructors
    // Methods
    // in, output
    // General method
    // Other method

    public void AddItem()
    {
        Repository repository = new Repository();
        System.out.println("New repository");
        repository.Input();
        repositoryList.add(repository);
        this.count++;
        System.out.println("Done!");
    }

    public void AddItem(Repository value)
    {
        System.out.println("New repository");
        repositoryList.add(value);
        this.count++;
        System.out.println("Done!");
    }
    public void ShowInformation()
    {
        System.out.println("-------------------------------------------------------------------");

        System.out.println("Show information of all repositories");

        repositoryList.forEach(value ->
        {
            value.Output();
            System.out.println();
        });
        System.out.println("Done!");
        System.out.println("-------------------------------------------------------------------");

    }

    public Repository UpdateItem(String id)
    {
        System.out.println("Update the repository");

        Repository  res = null;
        for (Repository rep : repositoryList) {
			if( rep.getId() == id)
			{
				rep.Input();
				res = rep;
			}
		}
        if (res == null)
        {
            System.out.format("\nNot found the repository with id: $s\n", id);
        }
        else
        {
            System.out.println("Done!");
        }
        return res;
    }

    public boolean RemoveItem(String id)
    {
        System.out.println("Remove the repository");

        boolean res = false;
        for (Repository rep : repositoryList) {
			if(rep.getId()== id)
			{
				repositoryList.remove(rep);
				this.count--;
				res = true;
				continue;
			}
		}
        if (res == false)
        {
            System.out.format("Not found repository with id: %s\n", id);

        }
        else
        {
            System.out.println("Done!");

        }
        return res;
    }

    public Repository FindItem(String id)
    {
        System.out.println("Find the repository");

        Repository res = null;
        for(Repository rep: repositoryList)
        {
        	if(rep.getId() == id) {
        		res = rep;
        	}
        }
        if (res == null)
        {
            System.out.format("Not found repository with id: %s\n", id);

        }
        else
        {
            System.out.println("Done!");
        }
        return res;
    }

    public boolean Clear()
    {
        System.out.println("\nClear all repositories");

        repositoryList.clear();

        return true;

    }
    // Overriding
}
