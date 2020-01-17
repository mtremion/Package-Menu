using System;
using UnityEngine;
using MySql.Data.MySqlClient;

/// <summary>
/// This class contains function(s) to connect to the database.
/// </summary>
public class DataBaseConnection : MonoBehaviour
{
    #region SerializeField Members
    [Header("Database connection")]
    [Tooltip("The host of the database.")]
    [SerializeField] string dbHost = "";
    [Tooltip("The name of the database.")]
    [SerializeField] string dbName = "";
    [Tooltip("The username to access the database.")]
    [SerializeField] string dbUserName = "";
    [Tooltip("The password to access the database.")]
    [SerializeField] string dbPassword = "";
    #endregion

    #region Private Members
    MySqlConnection _con = null;
    string _cmd = "";
    #endregion

    #region Getters & Setters
    public MySqlConnection m_con { get { return _con; } }
    #endregion

    #region System
    void Start()
    {
        Connexion_BDD();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// Function use to connect to the database.
    /// </summary>
    public void Connexion_BDD()
    {
        _cmd = "Server=" + dbHost + ";Database=" + dbName + ";User ID=" + dbUserName + ";Password=" + dbPassword + ";Pooling=true;Charset=utf8mb4";

        try
        {
            _con = new MySqlConnection(_cmd);
            _con.Open();
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }
    }
    #endregion
}

