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

        public Equipment Equipment { get { return equipment; } }
        public IEnumerable<Guest> Guests { get { return guests; } }

        public void OrganizeParty(IEnumerable<IOrganizer> organizers)
        {
            foreach(var organizer in organizers)
            {
                organizer.Organize(this);
            }
        }
    }
}
