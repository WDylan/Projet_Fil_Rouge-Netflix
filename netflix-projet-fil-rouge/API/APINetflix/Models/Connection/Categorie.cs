namespace APINetflix.Models.Connection
{
    public class Categorie
    {
        private int idCat;
        private string categ;

        public Categorie(int idCat, string name)
        {
            IdCat = idCat;
            Categ = name;
        }

        public int IdCat { get => idCat; set => idCat = value; }
        public string Categ { get => categ; set => categ = value; }
    }
}
