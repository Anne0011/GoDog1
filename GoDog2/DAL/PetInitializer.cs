using GoDog2.Models;
using System;
using System.Collections.Generic;

namespace GoDog2.DAL
{
    public class PetInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PetContext>
    {
        public object petlogs;

        protected override void Seed(PetContext context)
        {
            var pets = new List<Pet>
            {
                new Pet {petName="Fido", picture="Image", petSize="Large",  petBreed="St. Bernard", petAge=2 },
            };
            pets.ForEach(s => context.Pets.Add(s));
            context.SaveChanges();

            var petlogs = new List<PetLog>
            {
                new PetLog {Activity="Walking",CreatedAt=DateTime.UtcNow,duration=20 },
                new PetLog {Activity="Jogging",CreatedAt=DateTime.UtcNow,duration=10 },
                new PetLog {Activity="Playing",CreatedAt=DateTime.UtcNow,duration=30 },
                new PetLog {Activity="Walking",CreatedAt=DateTime.UtcNow,duration=15 },
                new PetLog {Activity="Jogging",CreatedAt=DateTime.UtcNow,duration=15 },
                new PetLog {Activity="Playing",CreatedAt=DateTime.UtcNow,duration=45 },
                new PetLog {Activity="Walking",CreatedAt=DateTime.UtcNow,duration=20 },
            };
            petlogs.ForEach(s => context.PetLogs.Add(s));
            context.SaveChanges();
        }


    }
}