
using API_Netflix_ASPNetCore.Models.DAO;

namespace API_Netflix_ASPNetCore
{
    public class Films
    {
        private int idFilm;
        private string titre;
        private string genre;
        private int nbEpisodes;
        private DateTime dateSortie;
        private string synopsis;
        private int recommandation;
        private string acteur_Nom;
        private string realisateur_Nom;
        private string image;
        private string video;

        public Films()
        {

        }

        public Films(string categ, int idFilm, string genre, string titre, int nbEpisodes, DateTime dateSortie, string synopsis, int recommandation, string realisateur_Nom, string acteur_Nom, string image, string video)
        {
            IdFilm = idFilm;
            Titre = titre;
            Genre = genre;
            NbEpisodes = nbEpisodes;
            DateSortie = dateSortie;
            Synopsis = synopsis;
            Recommandation = recommandation;
            Realisateur_Nom = realisateur_Nom;
            Acteur_Nom = acteur_Nom;
            Image = image;
            Video = video;
        }


        public int IdFilm { get => idFilm; set => idFilm = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Genre { get => genre; set => genre = value; }
        public int NbEpisodes { get => nbEpisodes; set => nbEpisodes = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }
        public string Synopsis { get => synopsis; set => synopsis = value; }
        public int Recommandation { get => recommandation; set => recommandation = value; }
        public string Acteur_Nom { get => acteur_Nom; set => acteur_Nom = value; }
        public string Realisateur_Nom { get => realisateur_Nom; set => realisateur_Nom = value; }
        public string Image { get => image; set => image = value; }
        public string Video { get => video; set => video = value; }


        private FilmsDAO filmDAO { get => new(); }



        public int AjouterFilm()
        {
            return filmDAO.Create(this);
        }


        public override string ToString()
        {
            return $"\nLe film n° {idFilm} : {Titre} - {Genre} - {NbEpisodes} épisodes - Publié le {DateSortie}\n" +
                $"Synopsis : {Synopsis}\n" +
                $"Realisateur : {Realisateur_Nom}\n" +
                $"Acteurs : {Acteur_Nom}\n";
        }
    }
}

