Trees t1 = new Trees();
Trees t2 = new Trees();

t1.DeathState = true;
t2.DeathState = false;

Console.WriteLine(t1.DeathState);
Console.WriteLine(t2.DeathState);


Batteries b1 = new Batteries();
Batteries b2 = new Batteries();

b1.EnergyStored = 16;
b2.EnergyStored = 5;

Console.WriteLine(b1.EnergyStored);
Console.WriteLine(b2.EnergyStored);

Console.ReadLine();
