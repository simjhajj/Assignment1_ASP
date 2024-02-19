using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C
{
    internal class Patient
    {
        // Properties with getters and setters
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }


        // constructor for patient class
        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        // method to calculate Blood Pressure of a person
        public string BloodPressure(int systolic, int diastolic)
        {
            if (systolic <= 120 || diastolic <= 80)
            {
                return "NORMAL";
            }
            else if (systolic <= 129 || diastolic <= 80)
            {
                return "ELEVATED";
            }
            else if (systolic <= 139 || diastolic <= 89)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            }
            else if (systolic >= 140 || diastolic >= 90)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            }
            else if (systolic >= 180 || diastolic >= 120)
            {
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            }
            else
            {
                return "Consult your doctor immediately";
            }

        }

        // Method to calculate BMI of a person
        public double CalculateBMI()
        {

            // conversion of height from cm to m
            double heightInMetres = Height / 100.0;

            // calculation of bmi
            double bmi = Weight / (heightInMetres * heightInMetres);

            return bmi;

        }

        // method to return patient information
        public void PatientInfo(int systolic, int diastolic)
        {
            // calaculate blood pressure results
            string bloodPressureResults = BloodPressure(systolic, diastolic);

            // calculate BMI results
            double bmiResults = CalculateBMI();

            // print Patient's status based on BMI results
            string bmiStatus = GetBmiStatus(bmiResults);

            /// printing patient's information information
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Blood Pressure Result: {bloodPressureResults}");
            Console.WriteLine($"BMI Results: {bmiResults}");
            Console.WriteLine($"BMI Status: {bmiStatus}");
        }

        // method to return BMI results based on different values
        private static string GetBmiStatus(double bmi)
        {

            if (bmi >= 25.0)
            {
                return "Overweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return "Normal (in the healthy range)";
            }
            else
            {
                return "Underweight";
            }
        }

    }
}