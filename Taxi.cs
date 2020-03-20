using System;


namespace Taxi
{
    class Taxi {

        //property
        public string DriverName;
        public Boolean OnDuty;
        public int NumPassenger;

        //method
        public void TaxiInfo () {
            Console.WriteLine("Driver Name : " + this.DriverName);
            if(OnDuty == true) {
                Console.WriteLine("On Duty : yes");
            } else if(OnDuty == false) {
                Console.WriteLine("On Duty : no");
            }
            Console.WriteLine("Number Of Passenger : " + this.NumPassenger);
        }

        public void PickUpPassenger() {
            Console.WriteLine( this.DriverName + " sedang menjemput penumpang");
        }

        public void DropOffPassenger() {
            Console.Write( this.DriverName + " selesai mengantar penumpang");
        }



    }
}