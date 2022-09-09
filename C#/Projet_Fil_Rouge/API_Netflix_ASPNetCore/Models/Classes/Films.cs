using API_Netflix_ASPNetCore.Models.Classes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Xml.Linq;

namespace API_Netflix_ASPNetCore
{
    public class Films
    {
        private int idFilm;
        private string titre;
        private string genre;
        private int duree;
        private DateTime dateSortie;
        private string synopsis;
        private int recommandation;
        private string acteur_Nom;
        private string realisateur_Nom;
        private string image;
        private string video;
        private string _request;
        private SqlCommand _command;
        private SqlConnection _connection;
        private SqlDataReader _reader;
        private static List<Films> film;

        public Films()
        {
            DateSortie = DateTime.Now;
        }

        public Films(int idFilm, string titre, string genre, int duree, DateTime dateSortie, string synopsis, int recommandation, string realisateur_Nom, string acteur_Nom, string image, string video)
        {
            IdFilm = idFilm;
            Titre = titre;
            Genre = genre;
            Duree = duree;
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
        public int Duree { get => duree; set => duree = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }
        public string Synopsis { get => synopsis; set => synopsis = value; }
        public string Acteur_Nom { get => acteur_Nom; set => acteur_Nom = value; }
        public string Realisateur_Nom { get => realisateur_Nom; set => realisateur_Nom = value; }
        public int Recommandation { get => recommandation; set => recommandation = value; }
        public string Image { get => image; set => image = value; }
        public string Video { get => video; set => video = value; }
        public static List<Films> Film { get => film; set => film = value; }


        //private FilmsDAO filmDAO { get => new(); }



        public static Films Get(int id)
        {
            Films film = null;
            SqlConnection _connection = Connection.New;

            string _request = "SELECT * FROM FILMS WHERE idfilm =@IdFilm";

            SqlCommand _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@IdFilm", id));

            _connection.Open();

            SqlDataReader _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                film = new Films()
                {
                    IdFilm = _reader.GetInt32(0),
                    Titre = _reader.GetString(1),
                    Genre = _reader.GetString(2),
                    Duree = _reader.GetInt32(3),
                    DateSortie = _reader.GetDateTime(4),
                    Synopsis = _reader.GetString(5),
                    Acteur_Nom = _reader.GetString(6),
                    Realisateur_Nom = _reader.GetString(7),
                    Recommandation = _reader.GetInt32(8),
                    Image = _reader.GetString(9),
                    Video = _reader.GetString(10)
                };
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return film;
        }

        public static List<Films> GetAll()
        {
            List<Films> films = new List<Films>();
            SqlConnection connection = Connection.New;
            string request = "SELECT * FROM FILMS"; ;

            SqlCommand command = new SqlCommand(request, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Films film = new Films()
                {
                    IdFilm = reader.GetInt32(0),
                    Titre = reader.GetString(1),
                    Genre = reader.GetString(2),
                    Duree = reader.GetInt32(3),
                    DateSortie = reader.GetDateTime(4),
                    Synopsis = reader.GetString(5),
                    Acteur_Nom = reader.GetString(6),
                    Realisateur_Nom = reader.GetString(7),
                    Recommandation = reader.GetInt32(8),
                    Image = reader.GetString(9),
                    Video = reader.GetString(10)
                };
                films.Add(film);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return films;
        }

        public static List<Films> Find(Func<Films, bool> criterie)
        {
            List<Films> films = new List<Films>();
            GetAll().ForEach(f =>
            {
                if (criterie(f))
                {
                    films.Add(f);
                }
            });
            return films;
        }

        public static List<Films> SearchFilm(string search)
        {
            return Find(f => f.Titre.Contains(search) || f.Acteur_Nom.Contains(search) || f.Realisateur_Nom.Contains(search) || f.Genre.Contains(search));
        }

        public int Add()
        {
            // Création d'une instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "INSERT INTO FILMS (titre, genre, duree, datesortie, synopsis, acteur_nom, realisateur_nom, recommandation, image, video)" +
                "OUTPUT INSERTED.IDFILM VALUES (@Titre, @Genre, @Duree, @DateSortie, @Synopsis, @Acteur_Nom, @Realisateur_Nom, @Recommandation,  @Image, @Video)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Titre", Titre));
            _command.Parameters.Add(new SqlParameter("@Genre", Genre));
            _command.Parameters.Add(new SqlParameter("@Duree", Duree));
            _command.Parameters.Add(new SqlParameter("@DateSortie", DateSortie));
            _command.Parameters.Add(new SqlParameter("@Synopsis", Synopsis));
            _command.Parameters.Add(new SqlParameter("@Acteur_Nom", Acteur_Nom));
            _command.Parameters.Add(new SqlParameter("@Realisateur_Nom", Realisateur_Nom));
            _command.Parameters.Add(new SqlParameter("@Recommandation", Recommandation));
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

        public virtual bool Update()
        {
            _connection = Connection.New;
            _request = "UPDATE FILMS SET titre=@Titre, genre=@Genre, duree=@Duree, dateSortie=@DateSortie, synopsis=@Synopsis, acteur_nom = @Acteur_Nom, realisateur_nom = @Realisateur_Nom, recommandation = @recommandation, image = @Image, video=@Video WHERE idfilm = @IdFilm";
            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@IdFilm", IdFilm));
            _command.Parameters.Add(new SqlParameter("@Titre", Titre));
            _command.Parameters.Add(new SqlParameter("@Genre", Genre));
            _command.Parameters.Add(new SqlParameter("@Duree", Duree));
            _command.Parameters.Add(new SqlParameter("@DateSortie", DateSortie));
            _command.Parameters.Add(new SqlParameter("@Synopsis", Synopsis));
            _command.Parameters.Add(new SqlParameter("@Acteur_Nom", Acteur_Nom));
            _command.Parameters.Add(new SqlParameter("@Realisateur_Nom", Realisateur_Nom));
            _command.Parameters.Add(new SqlParameter("@Recommandation", Recommandation));
            _command.Parameters.Add(new SqlParameter("@Image", Image));
            _command.Parameters.Add(new SqlParameter("@Video", Video));
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }

        public bool Delete()
        {
            // Création d'une instance de connection
            _connection = Connection.New;
            // Préparation de la command
            _request = "DELETE FILMS WHERE idfilm=@IdFilm";
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la command
            _command.Parameters.Add(new SqlParameter("@IdFilm", IdFilm));

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
            return $"\nLe film n° {idFilm} : {Titre} - {Genre} - {Duree} minutes - Publié le {DateSortie}\n" +
                $"Synopsis : {Synopsis}\n" +
                $"Realisateur : {Realisateur_Nom}\n" +
                $"Acteurs : {Acteur_Nom}\n";
        }
    }
}