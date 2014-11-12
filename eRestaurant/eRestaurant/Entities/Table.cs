using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace eRestaurant.Entities
{
    public class Table
    {
        public int TableID { get; set; }
        [Required(ErrorMessage="Table Number is required")]
        [Range(1, byte.MaxValue, ErrorMessage="Table Number must be a positive number")]
        public byte TableNumber { get; set; }
        public bool Smoking { get; set; }
        public int Capacity { get; set; }
        public bool Available { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

        public Table()
        {
            Available = true;
        }
    }
}
