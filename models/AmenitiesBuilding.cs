namespace CivCampusExercise_2021.models {
    public class AmenitiesBuilding : Building {

        // Available types are: Student Amenities, Student Admin, Staff Admin, Library
        public string Type { get; set; }

        // Opening/Closing Hour in 24hr time.  example 8 = 8am, 18 = 6pm
        public int OpeningHour { get; set; }
        public int ClosingHour { get; set; }

        //TODO Done: add constructor that initialises the attributes and parent constructor
        public AmenitiesBuilding(string buildingId, string type, int openingHour, int closingHour) : base(buildingId)
        {
            Type = type;
            OpeningHour = openingHour;
            ClosingHour = closingHour;
        }
    }
}