using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingRooms
{
    public class RoomRepository
    {
        private List<TrainingRoom> m_rooms = new List<TrainingRoom>
        {
            new TrainingRoom
            {
                Id = 1,
                Name = "Copernicus",
                Location = "bldg 1",
                NumberComputers = 25
            },
            new TrainingRoom
            {
                Id = 2,
                Name = "Sagitarius",
                Location = "bldg 1",
                NumberComputers = 50
            },
            new TrainingRoom
            {
                Id = 3,
                Name = "Luna",
                Location = "bldg 1",
                NumberComputers = 75
            }
        };

        public List<TrainingRoom> GetRooms()
        {
            return m_rooms;
        }

        public TrainingRoom GetRoom(int id)
        {
            return (from r in m_rooms where r.Id == id select r).FirstOrDefault();
        }
    }
}