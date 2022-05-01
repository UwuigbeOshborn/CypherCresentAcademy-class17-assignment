// See https://aka.ms/new-console-template for more information

Console.WriteLine("------------------------------    CypherCresentClass17 Assignment Question  1      ------------------------------");
try
{
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

    //Creating an assignment file within assignment folder
    if (File.Exists(Path.Combine(myAssignment, "AssignmentModel1.csv")))
    {
        Console.WriteLine("File Already Exists");
    }
    else
    {
        File.Create(Path.Combine(myAssignment, "AssignmentModel1.csv"));
        Console.WriteLine("File has been created");
    }

    //Writting into the file for AssignmentModel1
    var line1 = new AssignmentModel1
    {
        IdLabel = "Id",
        AssignmentName = "AssignmentName",
        AssignmentLocation = "AssignmentLocation",
        AssignmentModel2 = new AssignmentModel2()
    };
    var line2 = new AssignmentModel1
    {
        Id = 1,
        AssignmentName = "Model1",
        AssignmentLocation = Path.Combine(myAssignment, "AssignmentModel1.csv "),
        AssignmentModel2 = new AssignmentModel2()
    };
    File.AppendAllText(Path.Combine(myAssignment, "AssignmentModel1.csv "), $"{line1.IdLabel},{line1.AssignmentName},{line1.AssignmentLocation},{line1.AssignmentModel2}\n");
    File.AppendAllText(Path.Combine(myAssignment, "AssignmentModel1.csv "), $"{line2.Id},{line2.AssignmentName},{line2.AssignmentLocation},{line2.AssignmentModel2}\n\n\n");

    //Writting into the file for AssignmentModel2
    var line3 = new AssignmentModel2
    {
        IdLabel = "Id",
        AssignmentName = "AssignmentName",
        AssignmentLocation = "AssignmentLocation",
        AssignmentModel3 = new AssignmentModel3()
    };
    var line4 = new AssignmentModel2
    {
        Id = 1,
        AssignmentName = "Model2",
        AssignmentLocation = Path.Combine(myAssignment, "AssignmentModel1.csv "),
        AssignmentModel3 = new AssignmentModel3()
    };
    File.AppendAllText(Path.Combine(myAssignment, "AssignmentModel1.csv "), $"{line3.IdLabel},{line3.AssignmentName},{line3.AssignmentLocation},{line3.AssignmentModel3}\n");
    File.AppendAllText(Path.Combine(myAssignment, "AssignmentModel1.csv "), $"{line4.Id},{line4.AssignmentName},{line4.AssignmentLocation},{line4.AssignmentModel3}\n\n\n");


    //Writting into the file for AssignmentModel3
    var line5 = new AssignmentModel3
    {
        IdLabel = "Id",
        AssignmentName = "AssignmentName",
        AssignmentLocation = "AssignmentLocation",
    };
    var line6 = new AssignmentModel3
    {
        Id = 1,
        AssignmentName = "Model3",
        AssignmentLocation = Path.Combine(myAssignment, "AssignmentModel1.csv "),
    };
    File.AppendAllText(Path.Combine(myAssignment, "AssignmentModel1.csv "), $"{line5.IdLabel},{line5.AssignmentName},{line5.AssignmentLocation}\n");
    File.AppendAllText(Path.Combine(myAssignment, "AssignmentModel1.csv "), $"{line6.Id},{line6.AssignmentName},{line6.AssignmentLocation}\n\n\n");
    Console.WriteLine("Successfully written to file, please check the file now");
}
catch (Exception ex)  //catching a IOException
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Please run the program again, in order to write to file");
}


public class AssignmentModel1
{
    public int Id { get; set; }
    public string IdLabel { get; set; }
    public string AssignmentName { get; set; }
    public string AssignmentLocation { get; set; }
    public AssignmentModel2 AssignmentModel2 { get; set; }
}
public class AssignmentModel2
{
    public int Id { get; set; }
    public string IdLabel { get; set; }
    public string AssignmentName { get; set; }
    public string AssignmentLocation { get; set; }
    public AssignmentModel3 AssignmentModel3 { get; set; }

}
public class AssignmentModel3
{
    public int Id { get; set; }
    public string IdLabel { get; set; }
    public string AssignmentName { get; set; }
    public string AssignmentLocation { get; set; }

}