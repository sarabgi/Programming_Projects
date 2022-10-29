



public class AEmployeeRecord  extends BEmployeeSalary{

    public void record(String empname, String empstat, String empded){
        System.out.println("          |---------------------------------|");
        System.out.println("          |Employee Name: " +empname);
        System.out.println("          |Employee Status: " + empstat);
        System.out.println("          |Department: " + empded);
        System.out.println("          |---------------------------------|");
    }
}
