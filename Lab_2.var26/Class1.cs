namespace CheckTypeLibrary
{
    public class Class1
    {
        public static int? CheckType(string num)
        {
            int int_num = 0;
            try
            {
                int_num = Convert.ToInt32(num);
            }
            catch (FormatException)
            {
                return null;
            }
            return int_num;
        }
    }
}
