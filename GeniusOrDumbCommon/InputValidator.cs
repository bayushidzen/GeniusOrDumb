namespace GeniusOrDumbCommon
{
    public class InputValidator
    {
        public static bool IsValidInput(string inputString)
        {
            if (int.TryParse(inputString, out int number))
            {
                return number >= 1 && number <= 100000;
            }
            return false;
        }
    }
}
