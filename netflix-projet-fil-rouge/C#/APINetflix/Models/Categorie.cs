using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;
using System;

namespace APINetflix.Models
{
    public class Categorie
    {
        private int idCat;
        private string categ;
        string _request;
        SqlCommand _command;
        SqlConnection _connection;
        SqlDataReader _reader;

        public Categorie()
        {

        }
        public Categorie(string categ)
        {
            Categ = categ;
        }

        public int IdCat { get => idCat; set => idCat = value; }
        public string Categ { get => categ; set => categ = value; }

        public virtual Categorie Get(int id)
        {
            Categorie categorie = null;

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "SELECT (Categ) FROM CATEGORIE WHERE id=@IdCat";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@IdCat", id));


            // Ouverture de la connexion
            _connection.Open();

            // Execution de la commande
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                categorie = new Categorie() { IdCat = _reader.GetInt32(0), Categ = _reader.GetString(2) };
            }
            _reader.Close();

            // Libération de l'objet command
            _command.Dispose();
            // Fzermeture de la connection à la BDD
            _connection.Close();
            return categorie;
        }

        public virtual int Add()
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "INSERT INTO Categorie (categ) OUTPUT INSERTED.ID VALUES (@Categ)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Categ", Categ));

            // Execution de la commande
            _connection.Open();
            int Id = (int)_command.ExecuteScalar();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return Id;
        }

        public virtual bool Update()
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "UPDATE CATEGORIE SET categ = @Categ WHERE id=@IdCat";


            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Categ", Categ));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }

        public virtual bool Delete()
        {

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "DELETE CATEGORIE WHERE id=@IdCat";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@IdCat", IdCat));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }


        public override string ToString()
        {
            return $"Catégorie n°{idCat} : {Categ}";
        }
    }

}
