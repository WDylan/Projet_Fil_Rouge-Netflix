using Microsoft.Data.SqlClient;

namespace API_Netflix_ASPNetCore.Models.Classes
{
    public class Utilisateurs
    {
        private int idUtilisateur;
        private string nom;
        private string prenom;
        private string email;
        private string motdepasse;
        private string statut;
        private string _request;
        private SqlCommand _command;
        private SqlConnection _connection;
        private SqlDataReader _reader;
        private static List<Utilisateurs> utilisateur;

        public int IdUtilisateur { get => idUtilisateur; set => idUtilisateur = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Motdepasse { get => motdepasse; set => motdepasse = value; }
        public string Statut { get => statut; set => statut = value; }
        public string Request { get => _request; set => _request = value; }
        public static List<Utilisateurs> Utilisateur { get => utilisateur; set => utilisateur = value; }


        public (bool, Utilisateurs) Get(int id)
        {
            Utilisateurs utilisateur = null;
            bool found = false;
            _connection = Connection.New;
            _request = "SELECT uti.nom, uti.prenom, uti.email, uti.motdepasse, uti.statut" +
                "FROM UTILISATEURS AS uti";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("@IdUtilisateur", id));
            _connection.Open();
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                utilisateur = new Utilisateurs()
                {
                    IdUtilisateur = _reader.GetInt32(0),
                    Nom = _reader.GetString(1),
                    Prenom = _reader.GetString(2),
                    Email = _reader.GetString(3),
                    Motdepasse = _reader.GetString(4),
                    Statut = _reader.GetString(5),
                };
                found = true;
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return (found, utilisateur);
        }


        public static List<Utilisateurs> GetAll()
        {
            List<Utilisateurs> utilisateurs = new List<Utilisateurs>();
            SqlConnection connection = Connection.New;
            string request = "SELECT uti.nom, uti.prenom, uti.email, uti.motdepasse, uti.statut" +
                "FROM UTILISATEURS AS uti";

            SqlCommand command = new SqlCommand(request, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Films f = new Films()
                {
                    IdFilm = reader.GetInt32(0),
                    Titre = reader.GetString(1),
                    Genre = reader.GetString(2),
                    Duree = reader.GetInt32(3),
                    DateSortie = reader.GetDateTime(4),
                    Synopsis = reader.GetString(5),
                    Recommandation = reader.GetInt32(6),
                    Acteur_Nom = reader.GetString(7),
                    Realisateur_Nom = reader.GetString(8),
                    Image = reader.GetString(9),
                    Video = reader.GetString(10)
                };
                films.Add(f);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return films;
        }











    }
}
