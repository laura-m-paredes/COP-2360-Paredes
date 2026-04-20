// Group Project Assignment 10: COP 2360 C# Programming
// Created by: Laura Paredes, Antania Burgess, and Ainsley McDonald
// Date: 04/19/2026

using System;

// Contractor Class

public class Contractor
{
    // Information about the contractor
private string name;
private int contractorNumber;
private string startDate;


    // Default information for constructor
public Contractor()
{
name = "";
contractorNumber = 0;
startDate = "";
}


    // Constructor with all values
public Contractor(string n, int num, string date)
{
name = n;
contractorNumber = num;
startDate = date;
}


    // Mutators - Updates or changes the values of the contractor's information
public void SetName(string n) { name = n; }
public void SetContractorNumber(int num) { contractorNumber = num; }
public void SetStartDate(string date) { startDate = date; }



    // Accessors - Retrieves the values of the contractor's information
public string GetName() { return name; }
public int GetContractorNumber() { return contractorNumber; }
public string GetStartDate() { return startDate; }
}

// Subcontractor Class

public class Subcontractor : Contractor
{
private int shift;// 1 = day, 2 = night
private double hourlyRate; // Hourly pay



    // Default information for constructor
public Subcontractor() : base()
{
shift = 1;
hourlyRate = 0.0;
}



    // Constructor with all values
public Subcontractor(string n, int num, string date, int sh, double rate)
: base(n, num, date)
{
shift = sh;
hourlyRate = rate;
}



    // Mutators - Updates or changes the values of the subcontractor's information
public void SetShift(int sh) { shift = sh; }
public void SetHourlyRate(double rate) { hourlyRate = rate; }



    // Getters - Retrieves the values of the subcontractor's information
public int GetShift() { return shift; }
public double GetHourlyRate() { return hourlyRate; }



    // ComputePay — Calculates pay with 3% night differential
public float ComputePay(float hoursWorked)
{
double pay = hourlyRate * hoursWorked;


if (shift == 2) // Night shift
{
pay *= 1.03; // Add 3%
}



return (float)pay;
}
}


// Main Program
public class Program
{
public static void Main(string[] args)
{
Console.Write("How many subcontractors would you like to enter? ");
int count = int.Parse(Console.ReadLine());


        // Loop to create multiple subcontractor objects
for (int i = 0; i < count; i++)
{
Console.WriteLine($"\n--- Subcontractor {i + 1} ---");


Console.Write("Enter name: ");
string name = Console.ReadLine();


Console.Write("Enter contractor number: ");
int number = int.Parse(Console.ReadLine());


Console.Write("Enter start date (MM/DD/YYYY): ");
string date = Console.ReadLine();


Console.Write("Enter shift (1 = day, 2 = night): ");
int shift = int.Parse(Console.ReadLine());

Console.Write("Enter hourly rate: ");
double rate = double.Parse(Console.ReadLine());


Console.Write("Enter hours worked: ");
float hours = float.Parse(Console.ReadLine());


            // Create subcontractor object
Subcontractor sc = new Subcontractor(name, number, date, shift, rate);


            // Execute pay
float pay = sc.ComputePay(hours);


            // Results
Console.WriteLine($"Computed pay: ${pay}");
}
}
}

