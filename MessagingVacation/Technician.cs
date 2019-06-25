using System;

namespace MessagingVacation
{
    public class Technician: IOrganizer<IEquipmentOrganizable>
    {
        private void SetupSpeakers(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        private void SetupMixer(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        private void SetupLighting(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        public void Organize(IEquipmentOrganizable equipmentOrganizable)
        {
            SetupSpeakers(equipmentOrganizable.Equipment);
            SetupMixer(equipmentOrganizable.Equipment);
            SetupLighting(equipmentOrganizable.Equipment);
        }
    }
}