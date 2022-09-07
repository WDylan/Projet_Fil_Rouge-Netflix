using Microsoft.Data.SqlClient;
using APINetflix.Models.Connection;
using System;
using APINetflix.DAO;
using APINetflix.Models;

namespace APIAspNetCore.Models.DAO
{
    public class SerieDAO : BaseDAO<Series>
    {
        public override int Create(Series element)
        {
            // Rédaction de la requête
            _request = "INSERT INTO SERIES(TITRE, GENRE, NBEPISODES, DATESORTIE, SYNOPSIS, RECOMMANDATION, ACTEUR_NOM, REALISATEUR_NOM, IMAGE, VIDEO) OUTPUT INSERTED.ID VALUES (@Titre, @Genre, @NbEpisodes, @DateSortie, @Synopsis, @Recommandation,@Acteur_Nom, @Realisateur_Nom, @Image, @Video)";
            // Création d'une nouvelle instance de connection
            _connection = Connection.New;
            // Création de l'obget command
            _command = new SqlCommand(_request, _connection);
            // Ajout des params à la requête
            _command.Parameters.Add(new SqlParameter("@Titre", element.Titre));
            _command.Parameters.Add(new SqlParameter("@Genre", element.Genre));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", element.NbEpisodes));
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
            element.IdSerie = (int)_command.ExecuteScalar();
            // Libération de l'obget command
            _command.Dispose();
            // Fermeture de la connection
            _connection.Close();
            return element.IdSerie;
        }

        public override bool Delete(int id)
        {
            Series serie = new Series();
            // Création d'une instance de connection
            _connection = Connection.New;
            // Préparation de la command
            _request = "DELETE SERIES WHERE id=@IdSerie";
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la command
            _command.Parameters.Add(new SqlParameter("@IdSerie", id));

            // Execution de la command
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();

            // Fermeture de la connection
            _connection.Close();
            return (nbLignes > 0);
        }

        public override bool Delete(Series element)
        {
            throw new NotImplementedException();
        }

        public override Series Find(int index)
        {
            Series serie = null;
            // Création d'une instance de connection
            _connection = Connection.New;
            // Préparation de la command
            _request = "SELECT ser.titre, ser.genre, ser.nbepisodes, ser.datesortie, ser.synopsis, ser.recommandation, ser.acteur_nom, ser.realisateur_nom, ser.image, ser.video" +
                "FROM SERIES AS ser";
            _command = new SqlCommand(_request, _connection);

            // Execution de la command
            _connection.Open();

            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                serie = new Series();
                if (serie != null)
                {
                    serie = new Series()
                    {
                        IdSerie = _reader.GetInt32(0),
                        Titre = _reader.GetString(1),
                        Genre = _reader.GetString(2),
                        NbEpisodes = _reader.GetInt32(3),
                        DateSortie = _reader.GetDateTime(4),
                        Synopsis = _reader.GetString(5),
                        Recommandation = _reader.GetInt32(6),
                        Acteur_Nom = _reader.GetString(7),
                        Realisateur_Nom = _reader.GetString(8),
                        Image = _reader.GetString(9),
                        Video = _reader.GetString(10)
                    };
                    serie.IdSerie = index;
                }

            }
            _reader.Close();
            // Libération de l'objet command
            _command.Dispose();
            // Fermeture de la connection
            _connection.Close();
            return serie;
        }

        public override List<Series> Find(Func<Series, bool> criteria)
        {
            List<Series> series = new List<Series>();
            FindAll().ForEach(s =>
            {
                if (criteria(s))
                {
                    series.Add(s);
                }
            });
            return series;
        }

        public override List<Series> FindAll()
        {
            List<Series> series = new();
            _connection = Connection.New;
            _request = "SELECT ser.titre, ser.genre, ser.nbepisodes, ser.datesortie, ser.synopsis, ser.recommandation, ser.acteur_nom, ser.realisateur_nom, ser.image, ser.video" +
                "FROM SERIES AS ser";

            _command = new SqlCommand(_request, _connection);
            _connection.Open();

            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                Series s = null;
                if (s != null)
                {
                    s = new Series()
                    {
                        IdSerie = _reader.GetInt32(0),
                        Titre = _reader.GetString(1),
                        Genre = _reader.GetString(2),
                        NbEpisodes = _reader.GetInt32(3),
                        DateSortie = _reader.GetDateTime(4),
                        Synopsis = _reader.GetString(5),
                        Recommandation = _reader.GetInt32(6),
                        Acteur_Nom = _reader.GetString(7),
                        Realisateur_Nom = _reader.GetString(8),
                        Image = _reader.GetString(9),
                        Video = _reader.GetString(10)
                    };
                    series.Add(s);
                }
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return series;
        }

        public override bool Update(Series element)
        {
            _connection = Connection.New;
            _request = "UPDATE SERIES SET titre=@Titre, genre=@Genre, nbEpisodes=@NbEpisodes, dateSortie=@DateSortie, synopsis=@Synopsis, recommandation = @recommandation, acteur_nom = @Acteur_Nom, realisateur_nom = @Realisateur_Nom, image = @Image, video=@Video" +
                " WHERE idserie = @IdSerie";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("@Titre", element.Titre));
            _command.Parameters.Add(new SqlParameter("@Genre", element.Genre));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", element.NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@DateSortie", element.DateSortie));
            _command.Parameters.Add(new SqlParameter("@Synopsis", element.Synopsis));
            _command.Parameters.Add(new SqlParameter("@Recommandation", element.Recommandation));
            _command.Parameters.Add(new SqlParameter("@Acteur_Nom", element.Acteur_Nom));
            _command.Parameters.Add(new SqlParameter("@Realisateur_Nom", element.Realisateur_Nom));
            _command.Parameters.Add(new SqlParameter("@Image", element.Image));
            _command.Parameters.Add(new SqlParameter("@Video", element.Video));
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            // Fermeture de la connection
            _connection.Close();

            return nbLignes == 0;
        }
    }
}