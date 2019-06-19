using System;

namespace MessagingVacation
{
    public class Party
    {
        private readonly Equipment equipment;
        public Party(Equipment equipment)
        {
            this.equipment = equipment ?? throw new ArgumentNullException("equipment");
        }

        public Equipment Equipment { get { return equipment; } }

        public void OrganizeParty(Technician technician)
        {
            technician.SetupSpeakers(Equipment);
            technician.SetupMixer(Equipment);
            technician.SetupLighting(Equipment);
        }
    }
}
