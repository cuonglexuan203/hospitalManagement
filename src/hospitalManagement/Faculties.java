package hospitalManagement;


import java.util.ArrayList;
class Faculties 
    {
        //Field	
        private ArrayList<Faculty> facultyList;
        private long count;



        // Information field	
        //  Management field	
        // Dynamic field	
        // Properties	
        public ArrayList<Faculty> getFacultyList() {
            return facultyList;
        }
        public void setFacultyList(ArrayList<Faculty> facultyList) {
            this.facultyList = facultyList;
        }
        public long getCount() {
            return count;
        }
        public void setCount(long count) {
            this.count = count;
        }
        // Constructors	

        public Faculties ()
        {
            facultyList = new ArrayList<Faculty>();
            count = 0;
        }
        
        public Faculties(ArrayList<Faculty> facultyList, long count)
        {
            this.facultyList = facultyList;
            this.count = count;
        }

        // Methods	
        // in, output	
        // General method	
        // Other method	
        public void AddItem()
        {
            Faculty faculty = new Faculty();
            System.out.println("New faculty");
            faculty.Input();
            facultyList.add(faculty);
            System.out.println("Done!");
        }

        public void AddItem(Faculty value)
        {
            System.out.println("New faculty");
            facultyList.add(value);
            System.out.println("Done!");
        }

        public Boolean Clear()
        {
            System.out.println("Clear all faculties");

            facultyList.clear();
            if (facultyList.size() > 0)
            {
                System.out.println("Failure!");
                return false;
            }
            this.count = 0;
            System.out.println("Done!");

            return true;
        }

        public Faculty FindItem(String id)
        {
            System.out.println("Find the faculty");

            Faculty res = null;
            
            for (Faculty i : facultyList) {
                if( i.getId() == id)
                {
                    res = i;
                }
            }
            if (res == null)
            {
                System.out.println("Not found faculty");

            }
            else
            {
                System.out.println("Done!");
            }
            return res;
        }

        public boolean RemoveItem(String id)
        {
            System.out.println("Remove the faculty");

            boolean res = false;
            for (Faculty i : facultyList) {
                if( i.getId() == id)
                {
                    facultyList.remove(i);
                    this.count--;
                }
            }
            if (res == false)
            {
                System.out.println("Not found faculty");

            }
            else
            {
                System.out.println("Done!");

            }
            return res;
        }

        public void ShowInformation()
        {
            System.out.println("-------------------------------------------------------------------");

            System.out.println("Show information of all faculties");

            facultyList.forEach(value -> { value.Output(); System.out.println(); });

            System.out.println("Done!");
            System.out.println("-------------------------------------------------------------------");
        }

        public Faculty UpdateItem(String id)
        {
            System.out.println("Update the faculty");

            Faculty res = null;
            for (Faculty i : facultyList) {
                if( i.getId() == id)
                {
                    i.Input();
                    res = i;
                }
            }
            if (res == null)
            {
                System.out.println("Not found the faculty with id: {id}");
            }
            else
            {
                System.out.println("Done!");
            }
            return res;
        }
        // Overriding	

    }