using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHospital
{
    //vi laver en class der hedder "Doctor" der indeholder alle dokterens  functionaliteter
    class Doctor
    {
        //Her definere vi vores variabler
        public string name;
        public string speciality;
        public List<Patient> assignedPatients = new List<Patient>();

        //Her laver vi et object som hedder "Doctor" der indeholder en navn og hvad de kan finde ud af
        public Doctor(string name, string speciality)
        {
            this.name = name;
            this.speciality = speciality;
        }
    }
}
