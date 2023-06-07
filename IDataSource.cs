namespace Interface_Segregataion_Principle
{
    // this interface doesn't follow the Interface Segregataion Principle of SOLID.
    public interface IDataSource
    {
        Record ReadRecord(int id);
        void WriteRecord(Record record);
    }
}