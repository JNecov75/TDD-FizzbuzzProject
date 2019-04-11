namespace FizzBuzz.Library
{
    public class FizzBuzzService 
    { 
        public string Print(int value)
        {
            if (IsDivisibleByThree(value) && IsDivisibleByFive(value))
            {
                return "fizzbuzz";
            }
            else if(IsDivisibleByThree(value))
            {
                return "fizz";
            }
            else if(IsDivisibleByFive(value))
            {
                return "buzz";
            }
            return value.ToString();
        }

        private bool IsDivisibleByThree(int value)
        {
            return value % 3 == 0;
        }
        
        private bool IsDivisibleByFive(int value)
        {
            return value % 5 == 0;
        }
    }
}