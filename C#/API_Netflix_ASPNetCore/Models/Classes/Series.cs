
using API_Netflix_ASPNetCore.Models.Classes;
using API_Netflix_ASPNetCore.Models.DAO;
using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace API_Netflix_ASPNetCore
{

    public class Series
    {
        private int idSerie;
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
        private SqlConnection _connection;
        private string _request;
        private SqlCommand _command;
        private SqlDataReader _reader;
        private static List<Series> serie;

        public Series()
        {
            DateSortie = DateTime.Now;
        }

        public Series(int idSerie, string titre, string genre, int nbEpisodes, DateTime dateSortie, string synopsis, int recommandation, string realisateur_Nom, string acteur_Nom, string image, string video)
        {
            IdSerie = idSerie;
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


        public int IdSerie { get => idSerie; set => idSerie = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Genre { get => genre; set => genre = value; }
        public int NbEpisodes { get => nbEpisodes; set => nbEpisodes = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }
        public string Synopsis { get => synopsis; set => synopsis = value; }
        public string Acteur_Nom { get => acteur_Nom; set => acteur_Nom = value; }
        public string Realisateur_Nom { get => realisateur_Nom; set => realisateur_Nom = value; }
        public int Recommandation { get => recommandation; set => recommandation = value; }
        public string Image { get => image; set => image = value; }
        public string Video { get => video; set => video = value; }
        public static List<Series> Serie { get => serie; set => serie = value; }

        //private SeriesDAO serieDAO { get => new(); }

        public static List<Series> GetAll()
        {
            List<Series > series = new List<Series>();
            SqlConnection connection = Connection.New;
            string request = "SELECT * FROM SERIES";

            SqlCommand command = new SqlCommand(request, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Series s = new Series()
                {
                    IdSerie = reader.GetInt32(0),
                    Titre = reader.GetString(1),
                    Genre = reader.GetString(2),
                    NbEpisodes = reader.GetInt32(3),
                    DateSortie = reader.GetDateTime(4),
                    Synopsis = reader.GetString(5),
                    Acteur_Nom = reader.GetString(6),
                    Realisateur_Nom = reader.GetString(7),
                    Recommandation = reader.GetInt32(8),
                    Image = reader.GetString(9),
                    Video = reader.GetString(10)
                };
                series.Add(s);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return series;
        }

        public static List<Series> Find(Func<Series, bool> criterie)
        {
            List<Series> series = new List<Series>();
            GetAll().ForEach(f =>
            {
                if (criterie(f))
                {
                    series.Add(f);
                }
            });
            return series;
        }

        public static List<Series> SearchSerie(string search)
        {
            return Find(s => s.Titre.Contains(search) || s.Acteur_Nom.Contains(search) || s.Realisateur_Nom.Contains(search) || s.Genre.Contains(search));
        }


        public int Add()
        {
            // Création d'une instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "SELECT titre, genre,nbepisodes, datesortie, synopsis, recommandation, acteur_nom, realisateur_nom, image, video" +
                "OUTPUT INSERTED.ID VALUES (@Titre, @Genre, @NbEpisodes, @DateSortie, @Synopsis, @Recommandation, @Acteur_Nom, @Realisateur_Nom, @Image, @Video)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Titre", Titre));
            _command.Parameters.Add(new SqlParameter("@Genre", Genre));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@DateSortie", DateSortie));
            _command.Parameters.Add(new SqlParameter("@Synopsis", Synopsis));
            _command.Parameters.Add(new SqlParameter("@Recommandation", Recommandation));
            _command.Parameters.Add(new SqlParameter("@Acteur_Nom", Acteur_Nom));
            _command.Parameters.Add(new SqlParameter("@Realisateur_Nom", Realisateur_Nom));
            _command.Parameters.Add(new SqlParameter("@Image", Image));
            _command.Parameters.Add(new SqlParameter("@Video", Video));

            // Execution de la commande

            int Id = (int)_command.ExecuteScalar();

            // Libération de l'objet command
            _command.Dispose();
            // Fermeture de la connection
            _connection.Close();

            return Id;
        }

        public virtual bool Update()
        {
            _connection = Connection.New;
            _request = "UPDATE SERIES SET titre=@Titre, genre=@Genre, nbepisodes=@NbEpisodes, dateSortie=@DateSortie, synopsis=@Synopsis, recommandation = @recommandation, acteur_nom = @Acteur_Nom, realisateur_nom = @Realisateur_Nom, image = @Image, video=@Video" +
                " WHERE idserie = @IdSerie";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("@Titre", Titre));
            _command.Parameters.Add(new SqlParameter("@Genre", Genre));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@DateSortie", DateSortie));
            _command.Parameters.Add(new SqlParameter("@Synopsis", Synopsis));
            _command.Parameters.Add(new SqlParameter("@Recommandation", Recommandation));
            _command.Parameters.Add(new SqlParameter("@Acteur_Nom", Acteur_Nom));
            _command.Parameters.Add(new SqlParameter("@Realisateur_Nom", Realisateur_Nom));
            _command.Parameters.Add(new SqlParameter("@Image", Image));
            _command.Parameters.Add(new SqlParameter("@Video", Video));
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }

        public virtual bool Delete()
        {
            // Création d'une instance de connection
            _connection = Connection.New;
            // Préparation de la command
            _request = "DELETE SERIES WHERE id=@IdSerie";
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la command
            _command.Parameters.Add(new SqlParameter("@IdSerie", IdSerie));

            // Execution de la command
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();

            // Fermeture de la connection
            _connection.Close();
            return (nbLignes > 0);
        }


        public override string ToString()
        {
            return $"\nSérie n° {idSerie} : {Titre} - {Genre} - {NbEpisodes} épisodes - Publié le {DateSortie}\n" +
                $"Synopsis : {Synopsis}\n" +
                $"Realisateur : {Realisateur_Nom}\n" +
                $"Acteurs : {Acteur_Nom}\n";
        }
    }
}
