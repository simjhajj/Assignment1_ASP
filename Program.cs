using Assignment1_C;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // getting Patient's First Name
            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();

            // getting Patient's Last Name
            Console.WriteLine("Enter your Last Name: ");
            string lastName = Console.ReadLine();

            // getting Patient's Weight in KG
            Console.WriteLine("Enter your Weight in kg: ");
            double weight = double.Parse(Console.ReadLine());

            // getting Patient's Height
            Console.WriteLine("Enter your Height in metres: ");
            double height = double.Parse(Console.ReadLine());

            // getting Patient's Systolic Blood Pressure
            Console.WriteLine("Enter your Systolic Blood Pressure: ");
            int systolic = int.Parse(Console.ReadLine());

            // getting Patient's Diastolic Blood Pressure
            Console.WriteLine("Enter your Diastolic Blood Pressure: ");
            int diastolic = int.Parse(Console.ReadLine());

            // creating a new instance of Patient class
            Patient patient = new Patient(firstName, lastName, weight, height);
          
            // printing patient's information using the object created
            patient.PatientInfo(systolic, diastolic);
        }
    }
}