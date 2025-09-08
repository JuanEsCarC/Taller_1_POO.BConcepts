using Taller_1_POO.BConcepts.Core;


try
{
    var t1 = new Time(9, 34);

    Console.WriteLine($"Time: {t1}");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}