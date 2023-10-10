using baitapLab3;
using System;
public class Program
{
    static void Main(string[] args)
    {
        Employee ep1 = new Employee(1, "Tien", 1997, 2.1, 5000);
        Employee ep2 = new Employee { Id = 2, Name = "Linh", YearOfBirth = 1997, SalaryLevel = 2.5, BasicSalary = 5000 };
        Employee ep3 = new Employee();
        ep3.Id = 3;
        ep3.Name = "Tan";
        ep3.YearOfBirth = 2003;
        ep3.SalaryLevel = 3;
        ep3.BasicSalary = 6000;

        ep1.Display();
        Console.WriteLine("Thu nhap cua nhan vien la: " + ep1.GetIncome());
        ep2.Display();
        Console.WriteLine("Thu nhap cua nhan vien la: " + ep2.GetIncome());
        ep3.Display();
        Console.WriteLine("Thu nhap cua nhan vien la: " + ep3.GetIncome());
    }
}