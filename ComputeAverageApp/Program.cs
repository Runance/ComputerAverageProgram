namespace ComputeAverageApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int Grade = 0; ;
            double AveGrades = 0; 
            int ConGrade ;

            Console.WriteLine("Enter 5 Grades in seperated by newline!");
            for (int i = 0; i < 5; i++) {
                ConGrade = Convert.ToInt32(Console.ReadLine());
                Grade += ConGrade;
            }
            AveGrades = Grade / 5 ;
            Console.WriteLine("The Average is " + AveGrades + " and round off " + Math.Round(AveGrades) );
        }
       
    }
}