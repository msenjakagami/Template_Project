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
    class MainPage : ObservableObject
    {

        //Main Fields
        private DateTime date;
        private int runNumber;
        private int unitNumber;
        
        

        private Facility sendFaciilty;
        private Facility receiveFacility;
        
        private TransportReason transportReason;

        public struct Facility
        {
            public string name;
            public int roomNumber;
            public string physician;

        }

        public struct TransportReason
        {
            public bool HLC;
            public bool Repatriation;
            public bool NoProcedureOrTreatment;
            public bool NoBed;
            public bool LongTermCare;
            public bool PhysicianRequest;
            public bool Other;
            public string otherReason;

        }
    }
        
}
