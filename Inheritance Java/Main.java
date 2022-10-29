

import java.util.Scanner;


public class Main {

    
    public static void main(String[] args) {

        Scanner pasok =new Scanner(System.in);
       System.out.println("           _____________________________");
       System.out.println("          |_____________________________|");
       System.out.println("          |------ G R O S S P A Y ------|");
       System.out.println("          |-----------------------------|");
       System.out.println("          |                             |");
       System.out.print  ("          |Employee Name: ");
       String empname =pasok.nextLine();
       System.out.print  ("          |Employee Status: ");
       String empstat =pasok.nextLine();
       System.out.print  ("          |Employee's Department: ");
       String empdep =pasok.nextLine();
       System.out.println("          |=============================|");
       System.out.print  ("          |Pay-Rate: ");
       int prate =pasok.nextInt();
       System.out.print  ("          |# of House Worked: ");
       int hrswrked =pasok.nextInt();
       System.out.print  ("          |Clothing Allowance: ");
       int clothing =pasok.nextInt();
       System.out.print  ("          |Transportation Allowance: ");
       int transpo =pasok.nextInt();
       System.out.print  ("          |Food Allowance: ");
       int food =pasok.nextInt();
       System.out.println("          |=============================|");
       System.out.print  ("          |SSS Deduction: ");
       int sssded =pasok.nextInt();
       System.out.print  ("          |Pag-Ibig Deduction: ");
       int loveded =pasok.nextInt();
       System.out.print  ("          |Tax Deduction: ");
       int taxded=pasok.nextInt();
       System.out.println("          |=============================|");
       System.out.println("");
       System.out.println("           _________________________________");
       System.out.println("          |_________________________________|");


       AEmployeeRecord Emprec =new  AEmployeeRecord();

      Emprec.record(empname, empstat, empdep);
      Emprec.salary(prate, hrswrked, clothing, transpo, food);
      Emprec.deductionsyow(sssded, loveded, taxded);

    }}


