namespace Assignment2OOP
{
    internal class Program
    {
        #region Compare Between To HireDate (IsGraterThan Function)
        public static bool IsGraterThan(HireDate date1, HireDate date2)
        {
            try
            {
                bool DayFlag = int.TryParse(date1.day, out int Day1);
                bool MonthFlag = int.TryParse(date1.month, out int Month1);
                bool YearFlag = int.TryParse(date1.year, out int Year1);
                if (DayFlag && MonthFlag && YearFlag)
                {
                    DayFlag = int.TryParse(date2.day, out int Day2);
                    MonthFlag = int.TryParse(date2.month, out int Month2);
                    YearFlag = int.TryParse(date2.year, out int Year2);
                    if (DayFlag && MonthFlag && DayFlag)
                    {
                        if (Year1 < Year2)
                        {
                            return true;
                        }
                        if (Year2 == Year1)
                        {
                            if (Month1 < Month2)
                            {
                                return true;
                            }
                            if (Month1 == Month2)
                            {
                                if (Day1 < Day2)
                                {
                                    return true;
                                }
                            }
                            return false;
                        }
                    }
                    return false;
                }
                throw new Exception("Invalid Date");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        #endregion


        #region Sort Employees Array
        public static void sortEmployees(Employee[] Employees)
        {
            if (Employees is not null)
            {
                for (int i = 0; i < Employees.Length - 1; i++)
                {
                    for (int j = 0; j < Employees.Length - i - 1; j++)
                    {
                        if (!IsGraterThan(Employees[j].hireDate, Employees[j + 1].hireDate))
                        {
                            Employee tmp = Employees[j];
                            Employees[j] = Employees[j + 1];
                            Employees[j + 1] = tmp;
                        }
                    }
                }
            }
        } 
        #endregion
        static void Main(string[] args)
        {

            #region Declare the Variables
            Employee[] Employees = new Employee[3];
            Employees[0] = new Employee(3, "Ayman Amr", 3000, Gender.M, new HireDate("18", "06", "2024"), securityLevel.DBA);
            Employees[1] = new Employee(2, "Nada", 2000, Gender.F, new HireDate("10", "11", "2024"), securityLevel.guest);
            Employees[2] = new Employee(1, "Ahmed Amr", 10000, Gender.M, new HireDate("30", "05", "2005"), (securityLevel)15);
            #endregion

            #region Before Sorting
            Console.WriteLine($"-------------------*Employees Before Sorting*-------------------");

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine($"Employee number {i + 1} :");
                Console.WriteLine(Employees[i]);
                Console.WriteLine("--------------------------------------------------------------");
            } 
            #endregion

            sortEmployees(Employees);

            #region After Sorting
            Console.WriteLine($"-------------------*Employees After Sorting*-------------------");

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine($"Employee number {i + 1} :");
                Console.WriteLine(Employees[i]);
                Console.WriteLine("--------------------------------------------------------------");
            } 
            #endregion


        }
    }
}
