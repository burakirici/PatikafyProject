using PatikafyProject;

public class Program
{
    public static void Main(string[] args)
    {
        // We create Singers list and adding that items.
        List<Singer> singers = new List<Singer>()
        {
            new Singer
            {
                singerFullName = "Ajda Pekkan", Date = 1968, typeOfMusic = "Pop", albumSales = 20000000
            },
            new Singer
            {
                singerFullName = "Sezen Aksu", Date = 1971, typeOfMusic = "Türk Halk Müziği / Pop", albumSales = 10000000

            },
            new Singer
            {
                singerFullName = "Funda Arar", Date = 1999, typeOfMusic = "Pop", albumSales = 3000000

            },
            new Singer
            {
                singerFullName = "Sertap Erener", Date = 1994, typeOfMusic = "Pop", albumSales = 5000000

            },
            new Singer
            {
                singerFullName = "Sıla", Date = 2009, typeOfMusic = "Pop", albumSales = 10000000

            },
            new Singer
            {
                singerFullName = "Serdar Ortaç", Date = 1994, typeOfMusic = "Türk Halk Müziği / Pop", albumSales = 10000000

            },
             new Singer
            {
                singerFullName = "Tarkan", Date = 1992, typeOfMusic = "Pop", albumSales = 40000000
            },
              new Singer
            {
                singerFullName = "Hande Yener", Date = 1999, typeOfMusic = "Pop", albumSales = 7000000
            },
               new Singer
            {
                singerFullName = "Hadise", Date = 2005, typeOfMusic = "Pop", albumSales = 5000000
            },
               new Singer
            {
                singerFullName = "Gülben Ergen", Date = 1997, typeOfMusic = "Türk Halk Müziği / Pop", albumSales = 10000000

            },
               new Singer
            {
                singerFullName = "Neşet Ertaş", Date = 1960, typeOfMusic = "Türk Halk Müziği/Türk Sanat Müziği", albumSales = 2000000

            }
        };

        // Singers whose names start with S
        var startsWithS = singers.Where(Name => Name.singerFullName.StartsWith('S')).Select(Name => Name.singerFullName).ToList();
        Console.WriteLine("Singers whose names start with S : ");
        foreach (var startsS in startsWithS)
        {
            Console.WriteLine(startsS);
        }

        Console.WriteLine("------------------------------");
        // Singers with album sales over 10 million
        var overTenMillion = singers.Where(s => s.albumSales > 10000000).Select(s => s.singerFullName).ToList();
        Console.WriteLine("Singers with album sales over 10 million : ");
        foreach (var item in overTenMillion)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("------------------------------");

       var beforeYear2000 = singers
                            .Where(s => s.Date < 2000 && s.typeOfMusic.Contains("Pop"))
                            .OrderBy(s => s.Date)
                            .ThenBy(s => s.singerFullName)
                            .Select(s => s.singerFullName)
                            .ToList();
        foreach (var item in beforeYear2000)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------");
        // The best seller singer
        var bestSeller = singers.OrderByDescending(s => s.albumSales).First().singerFullName;
        Console.WriteLine($"Best seller singer is: {bestSeller} ");
        Console.WriteLine("------------------------------");
        // Latest singer
        var latestSinger = singers.OrderByDescending(s => s.Date).First().singerFullName;
        Console.WriteLine($"The latest singer is : {latestSinger} ");

        Console.WriteLine("------------------------------");
        // First singer
        var firstSinger = singers.OrderBy(s => s.Date).First().singerFullName;
        Console.WriteLine($"First singer is : {firstSinger} ");



    }
}