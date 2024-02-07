using System;

namespace ConsoleApp2
{
    public interface IWorker
    {
        void Enrollment();
        void Dispatch();
        int GetWorkerID();
    }
}
