using APINetflix.Models;

namespace APINetflix.DAO
{
    public class FilmsDAO : BaseDAO<Films>
    {

       
        public override int Create(Films element)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Films element)
        {
            throw new NotImplementedException();
        }

        public override Films Find(int index)
        {
            throw new NotImplementedException();
        }

        public override List<Films> Find(Func<Films, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Films> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Films element)
        {
            throw new NotImplementedException();
        }
    }
}
