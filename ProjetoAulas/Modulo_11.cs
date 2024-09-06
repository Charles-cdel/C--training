namespace Modulo11;
public class TrabalhandoComDatas
{
    public void Data()
    {
        var date1 = new DateTime (2018,05,14,12,52,55);
        var date2 = DateTime.Parse("2018/05/14 12:52:55");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));//Formatando DateTime

        var dateOffset1 = new DateTimeOffset (DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffset1.LocalDateTime);
        Console.WriteLine(dateOffset1.UtcDateTime);
    }

    public void SubtraindoDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2018/05/14");

        var diff = date1 - date2;//var diff = date1.Substract(date2);
        
        Console.WriteLine((int)diff.TotalDays);
        Console.WriteLine((int)diff.TotalHours);
    }

    public void AddDiaMesAno()
    {
        var date1 = DateTime.Now;

        

        Console.WriteLine(date1.AddDays(2));// add formatação

        Console.WriteLine(date1.AddMonths(4));// add formatação

        Console.WriteLine(date1.AddYears(6));// add formatação


    }

    public void AddHoraMinSegundos()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.ToString("HH:mm:ss"));

        Console.WriteLine(date1.AddHours(2));// add formatação

        Console.WriteLine(date1.AddMinutes(4));// add formatação

        Console.WriteLine(date1.AddSeconds(6));// add formatação

    } 

    public void Resource()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.DayOfWeek);
    }

    public void SomenteData()
    {
        var somenteData = DateOnly.Parse("2018/05/14");

        Console.WriteLine(somenteData);
    }

    public void SomenteHora()
    {
        var somenteHora = TimeOnly.Parse("12:52:55");//usar Tostring para formatar

        Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
    }
}