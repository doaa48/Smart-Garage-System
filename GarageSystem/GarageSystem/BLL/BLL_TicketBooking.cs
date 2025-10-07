using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BLL_TicketBooking
    {
        public int Ticket_Free_IntervalTime { get; set; } = 15;
        public int Ticket_FixedRate { get; set; } = 50;
        public int Ticket_DifferentRate_hr1 { get; set; } = 70;
        public int Ticket_DifferentRate_hr2 { get; set; } = 60;
        public int Ticket_DifferentRate_hr3 { get; set; } = 40;
        public int Ticket_OvernightRate { get; set; } = 250;
        public string Ticket_PricingModel { get; set; } = "consistent";

    }
}
