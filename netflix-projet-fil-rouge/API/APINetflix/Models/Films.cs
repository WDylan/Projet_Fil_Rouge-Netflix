namespace APINetflix.Models
{
    public class Films
    {
        private int id;
        private string titre;
        private int duree;
        private DateTime dateSortie;
        private string synopsys;
        private int recommandation;
        private Categorie categorieId;
        private Acteurs acteurId;
        private Realisateur realisateurId;

        public int Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }
        public int Duree { get => duree; set => duree = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }
        public string Synopsys { get => synopsys; set => synopsys = value; }
        public int Recommandation { get => recommandation; set => recommandation = value; }
        public Categorie CategorieId { get => categorieId; set => categorieId = value; }
        public Acteurs ActeurId { get => acteurId; set => acteurId = value; }
        public Realisateur RealisateurId { get => realisateurId; set => realisateurId = value; }
    }
}
