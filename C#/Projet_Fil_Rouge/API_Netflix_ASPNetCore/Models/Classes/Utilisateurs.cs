using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.Mime.MediaTypeNames;

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
        public static List<Utilisateurs> Utilisateur { get => utilisateur; set => utilisateur = value; }

        public Utilisateurs()
        {

        }

        public Utilisateurs(int iDUtilisateur, string nom, string prenom, string email, string motdepasse, string statut)
        {
            IdUtilisateur = iDUtilisateur;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Motdepasse = motdepasse;
            Statut = statut;
        }

        public static Utilisateurs Get(int id)
        {
            Utilisateurs utilisateur = null;
            SqlConnection _connection = Connection.New;

            string _request = "SELECT * FROM UTILISATEURS WHERE idutilisateur =@IdUtilisateur";

            SqlCommand _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@IdUtilisateur", id));

            _connection.Open();

            SqlDataReader _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                utilisateur = new Utilisateurs()
                {
                    IdUtilisateur = _reader.GetInt32(0),
                    Nom = _reader.GetString(1),
                    Prenom = _reader.GetString(2),
                    Email = _reader.GetString(3),
                    Motdepasse = _reader.GetString(4),
                    Statut = _reader.GetString(5)
                };
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return utilisateur;
        }

        public static List<Utilisateurs> GetAll()
        {
            List<Utilisateurs> utilisateurs = new List<Utilisateurs>();
            SqlConnection connection = Connection.New;
            string request = "SELECT * FROM UTILISATEURS"; ;

            SqlCommand command = new SqlCommand(request, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Utilisateurs utilisateur = new Utilisateurs()
                {
                    IdUtilisateur = reader.GetInt32(0),
                    Nom = reader.GetString(1),
                    Prenom = reader.GetString(2),
                    Email = reader.GetString(3),
                    Motdepasse = reader.GetString(4),
                    Statut = reader.GetString(5)
                };
                utilisateurs.Add(utilisateur);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return utilisateurs;
        }

        public static List<Utilisateurs> Find(Func<Utilisateurs, bool> criterie)
        {
            List<Utilisateurs> utilisateurs = new List<Utilisateurs>();
            GetAll().ForEach(f =>
            {
                if (criterie(f))
                {
                    utilisateurs.Add(f);
                }
            });
            return utilisateurs;
        }

        public static List<Utilisateurs> SearchUtilisateur(string search)
        {
            return Find(f => f.Nom.Contains(search) || f.Prenom.Contains(search) || f.Email.Contains(search) || f.Statut.Contains(search));
        }

        public int Add()
        {
            // Création d'une instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "INSERT INTO UTILISATEURS (nom, prenom, email, motdepasse, statut)" +
                "OUTPUT INSERTED.IDUTILISATEUR VALUES (@Nom, @Prenom, @Email, @Motdepasse, @Statut)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Nom", Nom));
            _command.Parameters.Add(new SqlParameter("@Prenom", Prenom));
            _command.Parameters.Add(new SqlParameter("@Email", Email));
            _command.Parameters.Add(new SqlParameter("@MotDePasse", Motdepasse));
            _command.Parameters.Add(new SqlParameter("@Statut", Statut));

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
            _request = "UPDATE UTILISATEURS SET nom=@Nom, prenom=@Prenom, email=@Email, motdepasse=@Motdepasse, statut=@Statut WHERE idutilisateur = @IdUtilisateur";
            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@IdUtilisateur", IdUtilisateur));
            _command.Parameters.Add(new SqlParameter("@Nom", Nom));
            _command.Parameters.Add(new SqlParameter("@Prenom", Prenom));
            _command.Parameters.Add(new SqlParameter("@Email", Email));
            _command.Parameters.Add(new SqlParameter("@MotDePasse", Motdepasse));
            _command.Parameters.Add(new SqlParameter("@Statut", Statut));
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
            _request = "DELETE UTILISATEURS WHERE idutilisateur=@IdUtilisateur";
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la command
            _command.Parameters.Add(new SqlParameter("@IdUtilisateur", IdUtilisateur));

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
            return $"\nL'utilisateur n° {idUtilisateur} :" +
                $"\t\t Etat civil : {Prenom} {Nom}\n" +
                $"\t\t Email : {Email}\n" +
                $"\t\t Statut : {Statut}\n";
        }
    }
}

