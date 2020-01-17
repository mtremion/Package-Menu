using System;
using UnityEngine;
using MySql.Data.MySqlClient;
using UnityEngine.UI;

/// <summary>
/// This class contains function(s) to get data(s) in base.
/// </summary>
public class DataBaseGet : MonoBehaviour
{
    #region Private Members
    DataBaseManager _dbManager = null;
    MySqlConnection _con = null;
    MySqlCommand _cmdSql = null;
    MySqlDataReader _dataReader = null;
    string _cmd = "";
    GameObjectMenuManager _goMenuManager = null;
    #endregion

    #region System
    private void Awake()
    {
        _dbManager = GetComponent<DataBaseManager>();
        _goMenuManager = GameObject.Find("GameObjectMenuManager").GetComponent<GameObjectMenuManager>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// Function use to get the email of a given pseudo.
    /// </summary>
    /// <param name="pseudo">Pseudo of the player that we want to get the password.</param>
    public string GetEmail(string pseudo)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT emailPlayer FROM player WHERE pseudoPlayer = '" + pseudo +  "'";
        _cmdSql = new MySqlCommand(_cmd, _con);

        string email;

        try
        {
            _dataReader = _cmdSql.ExecuteReader();

            if (_dataReader.Read())
            {
                email = _dataReader.GetString(0);
                _dataReader.Close();
                return email;
            }
            else
            {
                Debug.Log("Je lis rien");
                _dataReader.Close();
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        return null;
    }
    /// <summary>
    /// Function use to get the first name of a given pseudo.
    /// </summary>
    /// <param name="pseudo">Pseudo of the player that we want to get the password.</param>
    public string GetFirstName(string pseudo)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT FirstNamePlayer FROM player WHERE pseudoPlayer = '" + pseudo + "'";
        _cmdSql = new MySqlCommand(_cmd, _con);

        string firstName;

        try
        {
            _dataReader = _cmdSql.ExecuteReader();

            if (_dataReader.Read())
            {
                firstName = _dataReader.GetString(0);
                _dataReader.Close();
                return firstName;
            }
            else
            {
                _dataReader.Close();
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        return null;
    }
    /// <summary>
    /// Function use to get the last name of a given pseudo.
    /// </summary>
    /// <param name="pseudo">Pseudo of the player that we want to get the password.</param>
    public string GetLastName(string pseudo)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT lastNamePlayer FROM  player WHERE pseudoPlayer = '" + pseudo + "'";
        _cmdSql = new MySqlCommand(_cmd, _con);

        string lastName;

        try
        {
            _dataReader = _cmdSql.ExecuteReader();

            if (_dataReader.Read())
            {
                lastName = _dataReader.GetString(0);
                _dataReader.Close();
                return lastName;
            }
            else
            {
                _dataReader.Close();
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        return null;
    }
    /// <summary>
    /// Function use to get the last name of a given pseudo.
    /// </summary>
    /// <param name="pseudo">Pseudo of the player that we want to get the password.</param>
    public void GetProfileImage(string pseudo)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT imgPlayerImage FROM playerImage WHERE idPlayer = (SELECT idPlayer from player WHERE pseudoPlayer = '" + pseudo + "')";
        _cmdSql = new MySqlCommand(_cmd, _con);

        string image;

        try
        {
            _dataReader = _cmdSql.ExecuteReader();

            if (_dataReader.Read())
            {
                 image = _dataReader.GetString(0);          
                 byte[] bytes = Convert.FromBase64String(image);

                 Texture2D sampleTexture = new Texture2D(2, 2);
                 bool isLoaded = sampleTexture.LoadImage(bytes);
                 if(isLoaded)
                 {
                   //  _goMenuManager.m_goCanvasProfile.m_imgImgProfileCanvasProfile.sprite = Sprite.Create(sampleTexture, new Rect(0.0f, 0.0f, sampleTexture.width, sampleTexture.height), new Vector2(0.5f, 0.5f), 100.0f);
                 }

                _dataReader.Close();
            }
            else
            {
                _dataReader.Close();
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }
    }
    #endregion
}
