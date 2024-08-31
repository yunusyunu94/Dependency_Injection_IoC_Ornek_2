namespace Dependency_Injection_IoC_Ornek_2
{
    public class NumGenerater2 : INumGenerater2
    {
        private readonly INumGenerator _numGenerator;

        public int RandomValue { get; }


        public NumGenerater2(INumGenerator numGenerator)
        {
            RandomValue = new Random().Next(1000); 

            _numGenerator = numGenerator;
        }

        public int GetNumGeneratorRandomNumber()
        {
            return _numGenerator.RandomValue;
        }
    }

    public interface INumGenerater2
    {
        public int RandomValue { get; }

        public int GetNumGeneratorRandomNumber(); 
    }
}
