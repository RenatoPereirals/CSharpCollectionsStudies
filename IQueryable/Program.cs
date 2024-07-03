List<FamousPerson> famousPeople =
[
    new FamousPerson(1, "Sandy Cheeks", false),
    new FamousPerson(2, "Tony Stark", true),
    new FamousPerson(3, "Captain Marvel", true),
    new FamousPerson(4, "Captain America", true),
    new FamousPerson(5, "SpongeBob SquarePants", false),
    new FamousPerson(6, "Hulk", false)
];

IQueryable<FamousPerson> famousAndCanFly = famousPeople
    .AsQueryable()
    .Where(x => x.CanFly);

foreach (var fp in famousAndCanFly)
{
    Console.WriteLine($"{fp.Name} can FLY!");
}

record FamousPerson(int Id, string Name, bool CanFly);
