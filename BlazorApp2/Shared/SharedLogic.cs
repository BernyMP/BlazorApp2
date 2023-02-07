namespace BlazorApp2.Shared;
using BlazorApp2.Data;
using BlazorApp2.Pages;

public class SharedLogic<T>
{
    public int smallestVal { get; set; }
    public int largestVal { get; set; }
    public List<T> valsSmallestSpread { get; set; }
    public List<T> valsLargestSpread { get; set; }
    
    public async Task calculateSpread(T[] data, string objType)
    {
        valsSmallestSpread = new List<T>();
        valsLargestSpread = new List<T>();
        
        foreach (T date in data)
        {
            int tempSpread = objType == "Climate" ? CodingTask1RW.calculateSpread(date as ClimatologicalData) : CodingTask2RW.calculateSpread(date as PremierClub);
            if (valsSmallestSpread.Count() == 0 && valsLargestSpread.Count() == 0)
            {
                valsLargestSpread.Add(date);
                valsSmallestSpread.Add(date);
                largestVal = tempSpread;
                smallestVal = tempSpread;
            }
            else
            {
                if (tempSpread > largestVal)
                {
                    valsLargestSpread = objType == "Climate"
                        ? CodingTask1RW.removeDates(valsLargestSpread as List<ClimatologicalData>, largestVal).Cast<T>().ToList()
                        : CodingTask2RW.removeDates(valsLargestSpread as List<PremierClub>, largestVal).Cast<T>().ToList();
                    valsLargestSpread.Add(date);
                    largestVal = tempSpread;
                }
                else if (tempSpread == largestVal)
                {
                    valsLargestSpread.Add(date);
                }
    
                if (tempSpread < smallestVal)
                {
                    valsSmallestSpread = objType == "Climate"
                        ? CodingTask1RW.removeDates(valsSmallestSpread as List<ClimatologicalData>, smallestVal).Cast<T>().ToList()
                        : CodingTask2RW.removeDates(valsSmallestSpread as List<PremierClub>, smallestVal).Cast<T>().ToList();
                    valsSmallestSpread.Add(date);
                    smallestVal = tempSpread;
                }
                else if (tempSpread == smallestVal)
                {
                    valsSmallestSpread.Add(date);
                }
            }
        }
    }
}

