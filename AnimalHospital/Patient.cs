using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHospital
{
    //Her laver vi en class der hedder "Patient" der indegolder aller værdierne for en patient
    class Patient
    {//Her definere vi vores variabler
        public string name;
        public int age;
        public Doctor doctor;

        //Her laver vi en public object der hedder "patient" der indeholder variablerne "name" og "age"
        public Patient(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //Her laver vi en function der indsætter vores patienter til det ågældende hospital
        public void AdmitTo(Hospital hospital)
        {
            hospital.AdmitPatient(this);
        }
    }
}
