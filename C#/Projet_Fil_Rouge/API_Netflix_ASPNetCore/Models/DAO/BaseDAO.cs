using Microsoft.Data.SqlClient;

namespace API_Netflix_ASPNetCore.Models.DAO
{
    public abstract class BaseDAO<T>
    {
        protected static SqlCommand _command;
        protected static SqlConnection _connection;
        protected static SqlDataReader _reader;
        protected static string _request;

        public abstract int Create(T element);
        public abstract bool Delete(int id);
        public abstract bool Delete(T element);
        public abstract bool Update(T element);

        public abstract T Get(int index);
        public abstract List<T> Get(Func<T, bool> criteria);
        public abstract List<T> GetAll();
    }
}
