using Microsoft.Data.SqlClient;
using System;
using System.Net;

namespace APINetflix.Models
{
    public class Films : Categorie
    {
        private int idFilm;
        private string titre;
        private int nbEpisodes;
        private DateTime dateSortie;
        private string synopsis;
        private int recommandation;
        private string acteur_Nom;
        private string realisateur_Nom;
        private string image;
        private string video;
        string _request;
        SqlCommand _command;
        SqlConnection _connection;
        SqlDataReader _reader;

        public Films()
        {

        }

        public Films(string categ, int idFilm, string titre, int nbEpisodes, DateTime dateSortie, string synopsis, int recommandation, string realisateur_Nom, string acteur_Nom, string image, string video) : base(categ)
        {
            IdFilm = idFilm;
            Titre = titre;
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
        public int NbEpisodes { get => nbEpisodes; set => nbEpisodes = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }
        public string Synopsis { get => synopsis; set => synopsis = value; }
        public int Recommandation { get => recommandation; set => recommandation = value; }
        public string Acteur_Nom { get => acteur_Nom; set => acteur_Nom = value; }
        public string Realisateur_Nom { get => realisateur_Nom; set => realisateur_Nom = value; }
        public string Image { get => image; set => image = value; }
        public string Video { get => video; set => video = value; }

        public (bool, Films) Get(int id)
        {
            Films film = null;
            bool found = false;
            // Création d'un instance de connection
            _connection = Connection.Connection.New;

            // Prépartion de la commande
            _request = "SELECT film.idfilm, film.titre, film.nbEpisodes, film.dateSortie, film.synopsis, film.recommandation, film.auteur_nom, film.realisateur_nom, film.image, film.video" +
                "cat.idcat, cat.categ" +
                "FROM FILMS AS film" +
                "INNER JOIN CATEGORIE AS cat ON cat.Categorie_ID = cat.IdCat" +
                "WHERE film.idfilm = @Id";

            _command = new SqlCommand(_request, _connection);
            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@IdFilm", id));

            // Ouverture de la connexion
            _connection.Open();

            // Execution de la commande
            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                film = new Films()
                {
                    Categ = _reader.GetString(0),
                    IdFilm = _reader.GetInt32(1),
                    Titre = _reader.GetString(2),
                    NbEpisodes = _reader.GetInt32(3),
                    DateSortie = _reader.GetDateTime(4),
                    Synopsis = _reader.GetString(5),
                    Recommandation = _reader.GetInt32(6),
                    Acteur_Nom = _reader.GetString(7),
                    Realisateur_Nom = _reader.GetString(8),
                    Image = _reader.GetString(9),
                    Video = _reader.GetString(10),
                };
                found = true;
            }
            _reader.Close();

            // Libération de l'objet command
            _command.Dispose();

            // Fermeture de la connection à la BDD
            _connection.Close();

            // Retour de la liste de contact
            return (found, film);
        }

        public static List<Films> GetAll()
        {
            //ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();  // Avec WPF
            List<Films> films = new List<Films>();

            // Création d'un instance de connection
            SqlConnection connection = Connection.Connection.New;

            // Prépartion de la commande
            string request = "SELECT film.idfilm, film.titre, film.nbEpisodes, film.dateSortie, film.synopsis, film.recommandation, film.auteur_nom, film.realisateur_nom, film.image, film.video" +
                "cat.idcat, cat.categ" +
                "FROM FILMS AS film" +
                "INNER JOIN CATEGORIE AS cat ON cat.Categorie_ID = cat.IdCat";

            // Préparation de la commande
            SqlCommand command = new SqlCommand(request, connection);

            // Ouverture de la connexion
            connection.Open();

            // Execution de la commande
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Films film = new Films()
                {
                    Categ = reader.GetString(0),
                    IdFilm = reader.GetInt32(1),
                    Titre = reader.GetString(2),
                    NbEpisodes = reader.GetInt32(3),
                    DateSortie = reader.GetDateTime(4),
                    Synopsis = reader.GetString(5),
                    Recommandation = reader.GetInt32(6),
                    Acteur_Nom = reader.GetString(7),
                    Realisateur_Nom = reader.GetString(8),
                    Image = reader.GetString(9),
                    Video = reader.GetString(10),
                };
                films.Add(film);
            }
            reader.Close();

            // Libération de l'objet command
            command.Dispose();

            // Fermeture de la connection à la BDD
            connection.Close();

            // Retour de la liste de contact
            return films;
        }

        public override int Add()
        {
            // Création d'une instance de connection
            _connection = Connection.Connection.New;
            // Ajout de la personne en BDD
            int idCat = base.Add();

            if (idCat > 0)
            {
                // Prépartion de la commande
                _request = "INSERT INTO Films (titre, nbepisodes, datesortie, synopsis, recommandation, acteur_nom, realisateur_nom, image, video)" +
                    "OUTPUT INSERTED.ID VALUES (@Titre, @NbEpisodes, @DateSortie, @Synopsis, @Recommandation, @Acteur_Nom, @Realisateur_Nom, @Image, @Video)";

                // Préparation de la commande
                _command = new SqlCommand(_request, _connection);

                // Ajout des paramètres de la commande
                _command.Parameters.Add(new SqlParameter("@Titre", Titre));
                _command.Parameters.Add(new SqlParameter("@NbEpisodes", NbEpisodes));
                _command.Parameters.Add(new SqlParameter("@DateSortie", DateSortie));
                _command.Parameters.Add(new SqlParameter("@Synopsis", Synopsis));
                _command.Parameters.Add(new SqlParameter("@Recommandation", Recommandation));
                _command.Parameters.Add(new SqlParameter("@Acteur_Nom", Acteur_Nom));
                _command.Parameters.Add(new SqlParameter("@Realisateur_Nom", Realisateur_Nom));
                _command.Parameters.Add(new SqlParameter("@Image", Image));
                _command.Parameters.Add(new SqlParameter("@Video", Video));

                // Execution de la commande
                _connection.Open();
                int Id = (int)_command.ExecuteScalar();

                // Libération de l'objet command
                _command.Dispose();
                // Fermeture de la connection
                _connection.Close();

                return Id;
            }
            else
                return -1;
        }

        public static List<Films> SearchFilms(string search)
        {
            return Find(f => f.Titre.Contains(search) || f.Acteur_Nom.Contains(search) || f.Realisateur_Nom.Contains(search));
        }

        public static List<Films> Find(Func<Films, bool> criteria)
        {
            List<Films> films = new List<Films>();
            GetAll().ForEach(s =>
            {
                if (criteria(s))
                {
                    films.Add(s);
                }
            });
            return films;
        }

        public override bool Update()
        {
            // Création d'une instance de connection
            _connection = Connection.Connection.New;

            // Prépartion de la commande
            _request = "UPDATE FILMS SET titre=@Titre, nbEpisodes=@NbEpisodes, dateSortie=@DateSortie, synopsis=@Synopsis, recommandation = @recommandation, acteur_nom = @Acteur_Nom, realisateur_nom = @Realisateur_Nom, image = @Image, video=@Video" +
                " OUTPUT INSERTED.IdCat WHERE id=@IdFilm ";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Titre", Titre));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@DateSortie", DateSortie));
            _command.Parameters.Add(new SqlParameter("@Synopsis", Synopsis));
            _command.Parameters.Add(new SqlParameter("@Recommandation", Recommandation));
            _command.Parameters.Add(new SqlParameter("@Acteur_Nom", Acteur_Nom));
            _command.Parameters.Add(new SqlParameter("@Realisateur_Nom", Realisateur_Nom));
            _command.Parameters.Add(new SqlParameter("@Image", Image));
            _command.Parameters.Add(new SqlParameter("@Video", Video));

            // Execution de la commande
            _connection.Open();

            // Execution de la commande
            int idCat = (int)_command.ExecuteScalar();

            // Libération de l'objet command
            _command.Dispose();

            // Prépartion de la commande
            _request = "UPDATE CATEGORIE SET categ=@Categ WHERE id=@IdCat ";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande           
            _command.Parameters.Add(new SqlParameter("@Categ", Categ));
            _command.Parameters.Add(new SqlParameter("@IdCat", IdCat));

            // Execution de la commande
            _command.ExecuteNonQuery();
            // Execution de la commande
            int NbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();

            // Fermeture de la connection
            _connection.Close();

            return NbLignes > 0;
        }

        public (bool, string) Delete()
        {
            Categorie categ = new() { IdCat = IdCat };
            try
            {
                categ.Delete();
            }
            catch (Exception e)
            {
                return (false, e.Message);
            }

            // Création d'un instance de connection
            _connection = Connection.Connection.New;

            // Prépartion de la commande
            _request = "DELETE FILMS WHERE id=@IdFilm";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Id", IdFilm));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return (nbLignes > 0, nbLignes > 0 ? $"Le film n°{idFilm} : {Titre} à été supprimé" : "Erreur lors de la suppression du contact");
        }

        public override string ToString()
        {
            return $"\n{base.ToString()}\nLe film n° {idFilm} : {Titre} - {NbEpisodes} épisodes - Publié le {DateSortie}\n" +
                $"Synopsis : {Synopsis}\n" +
                $"Realisateur : {Realisateur_Nom}\n" +
                $"Acteurs : {Acteur_Nom}\n";
        }
    }
}
