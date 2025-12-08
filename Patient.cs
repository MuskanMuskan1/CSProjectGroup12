using System;

public class Patient
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; }  // in kilograms
    public double Height { get; set; }  // in centimeters

    // Method to calculate BMI
    public void CalculateBMI()
    {
        double heightInMeters = Height / 100; // Convert cm to meters
        double bmi = Weight / (heightInMeters * heightInMeters);
        Console.WriteLine($"BMI: {bmi:F2}");

        if (bmi < 18.5)
            Console.WriteLine("Status: Underweight");
        else if (bmi < 24.9)
            Console.WriteLine("Status: Normal weight");
        else if (bmi < 29.9)
            Console.WriteLine("Status: Overweight");
        else
            Console.WriteLine("Status: Obese");
    }

    // Method to check blood pressure (example)
    public void CheckBloodPressure(int systolic, int diastolic)
    {
        Console.WriteLine($"Systolic: {systolic}, Diastolic: {diastolic}");
        if (systolic < 120 && diastolic < 80)
            Console.WriteLine("Blood Pressure: Normal");
        else if (systolic < 130 && diastolic < 80)
            Console.WriteLine("Blood Pressure: Elevated");
        else if (systolic <= 139 || diastolic <= 89)
            Console.WriteLine("Blood Pressure: High (Stage 1)");
        else
            Console.WriteLine("Blood Pressure: High (Stage 2)");
    }
}
