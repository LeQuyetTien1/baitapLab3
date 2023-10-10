using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapLab3
{
    internal class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private double basicSalary;

        public Employee() { }
        public Employee(int id, string name, int yearOfBirth, double salaryLevel, double basicSalary)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
            this.basicSalary = basicSalary;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int YearOfBirth { get { return yearOfBirth; } set { yearOfBirth = value; } }
        public double SalaryLevel { get {  return salaryLevel; } set {  salaryLevel = value; } }
        public double BasicSalary { get {  return basicSalary; } set {  basicSalary = value; } }

        public double GetIncome()
        {
            return (salaryLevel * basicSalary);
        }
        public void Display()
        {
            Console.WriteLine("---Thong tin---");
            Console.WriteLine("Dinh danh: " + id);
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("Nam sinh: " + yearOfBirth);
            Console.WriteLine("Bac luong: " + salaryLevel);
            Console.WriteLine("Luong co ban: " + basicSalary);
        }
    }
}
