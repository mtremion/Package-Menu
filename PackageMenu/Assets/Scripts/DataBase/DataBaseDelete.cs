using System;
using UnityEngine;
using MySql.Data.MySqlClient;

/// <summary>
/// This class contains function(s) to delete data(s) in base.
/// </summary>
public class DataBaseDelete : MonoBehaviour
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

    #region Main Methods
    /// <summary>
    /// Function use to delete a user account.
    /// </summary>
    /// <param name="pseudo">Pseudo of the player that we want to delete.</param>
    public void DeleteUser(string pseudo)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "DELETE FROM player WHERE pseudoPlayer = '" + pseudo + "'";
        _cmdSql = new MySqlCommand(_cmd, _con);

        try
        {
            _dataReader = _cmdSql.ExecuteReader();
            _dataReader.Close();
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        _dataReader.Close();
    }
    #endregion
}
