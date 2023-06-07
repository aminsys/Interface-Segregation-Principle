using System.Collections.ObjectModel;

namespace Interface_Segregataion_Principle
{

    public class DataSourceReader
    {
        public static ICollection<Record> ReadRecords(IDataSource dataSource, ICollection<int> ids)
        {
            var result = new Collection<Record>();
            foreach(var id in ids)
            {
                result.Add(dataSource.ReadRecord(id));
            }

            return result;
        }
    }
    
}