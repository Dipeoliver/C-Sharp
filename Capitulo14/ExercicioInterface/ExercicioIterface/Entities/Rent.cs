using System;
using System.Collections.Generic;

namespace ExercicioIterface.Entities
{
    class Rent
    {
        public DateTime Pickup { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }  

        public Rent() { }

        public Rent(DateTime pickup, DateTime @return, Vehicle vehicle)
        {
            Pickup = pickup;
            Finish = @return;
            Vehicle = vehicle;           
        }                   
    }
}
