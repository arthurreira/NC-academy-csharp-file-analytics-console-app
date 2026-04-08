class Program
{
    static void Main()
    {
        // create object
        MyFile file = new MyFile();

        // separate steps
        file.WriteFileResult();    // print file content
        file.CalculateSum();       // calculate sum
        file.CalculateAverage();   // calculate average
        file.WriteResults();       // print sum & average
        file.WriteJsonResult();
    }
}