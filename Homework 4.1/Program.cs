namespace WorkerManager
{
    struct Worker
    {
        public int ID;
        public DateTime AddedDateTime;
        public string FullName;
        public int Age;
        public int Height;
        public DateTime DateOfBirth;
        public string PlaceOfBirth;
    }

    class Repository
    {
        private List<Worker> workers;

        public Repository()
        {
            workers = new List<Worker>();
        }

        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }

        public bool RemoveWorker(int id)
        {
            Worker worker = workers.Find(w => w.ID == id);
            return workers.Remove(worker);
        }

        public Worker FindWorker(int id)
        {
            return workers.Find(w => w.ID == id);
        }

        public List<Worker> LoadWorkersByDateRange(DateTime startDate, DateTime endDate)
        {
            List<Worker> filteredWorkers = new List<Worker>();
            foreach (Worker worker in workers)
            {
                if (worker.AddedDateTime >= startDate && worker.AddedDateTime <= endDate)
                {
                    filteredWorkers.Add(worker);
                }
            }
            return filteredWorkers;
        }

        public List<Worker> GetAllWorkers()
        {
            return new List<Worker>(workers);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();

            // Пример добавления записей
            repository.AddWorker(new Worker
            {
                ID = 1,
                AddedDateTime = DateTime.Now,
                FullName = "John Doe",
                Age = 30,
                Height = 180,
                DateOfBirth = new DateTime(1990, 1, 1),
                PlaceOfBirth = "New York"
            });

            repository.AddWorker(new Worker
            {
                ID = 2,
                AddedDateTime = DateTime.Now,
                FullName = "Jane Smith",
                Age = 25,
                Height = 165,
                DateOfBirth = new DateTime(1995, 5, 5),
                PlaceOfBirth = "Los Angeles"
            });

            // Пример просмотра всех записей
            List<Worker> allWorkers = repository.GetAllWorkers();
            Console.WriteLine("All Workers:");
            foreach (Worker worker in allWorkers)
            {
                Console.WriteLine($"ID: {worker.ID}, FullName: {worker.FullName}, Age: {worker.Age}");
            }

            // Пример просмотра одной записи по ID
            int idToFind = 1;
            Worker foundWorker = repository.FindWorker(idToFind);
            if (foundWorker.ID != 0)
            {
                Console.WriteLine($"Found Worker with ID {idToFind}: FullName: {foundWorker.FullName}, Age: {foundWorker.Age}");
            }
            else
            {
                Console.WriteLine($"Worker with ID {idToFind} not found");
            }

            // Пример удаления записи по ID
            int idToRemove = 2;
            bool success = repository.RemoveWorker(idToRemove);
            if (success)
            {
                Console.WriteLine($"Worker with ID {idToRemove} removed successfully");
            }
            else
            {
                Console.WriteLine($"Failed to remove Worker with ID {idToRemove}");
            }

            // Пример загрузки записей в выбранном диапазоне дат
            DateTime startDate = DateTime.Now.AddDays(-7);
            DateTime endDate = DateTime.Now;
            List<Worker> filteredWorkers = repository.LoadWorkersByDateRange(startDate, endDate);
            Console.WriteLine($"Workers added between {startDate} and {endDate}:");
            foreach (Worker worker in filteredWorkers)
            {
                Console.WriteLine($"ID: {worker.ID}, FullName: {worker.FullName}, Age: {worker.Age}, AddedDateTime: {worker.AddedDateTime}");
            }
        }
    }
}