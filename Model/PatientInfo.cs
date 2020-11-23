using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace Template_Project.Model
{
    class PatientInfo : ObservableObject
    { 
        private string lastName;
        private string firstName;
        private char middleInitial;
        private string sex;
        private string address;
        private string city;
        private string state;
        private string zip;
        private int age;
        private float weight;
        private DateTime dateOfBirth;
        private DateTime admitDate;
        private Allergies allergies;

        private string diagnosis;
        private string illnessHistory;
        private string insurance;
        private int policyNumber;
        private MedicalHistory medicalHistory;
        private string recentMedicationSedation;
        private Labs labResults;

        public struct Allergies
        {
            public bool NKA;
            public bool SULFA;
            public bool PCN;
            public bool ASA;
            public bool EMYCN;
            public bool OTHER;
            public string otherAllergies;
        }

        public struct MedicalHistory
        {
            public bool CABG;
            public bool CAD;
            public bool CHF;
            public bool COPD;
            public bool CVA;
            public bool DM;
            public bool HTN;
            public bool Seizures;
            public bool MI;
            public bool Other;
            public string otherHistory;
            public bool None;
        }

        public struct Labs
        {
            public DateTime date;
            public double WBC;
            public double HGB;
            public double HCT;
            public double RBC;
            public double PLT;
            public double NA;
            public double K;
            public double CL;
            public double CO2;
            public double GLU;
            public double BUN;
            public double CR;
            public int PT;
            public int PTT;
            public double INR;
            public double TROP;
            public double CKMB;
            public double MG;
            public double BNP;
        }
    }
}
