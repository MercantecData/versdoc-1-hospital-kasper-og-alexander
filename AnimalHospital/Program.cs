using System;
using System.Windows.Markup;
using System.Data;

namespace AnimalHospital
{
    class Program
    {
        public static Hospital hospital;
        static void Main(string[] args)
        {
            hospital = InitializeHospital();
            while (MainMenu()) { }

            Console.WriteLine("Goodbye!");
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to {0}. You have the following options:", hospital.name);
            Console.WriteLine("1. Admit a patient to the hospital");
            Console.WriteLine("2. Discharge a patient");
            Console.WriteLine("3. See a list of all patients in the hospital");
            Console.WriteLine("4. See a list of all doctors in the hospital");
            Console.WriteLine("5. Assign a specific doctor to a specific patient");
            Console.WriteLine("0. Quit the Program");
            Console.WriteLine();

            var k = Console.ReadKey().KeyChar;
            if (k == '1')
            {
                AdmitPatient();
            }
            else if (k == '2')
            {
                Karen();
            }
            else if (k == '3')
            {
                showpatient();
            }
            else if (k == '4')
            {
               InitializeHospital();
            }
            else if (k == '5')
            {
                patient_doctor();
            }
            else if (k == '0')
            {
                return false;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return true;
        }
        static void patient_doctor()
        {
            Console.WriteLine("Doctors name");
            string doc = Console.ReadLine();
            Console.WriteLine("Patients name");
            string pat = Console.ReadLine();
            hospital.test(doc, hospital.FindPatientByName(pat));
        }
        static void showpatient()
        {
            foreach(var test in hospital.patients)
            {
                Console.WriteLine(test.name);
            }
        }
        
        static void AdmitPatient()
        {
            string name;
            int age;

            Console.WriteLine("What is the patients name?");
            name = Console.ReadLine();

            Console.WriteLine("What is the patients age?");
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("You must write a number, try again");
            }

            new Patient(name, age).AdmitTo(hospital);
        }

        static void Karen()
        {
            Console.WriteLine("Patients name");
            string pat = Console.ReadLine();
            hospital.DischargePatient(hospital.FindPatientByName(pat));
        }

        static Hospital InitializeHospital()
        {
            Hospital hospital = new Hospital("Animal Hospital");

            hospital.doctors.AddRange(new Doctor[]
            {
                new Doctor("Matt Tennant", "Spinal Injury"),
                new Doctor("David Smith", "Knee Injury"),
                new Doctor("Jodie Tyler", "Oncology"),
                new Doctor("Rose Whitaker", "Intensive Care")
            });
             foreach(var values in hospital.doctors){
        Console.WriteLine(values.name + " " + values.speciality);
        }
            return hospital;
        }
    }
 }
