namespace Interface_Segregataion_Principle
{
    public interface IDataSourceReader
    {
        Record ReadRecord(int id);
    }
}