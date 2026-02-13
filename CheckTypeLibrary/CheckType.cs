namespace CheckTypeLibrary
{
    public class Class1
    {
        public static bool CheckDouble(string num)
        {
            try
            {
                Convert.ToDouble(num);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }

        public static bool CheckInt(string num)
        {
            try
            {
                Convert.ToInt32(num);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }
    }
}
