package hospitalManagement;

import java.util.Scanner;
public class Salary
    {
        //Field
        private float basic;
        private float bonus;
        private float allowance;

        // Information field
        //  Management field
        // Dynamic field
        static Scanner input = new Scanner(System.in);

        // Properties
      
        public float getBasic() {
            return basic;
        }
        public void setBasic(float basic) {
            this.basic = basic;
        }
        public float getBonus() {
            return bonus;
        }
        public void setBonus(float bonus) {
            this.bonus = bonus;
        }
        public float getAllowance() {
            return allowance;
        }
        public void setAllowance(float allowance) {
            this.allowance = allowance;
        }
        // Constructors
        public Salary() { }
        public Salary(float basic, float bonus, float allowance)
        {
            this.basic = basic;
            this.bonus = bonus;
            this.allowance = allowance;
        }

        // Methods
        // in, output
        public void Input()
        {
            System.out.println("Basic: ");
            basic = input.nextFloat();
            System.out.println("Bonus: ");
            bonus = input.nextFloat();
            System.out.println("Allowance: ");
            allowance = input.nextFloat();
        }
        public void Output()
        {
            System.out.println("Basic: " + basic);
            System.out.println("Bonus: " + bonus);
            System.out.println("Allowance: " + allowance);
        }
        // General method
        // Other method
        // Overriding
        public String ToString()
        {
        return "\nThe basic: " + basic
            + "\nThe bonus: " + bonus
            + "\nThe allowance: " + allowance;
        }
    }