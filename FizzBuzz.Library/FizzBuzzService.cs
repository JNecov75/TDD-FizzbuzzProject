namespace FizzBuzz.Library
{
    public class FizzBuzzService 
    {
        public string Print(int value)
        {
            if(value % 3 == 0)
            {
                return "fizz";
            }
            return value.ToString();
        }
    }
}