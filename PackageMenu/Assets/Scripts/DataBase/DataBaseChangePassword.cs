using System;
using UnityEngine;
using MySql.Data.MySqlClient;

/// <summary>
/// This class contains function(s) to change password.
/// </summary>
public class DataBaseChangePassword : MonoBehaviour
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
    /// Function use to change a password in the base.
    /// </summary>
    /// <param name="email">Email of the player that we want to change the password.</param>
    /// <param name="newPassword">The new password.</param>
    public void ChangePassword(string email, string newPassword)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "UPDATE player SET passwordPlayer = '" + _dbManager.m_dbCryptage.Md5Sum(newPassword) + "' where emailPlayer = '" + email + "'";
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
