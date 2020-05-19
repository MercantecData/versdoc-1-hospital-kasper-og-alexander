using System;
using System.Windows.Markup;
using System.Data;

namespace AnimalHospital
{

    //Her laver vi vores class program
    class Program
    {
        //her laver vi et hospital som får værdierne fra vores function der hedder "InitializeHospital" 
        public static Hospital hospital;
        static void Main(string[] args)
        {
            hospital = InitializeHospital();
            while (MainMenu()) { }

            Console.WriteLine("Goodbye!");
        }
        //Her beder vi programmet om at skrive de forskellige muligheder brugeren har på systemet
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
            //Her laver vi en if statement der køre forskellige funktioner i forhold til hvad brugeren har valgt til at starte med
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
            //Her definere vi hvad der sker hvis man ikke vælger et tal til at starte med 
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return true;
        }
        //Her laver vi en function der sætter en specifik læge sammen med en spicifik patient
        static void patient_doctor()
        {
            Console.WriteLine("Doctors name");
            string doc = Console.ReadLine();
            Console.WriteLine("Patients name");
            string pat = Console.ReadLine();
            hospital.test(doc, hospital.FindPatientByName(pat));
        }
        //Her laver vi en function der viser en liste over alle patienter på hospitalet
        static void showpatient()
        {
            foreach(var test in hospital.patients)
            {
                Console.WriteLine(test.name);
            }
        }
        //Her laver vi en function der tilføger en patient til systemet
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
        //Her laver vi en funktion der fjerner en specifik patient ud fra navnet
        static void Karen()
        {
            Console.WriteLine("Patients name");
            string pat = Console.ReadLine();
            hospital.DischargePatient(hospital.FindPatientByName(pat));
        }
        //Her laver vi en function der laver det hospital vi bruger og tilføger de læger der er på hospital
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
