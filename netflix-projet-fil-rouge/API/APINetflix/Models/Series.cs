using APINetflix.Models.Connection;
using Microsoft.Data.SqlClient;

namespace APINetflix.Models
{
    public class Series : Categorie
    {
        private int idSerie;
        private string titre;
        private int nbEpisodes;
        private DateTime dateSortie;
        private string synopsis;
        private int recommandation;
        private string acteur_nom;
        private string realisateur_nom;
        private string url;
        private string video;
        string _request;
        SqlCommand _command;
        SqlConnection _connection;
        SqlDataReader _reader;


        public Series() : base(categ)
        {

        }
        public Series(int idSerie, string titre, int nbEpisodes, DateTime dateSortie, string synopsis, int recommandation, Realisateur realisateurNom)
        {
            IdSerie = idSerie;
            Titre = titre;
            NbEpisodes = nbEpisodes;
            DateSortie = dateSortie;
            Synopsis = synopsis;
            Recommandation = recommandation;
            RealisateurNom = realisateurNom;
        }


        public int IdSerie { get => idSerie; set => idSerie = value; }
        public string Titre { get => titre; set => titre = value; }
        public int NbEpisodes { get => nbEpisodes; set => nbEpisodes = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }
        public string Synopsis { get => synopsis; set => synopsis = value; }
        public int Recommandation { get => recommandation; set => recommandation = value; }
        public Realisateur RealisateurNom { get => realisateurNom; set => realisateurNom = value; }

    }
}

