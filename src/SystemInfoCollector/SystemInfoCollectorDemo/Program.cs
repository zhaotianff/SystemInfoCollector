namespace SystemInfoCollectorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = TianXiaTech.SystemInfoCollector.SystemInfoManager.CollectProcesses();

            foreach (var service in services)
            {
                foreach (var propertyInfo in service.GetType().GetProperties())
                {
                    Console.WriteLine(propertyInfo.Name + ":" + propertyInfo.GetValue(service));
                }

                Console.WriteLine();
            }
        }
    }
}