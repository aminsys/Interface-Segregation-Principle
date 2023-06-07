using System.Collections.ObjectModel;

namespace Interface_Segregataion_Principle
{
    public class DataSource : IDataSource
    {
        private readonly ICollection<Record> _records = new Collection<Record>();

        // public DataSource(ICollection<Record> records) => _records = records;

        public Record ReadRecord(int id) => _records.FirstOrDefault(r => r.Id == id);

        public void WriteRecord(Record record)
        {
            _records.Add(record);
        }
    }
}