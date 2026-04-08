using System;
using System.IO;
using System.Text.Json;

class MyFile
{
    public string FileName { get; set; } = @"C:\Users\ArthurFerreira\Documents\github\HelloWorld\Numbers.txt";
    public string Description { get; set; } = "";
    public double Sum { get; set; }
    public double Average { get; set; }

    public string ReadFile()
    {
        return File.ReadAllText(FileName);
    }

    public void WriteFileResult()
    {
        string content = ReadFile();
        Console.WriteLine("File content:");
        Console.WriteLine(content);
    }

    public void CalculateSum()
    {
        string[] lines = File.ReadAllLines(FileName);
        double sum = 0;
        foreach (string line in lines)
        {
            if (double.TryParse(line, out double number))
                sum += number;
        }
        Sum = sum;

       
    }

    public void CalculateAverage()
    {
        string[] lines = File.ReadAllLines(FileName);
        int count = 0;
        double sum = 0;
        foreach (string line in lines)
        {
            if (double.TryParse(line, out double number))
            {
                sum += number;
                count++;
            }

            
        }
        Average = count > 0 ? sum / count : 0;
    }

    public void WriteResults()
    {
        Console.WriteLine($"Sum: {Sum}");
        Console.WriteLine($"Average: {Average}");
    }


    public void WriteJsonResult()
    {
        var result = new
        {
            Sum = this.Sum,
            Average = this.Average
        };

        string json = JsonSerializer.Serialize(result, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText("result.json", json);

        Console.WriteLine("JSON file created: result.json");
    }

}