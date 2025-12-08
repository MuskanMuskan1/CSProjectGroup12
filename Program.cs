using System;

namespace CSProjectGroup12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== PATIENT HEALTH CHECK SYSTEM ====\n");

            // ==========================================
            // Create Patient Object
            // ==========================================
            Patient p = new Patient();

            // ==========================================
            // Collect User Input
            // ==========================================
            Console.Write("Enter First Name: ");
            p.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            p.LastName = Console.ReadLine();

            Console.Write("Enter Weight (KG): ");
            p.Weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Height (CM): ");
            p.Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Systolic BP: ");
            int systolic = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Diastolic BP: ");
            int diastolic = Convert.ToInt32(Console.ReadLine());

            // ==========================================
            // Display Summary
            // ==========================================
            Console.WriteLine($"\n===== PATIENT SUMMARY =====");
            Console.WriteLine($"Name: {p.FirstName} {p.LastName}");
            Console.WriteLine($"Weight: {p.Weight} KG");
            Console.WriteLine($"Height: {p.Height} CM");

            // ==========================================
            // Run Calculations
            // ==========================================
            p.CalculateBMI();
            p.CheckBloodPressure(systolic, diastolic);

            Console.WriteLine("\n==== END OF REPORT ====");
        }
    }
}
