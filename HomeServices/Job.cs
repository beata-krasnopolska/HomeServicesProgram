namespace HomeServices
{
    class Job
    {
        private string jobDescr;
        private double time;
        private double moneyRate;
        private double totalFee;

        public Job (string jobDescr, double time, double moneyRate)
        {
            JobDescr = jobDescr;
            Time = time;
            MoneyRate = moneyRate;            
        }
        public string JobDescr
        {
            get
            {
                return jobDescr;
            }
            set
            {
                jobDescr = value;
            }
        }
        public double Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                CalcTotalFee();
            }
        }
        public double MoneyRate
        {
            get
            {
                return moneyRate;
            }
            set
            {
                moneyRate = value;
                CalcTotalFee();
            }
        }
        public double TotalFee
        {
            get
            {
                return totalFee;
            }
        }    
        public static Job operator + (Job job1, Job job2)
        {
            string NewJobDescr = job1.JobDescr +" and " + job2.JobDescr;
            double NewTime = job1.Time + job2.Time;
            double NewMoneyRate = (job1.MoneyRate + job2.moneyRate)/2;
            //double NewTotalFee = NewMoneyRate * NewTime;

            Job newJob = new Job(NewJobDescr, NewTime, NewMoneyRate);
            return newJob;
        }
        private void CalcTotalFee()
        {
            totalFee = moneyRate * time;
        }
    }
}
