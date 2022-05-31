// See https://aka.ms/new-console-template for more information
using DbCodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

DbContext db = new PeopleConnectionContext();
await db.Database.EnsureCreatedAsync();


var frined1 = new Person();
frined1.Name = "Ivan";
var ac = new Activity() { ActivityName = (ActivitiesEnum)1, Points = 10 };

frined1.Activity.Add(ac);

for (int i = 0; i < 4; i++)
{
    db.Add<Activity>(ac);
}


for (int i = 0; i < 10; i++)
{

    var  act = new Activity() { ActivityName = (ActivitiesEnum)(i % 4) };

    var friendRel = new FriendRelation() { PersonId = i - 1,};

    friendRel.Friends.Add(frined1);

    var fr = new Person() { Name = $"Ivan{i}"};
    fr.Activity.Add(act);
    fr.FriendsRelations.Add(friendRel);

    db.Add<Person>(fr);
}

await db.SaveChangesAsync();


Console.WriteLine("Done");