interface IDataAccess<T>
{
    void AddData(T data);
    T GetData(int id);
}