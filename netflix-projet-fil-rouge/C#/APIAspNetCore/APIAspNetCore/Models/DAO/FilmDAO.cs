using APIAspNetCore.Models.Classes;
using APINetflix.Models.Connection;
using Microsoft.Data.SqlClient;

namespace APIAspNetCore.Models.DAO
{
    public class FilmDAO : BaseDAO<Films>
    {
        public override int Create(Films element)
        {
            // Rédaction de la requête
            _request = "INSERT INTO FILMS(TITRE, GENRE, NBEPISODES, DATESORTIE, SYNOPSIS, RECOMMANDATION, ACTEUR_NOM, REALISATEUR_NOM, IMAGE, VIDEO) OUTPUT INSERTED.ID VALUES (@Titre, @Genre, @NbEpisodes, @DateSortie, @Synopsis, @Recommandation,@Acteur_Nom, @Realisateur_Nom, @Image, @Video)";
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
            element.IdFilm = (int)_command.ExecuteScalar();
            // Libération de l'obget command
            _command.Dispose();
            // Fermeture de la connection
            _connection.Close();
            return element.IdFilm;
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
