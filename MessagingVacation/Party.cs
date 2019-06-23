using System;
using System.Collections.Generic;

namespace MessagingVacation
{
    public class Party
    {
        private readonly Equipment equipment;
        private readonly IEnumerable<Guest> guests;

        public Party(Equipment equipment, IEnumerable<Guest> guests)
        {
            this.equipment = equipment ?? throw new ArgumentNullException("equipment");
            this.guests = guests ?? throw new ArgumentNullException("guests");
        }

        public void OrganizeParty(Technician technician, DiscJockey discJockey, Chef chef)
        {
            technician.Organize(equipment);
            discJockey.Organize(guests);
            chef.Organize(guests);
        }
    }
}
