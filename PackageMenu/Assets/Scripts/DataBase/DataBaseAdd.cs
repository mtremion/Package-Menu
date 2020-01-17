using System;
using UnityEngine;
using MySql.Data.MySqlClient;

/// <summary>
/// This class contains function(s) to add data(s) in base.
/// </summary>
public class DataBaseAdd : MonoBehaviour
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
    public void AddImgProfile(string pseudo, string str)
    { 
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT imgPlayerImage FROM playerimage WHERE idPlayer = (SELECT idPlayer from player WHERE pseudoPlayer = '" + pseudo + "')";
        _cmdSql = new MySqlCommand(_cmd, _con);

        try
        {
            Debug.Log("JE SELECT");
            _dataReader = _cmdSql.ExecuteReader();

            if(_dataReader.Read())
            {
                _dataReader.Close();
                _cmd = "UPDATE playerimage SET imgPlayerImage = '" + str + "' WHERE idPlayer = (SELECT idPlayer from player WHERE pseudoPlayer = '" + pseudo + "')";
                _cmdSql = new MySqlCommand(_cmd, _con);

                try
                {
                    _dataReader = _cmdSql.ExecuteReader();
                    _dataReader.Close();
                    _dbManager.m_dbGet.GetProfileImage(pseudo);
                }
                catch (Exception e)
                {
                    Debug.Log(e.ToString());
                }
            }
            else
            {
                _dataReader.Close();
                _cmd = "INSERT INTO playerimage(idPlayer, imgPlayerImage) VALUES ( (SELECT idPlayer from player WHERE pseudoPlayer = '" + pseudo + "' ), '"  + str + "' ) ";
                _cmdSql = new MySqlCommand(_cmd, _con);

                try
                {
                    Debug.Log("J'INSERT");
                    _dataReader = _cmdSql.ExecuteReader();
                    _dataReader.Close();
                    _dbManager.m_dbGet.GetProfileImage(pseudo);
                }
                catch (Exception e)
                {
                    Debug.Log(e.ToString());
                }
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        _dataReader.Close();
    }
    #endregion
}
