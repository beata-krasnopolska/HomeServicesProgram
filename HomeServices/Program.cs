using System;

namespace HomeServices
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job("wash windows", 3.5, 25);
            Console.WriteLine("job description: {0}, planning time: {1}, money rate {2}, total fee {3}", job1.JobDescr, job1.Time, job1.MoneyRate, job1.TotalFee);
            Job job2 = new Job("hoovering", 2.5, 30);
            Console.WriteLine("job description: {0}, planning time: {1}, money rate {2}, total fee {3}", job2.JobDescr, job2.Time, job2.MoneyRate, job2.TotalFee);

            Job job3 = job1 + job2;

            Console.WriteLine("job description: {0}, planning time: {1}, money rate {2}, total fee {3}", job3.JobDescr, job3.Time, job3.MoneyRate, job3.TotalFee);
            Console.ReadLine();
        }
    }
}
