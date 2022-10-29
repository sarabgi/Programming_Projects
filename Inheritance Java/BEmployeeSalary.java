public class BEmployeeSalary extends CemployeeDeduction{

    public void salary(int prate, int hrswrked, int clothing, int transpo, int food){

     int employeesalary =(prate * prate)+(clothing +transpo+ food);
      System.out.println("          |Employee Netpay: " +employeesalary);
      System.out.println("          |---------------------------------|");
    }

}
