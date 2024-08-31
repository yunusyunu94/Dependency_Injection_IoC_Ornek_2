namespace Dependency_Injection_IoC_Ornek_2
{
    public class NumGenerator : INumGenerator
    {
        public int RandomValue { get; set; }
        public NumGenerator()
        {
            RandomValue = new Random().Next(1000);
        }

        //public int GetRandomNumber()
        //{
        //    //var f = Random.Shared.Next(minValue: 1, maxValue: 1000);
        //    //return f;
        //    return new Random().Next(1000); // 1-1000 arası sarı verecektir
        //}
    }

    public interface INumGenerator
    {
        //public int GetRandomNumber();

        int RandomValue { get;}
    }
}
