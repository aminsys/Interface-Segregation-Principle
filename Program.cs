using System.Collections.ObjectModel;

namespace Interface_Segregataion_Principle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Collection<Record> records = new Collection<Record>();

            // initialize records
            records.Add(new Record { Id = 1001, Name = "Clippers container" });
            records.Add(new Record { Id = 1002, Name = "Dark violet coloring materials" });
            records.Add(new Record { Id = 1003, Name = "Pencils" });
            records.Add(new Record { Id = 1004, Name = "Axel shifter" });
            records.Add(new Record { Id = 1005, Name = "Salt despenser" });
            records.Add(new Record { Id = 1006, Name = "Rice grinder" });
            records.Add(new Record { Id = 1007, Name = "Polishing sand papers" });

            // Write records:
            DataSource ds = new DataSource();
            DataSourceWriter.WriteRecords(ds, records);
            
            // Read records:
            ICollection<int> ids = new Collection<int>() { 1001, 1003, 1006, 1007 };
            var result = DataSourceReader.ReadRecords(ds, ids);

            foreach (var record in result)
            {
                Console.WriteLine(record.Name);
            }
        } 
    }
}
