using UnityEngine;

/// <summary>
/// This classe contains data(s) to lead the database.
/// </summary>
[RequireComponent(typeof(DataBaseConnection))]
[RequireComponent(typeof(DataBaseVerification))]
[RequireComponent(typeof(DataBaseCryptage))]
[RequireComponent(typeof(DataBaseRegister))]
[RequireComponent(typeof(DataBaseChangePassword))]
[RequireComponent(typeof(DataBaseURL))]
[RequireComponent(typeof(DataBaseAdd))]
[RequireComponent(typeof(DataBaseGet))]
[RequireComponent(typeof(DataBaseDelete))]
[RequireComponent(typeof(SendEmail))]
[RequireComponent(typeof(Message))]
public class DataBaseManager : MonoBehaviour
{
    #region Static Members
    public static DataBaseManager INSTANCE = null;
    #endregion

    #region Private Members
    DataBaseConnection _dbConnection = null;
    DataBaseVerification _dbVerification = null;
    DataBaseCryptage _dbCryptage = null;
    DataBaseRegister _dbRegister = null;
    DataBaseChangePassword _dbChangePassword = null;
    DataBaseURL _dbUrl = null;
    DataBaseAdd _dbAdd = null;
    DataBaseGet _dbGet = null;
    DataBaseDelete _dbDelete = null;
    SendEmail _sendEmail = null;
    Message _message = null;
    string _actualPseudo = "", _actualEmail = "", _actualLastName = "", _actualFirstName = "";
    #endregion

    #region Getters && Setters
    public DataBaseConnection m_dbConnection { get { return _dbConnection; } }
    public DataBaseVerification m_dbVerification { get { return _dbVerification; } }
    public DataBaseCryptage m_dbCryptage { get { return _dbCryptage; } }
    public DataBaseRegister m_dbRegister { get { return _dbRegister; } }
    public DataBaseChangePassword m_dbChangePassword{ get { return _dbChangePassword; } }
    public DataBaseURL m_dbUrl { get { return _dbUrl; } }
    public DataBaseAdd m_dbAdd { get { return _dbAdd; } }
    public DataBaseGet m_dbGet { get { return _dbGet; } }
    public DataBaseDelete m_dbDelete { get { return _dbDelete; } }
    public SendEmail m_sendEmail { get { return _sendEmail; } }
    public Message m_message { get { return _message; } }
    public string m_actualPseudo { get { return _actualPseudo; } set { _actualPseudo = value; } }
    public string m_actualEmail{ get { return _actualEmail; } set { _actualEmail = value; } }
    public string m_actualLastName { get { return _actualLastName; } set { _actualLastName = value; } }
    public string m_actualFirstName { get { return _actualFirstName; } set { _actualFirstName = value; } }
    #endregion

    #region System
    void Awake()
    {
        if (INSTANCE != null)
        {
            Destroy(gameObject);
        }
        else
        {
            INSTANCE = this;
            DontDestroyOnLoad(gameObject);
        }

        _dbConnection = GetComponent<DataBaseConnection>();
        _dbVerification = GetComponent<DataBaseVerification>();
        _dbCryptage = GetComponent<DataBaseCryptage>();
        _dbRegister = GetComponent<DataBaseRegister>();
        _dbChangePassword = GetComponent<DataBaseChangePassword>();
        _dbUrl = GetComponent<DataBaseURL>();
        _dbAdd = GetComponent<DataBaseAdd>();
        _dbGet = GetComponent<DataBaseGet>();
        _dbDelete= GetComponent<DataBaseDelete>();
        _sendEmail = GetComponent<SendEmail>();
        _message = GetComponent<Message>();
    }
    #endregion
}
