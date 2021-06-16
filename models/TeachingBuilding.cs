using System.Collections.Generic;

namespace CivCampusExercise_2021.models
{
    public class TeachingBuilding : Building
    {

        public List<Room> Rooms { get; set; }

        
        public TeachingBuilding(string buildingId) : base(buildingId)
        {
            this.Rooms = new List<Room>();
        }

        public void AddRoom(int capacity, int roomNo) {
            //TODO Done: make roomId a string created from buildingId + RoomNo as text
            string roomId = BuildingId+roomNo;
            
            uint ucapacity=(uint)(int)capacity;

            //TODO Done: fix the below to add the new room to the rooms list
            Rooms.Add(new Room(ucapacity, roomNo, roomId));
        }

        /// <summary>
        /// Returns a string with the list of rooms seperated by commas
        /// </summary>
        /// <returns>A string representing the rooms</returns>
        public string ListRooms() {
            string output = "";

            foreach(var room in Rooms) {
                output += $"{room.RoomId}, {room.Capacity}\n";
            }
            return output;
        }

        public int GetBuildingCapacity() {
            int total = 0;
            
            // TODO Done: calculate and store into total all of the room capacities for the building combined
            foreach(var room in Rooms) {
                total += (int)(uint)room.Capacity;
            }

            return total;
        }
    }
}