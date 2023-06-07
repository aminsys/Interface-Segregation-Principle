namespace Interface_Segregataion_Principle
{
    public class DataSourceWriter
    {
        public static void WriteRecords(IDataSource dataSource, ICollection<Record> records)
        {
            foreach(var r in records)
            {
                dataSource.WriteRecord(r);
            }
        }

        // This should not be allowed.
        // public static ICollection<Record> ReadRecords(IDataSource dataSource, ICollection<int> ids)
        // {
        //     var result = new Collection<Record>();
        //     foreach(var id in ids)
        //     {
        //         result.Add(dataSource.ReadRecord(id));
        //     }

        //     return result;
        // }
    }
}