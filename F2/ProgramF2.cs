//BREAK-CONTINUE EXEMPEL
//continue
for (int i = 0; i < 5; i++)
{
    if (i == 3) continue;//hoppa över att skriva ut 3
    Console.WriteLine(i);
}

Console.WriteLine("-------");

//break
for (int i = 0; i < 5; i++)
{
    if (i == 3) break;//stanna vid 3; avslutar loop
    Console.WriteLine(i);
}

Console.WriteLine("-------");



//ARRAYER EXEMPEL
string[] cars = { "Tesla", "BMW", "Dacia" }; //string visar vad som kan returneras
int[] numbers = { 1, 2, 3, 4, 5 };

//eller
string[] cars2 = new string[3];
cars2[0] = "Tesla";
cars2[1] = "BMW";
cars2[2] = "Dacia";
Console.WriteLine(cars2[0]);

foreach (string car in cars2) 
{
    Console.WriteLine(car);
}

foreach (int number in numbers) {
    Console.WriteLine(number);
}

//veckodagar
string[] ISOdays = { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" };

for (int i = 0; i < ISOdays.Length; i++)
{
    Console.WriteLine(ISOdays[i]);
}
Console.WriteLine("Totalt " + ISOdays.Length + " element.");

Console.WriteLine("-------");



//FLERDIMENSIONELLA ARRAYERS
//initiera array & slumpobjekt
int[] arr = new int[10];
Random rand = new Random();

// Generate random number array
for (int i = 0; i < 10; i++)
{
    arr[i] = rand.Next(0, 10); // Create random values 0-9
}

// Sort array
Array.Sort(arr);//i storleksordning

// Publish array
////for(int i = 0; i <10; i++) 
////{ //utan {} en rad, annars flera
//Console.Write(arr[i] + " "); // or 
Console.WriteLine(string.Join(" ", arr));
////Console.WriteLine();
Console.WriteLine("\nMax value:" + arr.Max() + " Sum: " + arr.Sum());
////}

Console.WriteLine("-------");

int[,] arr2 = new int[10, 10];//komma talar om hur många dimension = 2 st -> tre dimensioner (10, 10, 10)
Random rand2 = new Random();

// Generate random number array - två for-sats för två dimensioner
for (int x = 0; x < 10; x++)

    for (int y = 0; y < 10; y++) 
    {
        arr2[x, y] = rand2.Next(0, 10); //sätter en siffra i respektive dimension
    }
//Publish array
for (int i2 = 0; i2 < 10; i2++)
{
    for (int j = 0; j < 10; j++)
    {
        //går igenom hela j-array 10 ggr sedan till nästa i-array 
        Console.WriteLine(arr2[i2, j]);
    }
    //efter j-array är klar skrivs en tom rad ut, till nästa i-array
    Console.WriteLine();
}

Console.WriteLine("-------");



//STRÄNGINTERPOLATION
string courseId = "DT071G";
string courseName = "Programmering i C#.NET";
Console.WriteLine($"{courseId}, {courseName}");

Console.WriteLine("-------");

//FUNKTIONER
int max(int n, int m)
{
    return (n > m) ? n : m; //fråga (vilken störst) returnera -> n, annars m
}

int a5 = 3;
int b5 = 5;

Console.WriteLine($"Max({a5},{b5})=" + max(a5, b5));

Console.WriteLine("-------");



//NY FUNKTION
int[,] arr3 = new int[10, 10];
Random rand3 = new Random();

// Generate random number array
for (int x = 0; x < 10; x++)
    for (int y = 0; y < 10; y++) 
    {
    arr3[x, y] = rand3.Next(0, 9);
    }
// Publish array
Console.WriteLine(publish(arr3));

// Function
string publish(int[,] knarr)
{
    string s = "";
    int count = 0;

    foreach (var item in knarr)
    {
        s += item.ToString() + " ";

        count++;
        if (count % 10 == 0) s += "\n";
    }
    return s;
}