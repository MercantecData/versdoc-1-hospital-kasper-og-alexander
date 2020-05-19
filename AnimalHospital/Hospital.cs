using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHospital
{
    //Her laver vi en class der hedder "Hospital" der indeholder allle functionerne for hospitalet
    class Hospital
    {
        //her definere vi vores variabler og lister
        public string name;
        public List<Patient> patients = new List<Patient>();
        public List<Doctor> doctors = new List<Doctor>();

        //Her laver vi et hospital object der indeholder navnet på hospitalet
        public Hospital(string name)
        {
            this.name = name;
        }
        //Her laver vi en function der tilføger en patient til systemet
        public void AdmitPatient(Patient patient)
        {
            if(patients.Contains(patient))
            {
                Console.WriteLine("Patient already admitted to {0}.", name);
            } else
            {
                patients.Add(patient);
                Console.WriteLine("{0} was admitted to {1} successfully", patient.name, name);
            }
        }
        //Her laver vi en function der viser en liste, med alle patienter i systemet
        public void showPatient(Patient pastient2)
        {
            foreach (object o in patients)
            {
                Console.WriteLine(o);
            }
        }
        //Her laver vi en function der udskriver patienter hvis deres navn bliver indtastet
        public void DischargePatient(Patient patient)
        {
            if(!patients.Contains(patient))
            {
                Console.WriteLine("Patient not in this hospital");
            } else
            {
                patients.Remove(patient);
            }
        }
        //Her laver vi en function der finder en specifik patient ud fra personens navn
        public Patient FindPatientByName(string name)
        {
            foreach(var p in patients)
            {
                if(p.name == name)
                {
                    return p;
                }
            }

            return null;
        }
        //Her laver i en function der tjekker om den doctor du skriver findes i systemet
        public void test(string test2, Patient patient)
        {
            foreach(Doctor d in doctors)
            {
                if(d.name == test2)
                {
                    Console.WriteLine("Doctor found");
                    d.assignedPatients.Add(patient);
                }
            }
        }
    }
}
