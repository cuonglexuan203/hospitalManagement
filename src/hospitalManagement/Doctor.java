package hospitalManagement;

import java.util.ArrayList;
import java.util.Scanner;

public class Doctor extends Employee{
       
        //Field
private ArrayList<Patient> patientList;



// Information field
//  Management field
static Scanner input = new Scanner(System.in);

// Dynamic field
// Properties

public ArrayList<Patient> getPatientList() {
    return patientList;
}
public void setPatientList(ArrayList<Patient> patientList) {
    this.patientList = patientList;
}


// Constructors
public Doctor()
{
    patientList = new ArrayList<Patient>();
}
public Doctor(String id
, String firstName
, String lastName
, int age
, int gentle
, String description
, String address
, String email
, String phone
, String facultyId
, String departmentId
, Boolean state
, ComeAndLeaveDate admissionDates
, Salary salaries
, ArrayList<Patient> patientList)
{
    super(id, firstName, lastName, age, gentle, description, address, email, phone, facultyId, departmentId, state, admissionDates, salaries);

    this.patientList = patientList;
}


// Methods
// in, output
public void Input()
{
    super.Input();
}

public  void Output()
{
    super.Output();
}
// General method
// Other method
// Overriding
public  void ExportBill()
{
    super.ExportBill();
}

public  float CalcBill()
{
    return super.CalcBill();
}
}
