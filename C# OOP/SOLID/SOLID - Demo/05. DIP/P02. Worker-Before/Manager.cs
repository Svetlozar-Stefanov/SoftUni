namespace P02._Worker_Before
{
    public class Manager
    {
        private IWorker worker;
        public Manager(IWorker worker)
        {
            this.worker = worker;
            worker.Work();
        }
    }
}
