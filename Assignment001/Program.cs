namespace Assignment001
{

    #region Question01
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            Console.WriteLine("Days of the week : ");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }

            #endregion

        }
    }
}