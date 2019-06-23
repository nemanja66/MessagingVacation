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

        public void OrganizeParty(IEnumerable<IOrganizer> organizers)
        {
            foreach(var organizer in organizers)
            {
                switch (organizer)
                {
                    case Technician technician:
                        technician.Organize(equipment);
                        break;
                    case Chef chef:
                        chef.Organize(guests);
                        break;
                    case DiscJockey discJockey:
                        discJockey.Organize(guests);
                        break;
                    default:
                        throw new ArgumentException(
                            message: "organizer not recognized",
                            paramName: nameof(organizer));
                }
            }
        }
    }
}
