using System;
using UnityEngine;
using MySql.Data.MySqlClient;

/// <summary>
/// This class contains function(s) to register in the database.
/// </summary>
public class DataBaseRegister : MonoBehaviour
{
    #region Private Members
    DataBaseManager _dbManager = null;
    MySqlConnection _con = null;
    MySqlCommand _cmdSql = null;
    MySqlDataReader _dataReader = null;
    string _cmd = "";
    #endregion

    #region System
    private void Awake()
    {
        _dbManager = GetComponent<DataBaseManager>();
    }
    #endregion

    #region Main Method
    /// <summary>
    /// Function use to change a password in the base.
    /// </summary>
    /// <param name="pseudo">Pseudo of the new player.</param>
    /// <param name="password">Password of the new player.</param>
    /// <param name="lastName">Last name of the new player.</param>
    /// <param name="firstName">First name of the new player.</param>
    /// <param name="email">Email of the new player.</param>
    public void Register(string pseudo, string password, string lastName, string firstName, string email)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "INSERT INTO player (pseudoPlayer, passwordPlayer, emailPlayer, firstNamePlayer, lastNamePlayer) VALUES('" + pseudo + "','" + _dbManager.m_dbCryptage.Md5Sum(password)
            + "','" + lastName + "','" + firstName + "','" + email.ToLower() + "');";

        _cmdSql = new MySqlCommand(_cmd, _con);

        try
        {
            _dataReader = _cmdSql.ExecuteReader();
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        _dataReader.Close();
    }
    #endregion
}
