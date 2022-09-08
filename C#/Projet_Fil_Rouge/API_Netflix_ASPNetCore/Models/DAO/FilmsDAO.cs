using API_Netflix_ASPNetCore.Models.Classes;
using Microsoft.Data.SqlClient;

namespace API_Netflix_ASPNetCore.Models.DAO
{
    public class FilmsDAO : BaseDAO<Films>
    {
        public override int Create(Films element)
        {
            // Rédaction de la requête
            _request = "INSERT INTO FILMS(TITRE, GENRE, DUREE, DATESORTIE, SYNOPSIS, RECOMMANDATION, ACTEUR_NOM, REALISATEUR_NOM, IMAGE, VIDEO) OUTPUT INSERTED.ID VALUES (@Titre, @Genre, @NbEpisodes, @DateSortie, @Synopsis, @Recommandation,@Acteur_Nom, @Realisateur_Nom, @Image, @Video)";
            // Création d'une nouvelle instance de connection
            _connection = Connection.New;
            // Création de l'obget command
            _command = new SqlCommand(_request, _connection);
            // Ajout des params à la requête
            _command.Parameters.Add(new SqlParameter("@Titre", element.Titre));
            _command.Parameters.Add(new SqlParameter("@Genre", element.Genre));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", element.Duree));
            _command.Parameters.Add(new SqlParameter("@DateSortie", element.DateSortie));
            _command.Parameters.Add(new SqlParameter("@Synopsis", element.Synopsis));
            _command.Parameters.Add(new SqlParameter("@Recommandation", element.Recommandation));
            _command.Parameters.Add(new SqlParameter("@Acteur_Nom", element.Acteur_Nom));
            _command.Parameters.Add(new SqlParameter("@Realisateur_Nom", element.Realisateur_Nom));
            _command.Parameters.Add(new SqlParameter("@Image", element.Image));
            _command.Parameters.Add(new SqlParameter("@Video", element.Video));
            // Ouverture de la connection
            _connection.Open();
            // Execution de la command avec execut scalar (retourne la valeur d'un champ)
            element.IdFilm = (int)_command.ExecuteScalar();
            // Libération de l'obget command
            _command.Dispose();
            // Fermeture de la connection
            _connection.Close();
            return element.IdFilm;
        }

        public override bool Delete(int id)
        {
            Films film = new Films();
            // Création d'une instance de connection
            _connection = Connection.New;
            // Préparation de la command
            _request = "DELETE FILMS WHERE id=@IdFilm";
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la command
            _command.Parameters.Add(new SqlParameter("@IdFilm", id));

            // Execution de la command
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();

            // Fermeture de la connection
            _connection.Close();
            return (nbLignes > 0);
        }

        public override bool Delete(Films element)
        {
            throw new NotImplementedException();
        }

        public override Films Get(int index)
        {
            Films film = null;
            _connection = Connection.New;
            _request = "SELECT fil.titre, fil.genre, fil.duree, fil.datesortie, fil.synopsis, fil.recommandation, fil.acteur_nom, fil.realisateur_nom, fil.image, fil.video" +
                "FROM FILMS AS fil";
            _command = new SqlCommand(_request, _connection);
            _connection.Open();

            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                film = new Films();
                if (film != null)
                {
                    film = new Films()
                    {
                        IdFilm = _reader.GetInt32(0),
                        Titre = _reader.GetString(1),
                        Genre = _reader.GetString(2),
                        Duree = _reader.GetInt32(3),
                        DateSortie = _reader.GetDateTime(4),
                        Synopsis = _reader.GetString(5),
                        Recommandation = _reader.GetInt32(6),
                        Acteur_Nom = _reader.GetString(7),
                        Realisateur_Nom = _reader.GetString(8),
                        Image = _reader.GetString(9),
                        Video = _reader.GetString(10)
                    };
                    film.IdFilm = index;
                }

            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return film;
        }

        public override List<Films> Get(Func<Films, bool> criteria)
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

        public override List<Films> GetAll()
        {
            List<Films> films = new();
            _connection = Connection.New;
            _request = "SELECT fil.titre, fil.genre, fil.duree, fil.datesortie, fil.synopsis, fil.recommandation, fil.acteur_nom, fil.realisateur_nom, fil.image, fil.video" +
                "FROM FILMS AS fil";

            _command = new SqlCommand(_request, _connection);
            _connection.Open();

            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                Films f = null;
                if (f != null)
                {
                    f = new Films()
                    {
                        IdFilm = _reader.GetInt32(0),
                        Titre = _reader.GetString(1),
                        Genre = _reader.GetString(2),
                        Duree = _reader.GetInt32(3),
                        DateSortie = _reader.GetDateTime(4),
                        Synopsis = _reader.GetString(5),
                        Recommandation = _reader.GetInt32(6),
                        Acteur_Nom = _reader.GetString(7),
                        Realisateur_Nom = _reader.GetString(8),
                        Image = _reader.GetString(9),
                        Video = _reader.GetString(10)
                    };
                    films.Add(f);
                }
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return films;
        }

        public override bool Update(Films element)
        {
            _connection = Connection.New;
            _request = "UPDATE FILMS SET titre=@Titre, genre=@Genre, duree=@Duree, dateSortie=@DateSortie, synopsis=@Synopsis, recommandation = @recommandation, acteur_nom = @Acteur_Nom, realisateur_nom = @Realisateur_Nom, image = @Image, video=@Video" +
                " WHERE idfilm = @IdFilm";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("@Titre", element.Titre));
            _command.Parameters.Add(new SqlParameter("@Genre", element.Genre));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", element.Duree));
            _command.Parameters.Add(new SqlParameter("@DateSortie", element.DateSortie));
            _command.Parameters.Add(new SqlParameter("@Synopsis", element.Synopsis));
            _command.Parameters.Add(new SqlParameter("@Recommandation", element.Recommandation));
            _command.Parameters.Add(new SqlParameter("@Acteur_Nom", element.Acteur_Nom));
            _command.Parameters.Add(new SqlParameter("@Realisateur_Nom", element.Realisateur_Nom));
            _command.Parameters.Add(new SqlParameter("@Image", element.Image));
            _command.Parameters.Add(new SqlParameter("@Video", element.Video));
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();
            _command.Dispose();
            _connection.Close();

            return nbLignes == 0;
        }
    }
}
