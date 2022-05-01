// See https://aka.ms/new-console-template for more information
Console.WriteLine("------------------------------      CypherCresentClass17 Assignment Question 2      ------------------------------");


//Creating an assignment folder
var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

var myAssignment = Path.Combine(path, "Oshborn Assignment");
if (!Directory.Exists(myAssignment))
{
    Directory.CreateDirectory(Path.Combine(path, "Oshborn Assignment"));
    Console.WriteLine("Folder has been created");
}
else
{
    Console.WriteLine("Folder Already Exists");
}

//verifing if the sampledata.csv file is in the required directory, if not Search the system for such file and copy it to the required directory
if (File.Exists(Path.Combine(myAssignment, "sampledata.csv")))
{
    Console.WriteLine("Good, the file Exists");
}
//else
//{
//    //File.Create(Path.Combine(myAssignment, "sampledata.csv"));
//    Console.WriteLine("Note: in order to run the remaining lines of code, the sampledata.csv file to be converted to C# model should be copied to this directory => ...Desktop/Oshborn Assignment");
//}
else
{
    try
    {
        var fileSearch = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*sampledata.csv*", SearchOption.AllDirectories);
        File.Copy(Path.GetFullPath(fileSearch.First()), Path.Combine(myAssignment, "sampledata.csv"));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        try
        {
            var fileSearch = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "*sampledata.csv*", SearchOption.AllDirectories);
            File.Copy(Path.GetFullPath(fileSearch.First()), Path.Combine(myAssignment, "sampledata.csv"));
        }
        catch (Exception)
        {
            Console.WriteLine(ex.Message);
            try
            {
                var fileSearch = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "*sampledata.csv*", SearchOption.AllDirectories);
                File.Copy(Path.GetFullPath(fileSearch.First()), Path.Combine(myAssignment, "sampledata.csv"));
            }
            catch (Exception)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    var fileSearch = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "*sampledata.csv*", SearchOption.AllDirectories);
                    File.Copy(Path.GetFullPath(fileSearch.First()), Path.Combine(myAssignment, "sampledata.csv"));
                }
                catch (Exception)
                {
                    Console.WriteLine(ex.Message);
                    try
                    {
                        var fileSearch = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "*sampledata.csv*", SearchOption.AllDirectories);
                        File.Copy(Path.GetFullPath(fileSearch.First()), Path.Combine(myAssignment, "sampledata.csv"));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Hello, the sampledata.csv file you intend to work on, can not be found on your system.");
                    }
                }
            }
        }
    }
}

try
{
    //Note: in order to run the remaining lines of code, the sampledata.csv file to be converted to a C# model should be copied to this directory => ...Desktop/Oshborn Assignment
    var info = new FileInfo(Path.Combine(myAssignment, "sampledata.csv"));
    var sampleData = new List<SampleData>();
    var csv_file_lines = File.ReadAllLines(Path.Combine(myAssignment, "sampledata.csv "));
    foreach (var item in csv_file_lines)
    {
        var item_split = item.Split(",");
        sampleData.Add(new SampleData
        {
            OrderDate = item_split[0],
            Region = item_split[1],
            Rep = item_split[2],
            Item = item_split[3],
            Units = item_split[4],
            UnitCost = item_split[5],
            Total = item_split[6]
        });
    }
    //Checking the number of lines in the file
    Console.WriteLine(sampleData.Count());

    //Printing out each lines in the file
    sampleData.ForEach(x => Console.WriteLine($"{x.OrderDate}, {x.Region}, {x.Rep}, {x.Item}, {x.Units}, {x.UnitCost}, {x.Total}"));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Please, make the file available and try again later");
}

public class SampleData
{
    public string OrderDate { get; set; }
    public string Region { get; set; }
    public string Rep { get; set; }
    public string Item { get; set; }
    public string Units { get; set; }
    public string UnitCost { get; set; }
    public string Total { get; set; }
}