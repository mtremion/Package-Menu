using System;
using System.Text.RegularExpressions;
using UnityEngine;
using MySql.Data.MySqlClient;
using TMPro;
using UnityEngine.UI;

/// <summary>
/// This class contains function(s) to verify informations.
/// </summary>
public class DataBaseVerification : MonoBehaviour
{
    #region SerializeField Members
    [Header("Database Restriction")]
    [Tooltip("Size min for Pseudo.")]
    [Range(1,10)]
    [SerializeField] int minPseudoSize = 3;
    [Tooltip("Size max for Pseudo.")]
    [Range(1, 20)]
    [SerializeField] int maxPseudoSize = 10;
    [Tooltip("Size min for Password.")]
    [Range(1, 10)]
    [SerializeField] int minPasswordSize = 6;
    [Tooltip("Size max for Password.")]
    [Range(1, 20)]
    [SerializeField] int maxPasswordSize = 14;
    #endregion

    #region Private Members
    bool _isValidRegister = false, _isValidPseudo = false, _isValidPassword = false, _isValidEmail = false, _isValidFirstName = false,
        _isValidLastName = false, _isPseudoExist = false, _isEmailExist = false, _isSamePassword = false, _isGoodPassword = false, _isFreePseudo = false;
    DataBaseManager _dbManager = null;
    MySqlConnection _con = null;
    MySqlCommand _cmdSql = null;
    MySqlDataReader _dataReader = null;
    DesignMenuManager _designMenuManager = null;
    string _cmd = "";
    #endregion

    #region System
    private void Awake()
    {
        _dbManager = GetComponent<DataBaseManager>();
        _designMenuManager = GameObject.Find("DesignMenuManager").GetComponent<DesignMenuManager>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// Search in database if the pseudo is exist.
    /// </summary>
    /// <param name="pseudo">Pseudo we want to search.</param>
    /// <returns>Return TRUE if the pseudo exist in the database, FALSE if it dosen't.<returns>
    public bool IsPseudoExist(string pseudo)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT pseudoPlayer FROM player where pseudoPlayer = '" + pseudo.ToLower() + "';";
        _cmdSql = new MySqlCommand(_cmd, _con);

        try
        {
            _dataReader = _cmdSql.ExecuteReader();

            if (_dataReader.Read())
            {
                _isPseudoExist = true;
            }
            else
            {
                _isPseudoExist = false;
            }

            _dataReader.Close();
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        return _isPseudoExist;
    }
    /// <summary>
    /// Search in database if the pseudo is exist.
    /// </summary>
    /// <param name="input">The input where is stock the pseudo that we want to check.</param>
    /// <returns>Return TRUE if the pseudo exist in the database, FALSE if it dosen't.<returns>
    public bool IsPseudoExist(TMP_InputField input)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT pseudoPlayer FROM player where pseudoPlayer = '" + input.text.ToLower() + "';";
        _cmdSql = new MySqlCommand(_cmd, _con);

        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        try
        {
            _dataReader = _cmdSql.ExecuteReader();

            if (_dataReader.Read())
            {
                ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
                _isPseudoExist = true;
            }
            else
            {
                ChangeInputFieldColor(input, _designMenuManager.m_colorInputValid);
                _isPseudoExist = false;
            }

            _dataReader.Close();
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        return _isPseudoExist;
    }
    /// <summary>
    /// Search in database if the pseudo is exist.
    /// </summary>
    /// <param name="input">The input where is stock the pseudo that we want to check.</param
    /// <param name="info">Allow to put a message in a "Info text".</param>
    /// <returns>Return TRUE if the pseudo exist in the database, FALSE if it dosen't.<returns>
    public bool IsPseudoExist(TMP_InputField input, TextMeshProUGUI info)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT pseudoPlayer FROM player where pseudoPlayer = '" + input.text + "';";
        _cmdSql = new MySqlCommand(_cmd, _con);

        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        try
        {
            _dataReader = _cmdSql.ExecuteReader();

            if (_dataReader.Read())
            {
                ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
                ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);
                info.text = _dbManager.m_message.PseudoAlreadyUse();
                _isPseudoExist = true;
            }
            else
            {
                ChangeInputFieldColor(input, _designMenuManager.m_colorInputValid);
                info.text = _dbManager.m_message.BaseMessage();
                _isPseudoExist = false;
            }

            _dataReader.Close();
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }
        return _isPseudoExist;
    }
    public bool IsFreePseudo(TMP_InputField input, TextMeshProUGUI info)
    {
        _con = _dbManager.m_dbConnection.m_con;

        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        if (input.text.Length >= minPseudoSize && input.text.Length <= maxPasswordSize)
        {
            _isFreePseudo = !IsPseudoExist(input, info);

            if(_isFreePseudo)
            {
                ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextValidMessage);
                info.text = _dbManager.m_message.PseudoIsFree();
            }
        }
        else
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
            ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);

            if (input.text.Length == 0)
            {
                info.text = _dbManager.m_message.CantBeEmpty();
            }
            else if (input.text.Length < minPseudoSize)
            {
                info.text = _dbManager.m_message.NeedAtLeast() + " " + minPseudoSize + " " + _dbManager.m_message.Characters();
            }
            else if (input.text.Length > maxPseudoSize)
            {
                info.text = _dbManager.m_message.NeedMax() + " " + maxPseudoSize + " " + _dbManager.m_message.Characters();
            }

            _isFreePseudo = false;
        }
        return _isValidPseudo;
    }
    /// <summary>
    /// Check if a pseudo is a valid one.
    /// </summary>
    /// <param name="input">The input where is stock the pseudo that we want to check.</param
    /// <param name="info">Allow to put a message in a "Info text".</param>
    /// <returns>Return TRUE if the pseudo is valid for the database, FALSE if it dosen't.<returns>
    public bool IsValidPseudo(TMP_InputField input, TextMeshProUGUI info)
    {
        _con = _dbManager.m_dbConnection.m_con;

        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        if (input.text.Length >= minPseudoSize && input.text.Length <= maxPasswordSize)
        {
            _isValidPseudo = !IsPseudoExist(input,info);           
        }
        else
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
            ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);

            if (input.text.Length == 0)
            {
                info.text = _dbManager.m_message.CantBeEmpty();
            }
            else if (input.text.Length < minPseudoSize)
            {
                info.text = _dbManager.m_message.NeedAtLeast() + " " + minPseudoSize +" "+ _dbManager.m_message.Characters();
            }
            else if (input.text.Length > maxPseudoSize)
            {
                info.text = _dbManager.m_message.NeedMax() + " " + maxPseudoSize + " " + _dbManager.m_message.Characters();
            }

            _isValidPseudo = false;
        }
        return _isValidPseudo;
    }
    /// <summary>
    /// Check if a password is the same that we have in the database for an pseudo.
    /// </summary>
    /// <param name="pseudo">Pseudo on which we want to check.</param
    /// <param name="password">The password we want to check.</param>
    /// <returns>Return TRUE if the password is the same in the database, FALSE if it dosen't.<returns>
    public bool IsGoodPassword(string pseudo, string password)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT pseudoPlayer from player where pseudoPlayer = '" + pseudo + "' and passwordPlayer = '" + _dbManager.m_dbCryptage.Md5Sum(password) + "'";
        _cmdSql = new MySqlCommand(_cmd, _con);

        try
        {
            _dataReader = _cmdSql.ExecuteReader();

            if (_dataReader.Read())
            {
                _isGoodPassword = true;
            }
            else
            {
                _isGoodPassword = false;
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        _dataReader.Close();

        return _isGoodPassword;
    }
    /// <summary>
    /// Check if a password is the same that we have in the database for an pseudo.
    /// </summary>
    /// <param name="pseudo">Pseudo on which we want to check.</param
    /// <param name="password">The password we want to check.</param>
    /// <param name="infoText">The password we want to check.</param>
    /// <returns>Return TRUE if the password is the same in the database, FALSE if it dosen't.<returns>
    public bool IsGoodPassword(string pseudo, string password, TextMeshProUGUI info, TMP_InputField inputPseudo, TMP_InputField inputPassword)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT pseudoPlayer from player where pseudoPlayer = '" + pseudo + "' and passwordPlayer = '" + _dbManager.m_dbCryptage.Md5Sum(password) + "'";

        _cmdSql = new MySqlCommand(_cmd, _con);

        try
        {
            _dataReader = _cmdSql.ExecuteReader();

            if (_dataReader.Read())
            {
                _isGoodPassword = true;
                _dataReader.Close();
            }
            else
            {
                ChangeInputFieldColor(inputPseudo, _designMenuManager.m_colorInputError);
                ChangeInputFieldColor(inputPassword, _designMenuManager.m_colorInputError);
                ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);
                info.text = _dbManager.m_message.IncorrectPseudoOrPassword();
                _isGoodPassword = false;
                _dataReader.Close();
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        return _isGoodPassword;
    }
    /// <summary>
    /// Check if a password is the same that we have in the database for an email.
    /// </summary>
    /// <param name="email">Email on which we want to check.</param
    /// <param name="password">The password we want to check.</param>
    /// <returns>Return TRUE if the password is the same in the database, FALSE if it dosen't.<returns>
    public bool IsSamePassword(string email, string password)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT emailPlayer from player where emailPlayer = '" + email + "' and passwordPlayer = '" + _dbManager.m_dbCryptage.Md5Sum(password) + "'";
        _cmdSql = new MySqlCommand(_cmd, _con);

        try
        {
            _dataReader = _cmdSql.ExecuteReader();

            if (_dataReader.Read())
            {
                _dataReader.Close();
                _isSamePassword = true;
            }
            else
            {
                _dataReader.Close();
                _isSamePassword = false;
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }
        return _isSamePassword;
    }
    /// <summary>
    /// Check if the password is a valid one.
    /// </summary>
    /// <param name="input">The input where is stock the password that we want to check.</param
    /// <param name="info">Allow to put a message in a "Info text".</param>
    /// <returns>Return TRUE if the pseudo exist in the database, FALSE if it dosen't.<returns>
    public bool IsValidPassword(TMP_InputField input, TextMeshProUGUI info)
    {
        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        if (input.text.Length >= minPasswordSize && input.text.Length <= maxPasswordSize)
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputValid);
            info.text = _dbManager.m_message.BaseMessage();
            _isValidPassword = true;
        }
        else
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
            ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);

            if (input.text.Length == 0)
            {
                info.text = _dbManager.m_message.CantBeEmpty();
            }
            else if (input.text.Length < minPasswordSize)
            {
                info.text = _dbManager.m_message.NeedAtLeast() + " " + minPasswordSize + " " + _dbManager.m_message.Characters();
            }
            else if (input.text.Length > maxPasswordSize)
            {
                info.text = _dbManager.m_message.NeedMax() + " " + maxPasswordSize + " " + _dbManager.m_message.Characters();
            }
            _isValidPassword = false;
        }
        return _isValidPassword;
    }
    /// <summary>
    /// Search in database if the email is exist.
    /// </summary>
    /// <param name="email">Email we want to search.</param>
    /// <returns>Return TRUE if the email exist in the database, FALSE if it dosen't.<returns>
    public bool IsEmailExist(string email)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT emailPlayer FROM player where emailPlayer = '" + email.ToLower() + "';";
        _cmdSql = new MySqlCommand(_cmd, _con);
        _dataReader = _cmdSql.ExecuteReader();

        if (!_dataReader.Read())
        {
            _dataReader.Close();
            _isEmailExist = false;
        }
        else
        {
            _dataReader.Close();
            _isEmailExist = true;
        }

        return _isEmailExist;
    }
    /// <summary>
    /// Search in database if the email is exist.
    /// </summary>
    /// <param name="input">The input where is stock the email that we want to check.</param>
    /// <returns>Return TRUE if the email exist in the database, FALSE if it dosen't.<returns>
    public bool IsEmailExist(TMP_InputField input)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT emailPlayer FROM player where emailPlayer = '" + input.text.ToLower() + "';";
        _cmdSql = new MySqlCommand(_cmd, _con);
        _dataReader = _cmdSql.ExecuteReader();

        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        if (!_dataReader.Read())
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputValid);
            _dataReader.Close();
            _isEmailExist = false;
        }
        else
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
            _dataReader.Close();
            _isEmailExist = true;
        }

        return _isEmailExist;
    }
    /// <summary>
    /// Search in database if the email is exist.
    /// </summary>
    /// <param name="input">The input where is stock the email that we want to check.</param
    /// <param name="info">Allow to put a message in a "Info text".</param>
    /// <returns>Return TRUE if the email exist in the database, FALSE if it dosen't.<returns>
    public bool IsEmailExist(TMP_InputField input, TextMeshProUGUI info)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT emailPlayer FROM player where emailPlayer = '" + input.text.ToLower() + "';";
        _cmdSql = new MySqlCommand(_cmd, _con);
        _dataReader = _cmdSql.ExecuteReader();

        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        if (!_dataReader.Read())
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputValid);
            info.text = _dbManager.m_message.BaseMessage();
            _dataReader.Close();
            _isEmailExist = false;
        }
        else
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
            ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);
            info.text = _dbManager.m_message.EmailAlreadyUse();
            _dataReader.Close();
            _isEmailExist = true;
        }

        return _isEmailExist;
    }
    /// <summary>
    /// Search in database if the email is exist.
    /// </summary>
    /// <param name="input">The input where is stock the email that we want to check.</param
    /// <param name="info">Allow to put a message in a "Info text".</param>
    /// <returns>Return TRUE if the email exist in the database, FALSE if it dosen't.<returns>
    public bool DoesEmailExist(TMP_InputField input, TextMeshProUGUI info)
    {
        _con = _dbManager.m_dbConnection.m_con;
        _cmd = "SELECT emailPlayer FROM player where emailPlayer = '" + input.text + "';";
        _cmdSql = new MySqlCommand(_cmd, _con);
        _dataReader = _cmdSql.ExecuteReader();

        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        if (!_dataReader.Read())
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
            ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);
            info.text = _dbManager.m_message.EmailDoesNotExist();
            _dataReader.Close();
            return false;
        }
        else
        {
            _dataReader.Close();
            return true;
        }

    }
    /// <summary>
    /// Check if a pseudo is a valid Email.
    /// </summary>
    /// <param name="input">The input where is stock the email that we want to check.</param
    /// <param name="info">Allow to put a message in a "Info text".</param>
    /// <returns>Return TRUE if the email is valid for the database, FALSE if it dosen't.<returns>
    public bool IsValidEmail(TMP_InputField input, TextMeshProUGUI info)
    {
        Regex regex = new Regex(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(input.text);

        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        if (input.text.Length > 0)
        {
            if (match.Success)
            {
                if (IsEmailExist(input, info))
                {
                    _isValidEmail = false;
                }
                else
                {
                    _isValidEmail = true;
                }
            }
            else
            {
                ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
                ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);
                info.text = _dbManager.m_message.InvalidEmail();
                _isValidEmail = false;
            }
        }
        else
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
            ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);
            info.text = _dbManager.m_message.CantBeEmpty();
            _isValidEmail = false;
        }
        return _isValidEmail;
    }
    /// <summary>
    /// Check if a last name is a valid one.
    /// </summary>
    /// <param name="input">The input where is stock the last name that we want to check.</param
    /// <param name="info">Allow to put a message in a "Info text".</param>
    /// <returns>Return TRUE if the last name is valid for the database, FALSE if it dosen't.<returns>
    public bool IsValidLastName(TMP_InputField input, TextMeshProUGUI info)
    {
        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        if (input.text.Length > 0)
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputValid);
            info.text = _dbManager.m_message.BaseMessage();
            _isValidLastName = true;
        }
        else
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
            ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);
            info.text = _dbManager.m_message.CantBeEmpty();
            _isValidLastName = false;
        }

        return _isValidLastName;
    }
    /// <summary>
    /// Check if a first name is a valid one.
    /// </summary>
    /// <param name="input">The input where is stock the first name that we want to check.</param
    /// <param name="info">Allow to put a message in a "Info text".</param>
    /// <returns>Return TRUE if the first name is valid for the database, FALSE if it dosen't.<returns>
    public bool IsValidFirstName(TMP_InputField input, TextMeshProUGUI info)
    {
        ChangeInputFieldColor(input, _designMenuManager.m_colorInputBase);

        if (input.text.Length > 0)
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputValid);
            info.text = _dbManager.m_message.BaseMessage();
            _isValidFirstName =  true;
        }
        else
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
            ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);
            info.text = _dbManager.m_message.CantBeEmpty();
            _isValidFirstName = false;
        }

        return _isValidFirstName;
    }
    /// <summary>
    /// Check if we can register the player in the database.
    /// </summary>
    /// <returns>Return TRUE if we can, FALSE if we can't.<returns>
    public bool IsValidRegister()
    {
        _isValidRegister = _isValidPseudo && _isValidPassword && _isValidEmail && _isValidFirstName && _isValidLastName;
        return _isValidRegister;
    }
    /// <summary>
    /// Change Color of a TMP_InputField.
    /// <param name="input">The TMP_InputField that we want to change color.</param
    /// <param name="color">The color which will be apply.</param>
    /// </summary>
    public void ChangeInputFieldColor(TMP_InputField input, Color color)
    {
        ColorBlock cbInput = input.colors;

        cbInput.normalColor = color;
        input.colors = cbInput;
    }
    /// <summary>
    /// Change Color of a TextMeshProUGUI.
    /// <param name="tmp">The TextMeshProUGUI that we want to change color.</param
    /// <param name="color">The color which will be apply.</param>
    /// </summary>
    public void ChangeTextMeshProUGUIColor(TextMeshProUGUI tmp, Color color)
    {
        tmp.color = color;
    }
    /// <summary>
    /// Verify if the enter code is the same which been send by email.
    /// <param name="input">The TMP_InputField where the user enter the code.</param
    /// <param name="info">The TextMeshProUGUI info for the input.</param>
    /// <param name="actualCode">The actual code send.</param
    /// <param name="enterCode">The code enter.</param>
    /// <return>True if it is, false in other case.</return>
    /// </summary>
    public bool VerifyCode(TMP_InputField input, TextMeshProUGUI info, string actualCode, string enterCode)
    {
        if(enterCode.Length <= 0)
        {
            ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
            ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);
            info.text = _dbManager.m_message.CantBeEmpty();
            return false;
        }
        else
        {
            if (actualCode.Equals(enterCode))
            {
                return true;
            }
            else
            {
                ChangeInputFieldColor(input, _designMenuManager.m_colorInputError);
                ChangeTextMeshProUGUIColor(info, _designMenuManager.m_colorTextErrorMessage);
                info.text = _dbManager.m_message.WrongVerifyCode();
                return false;
            }
        }
        
    }
    /// <summary>
    /// Change Color of a TextMeshProUGUI.
    /// <param name="tmp">The TextMeshProUGUI that we want to change color.</param
    /// <param name="color">The color which will be apply.</param>
    /// </summary>
    public bool VerifyNewPasswordAndConfirmPassword(TMP_InputField inputNewPassword, TMP_InputField inputConfirmPassword, TextMeshProUGUI infoPasswords, string email)
    {
        if(IsValidPassword(inputNewPassword, infoPasswords))
        {
            if(inputNewPassword.text.Equals(inputConfirmPassword.text))
            {
                if (IsSamePassword(email, inputConfirmPassword.text))
                {
                    ChangeInputFieldColor(inputNewPassword, _designMenuManager.m_colorInputError);
                    ChangeTextMeshProUGUIColor(infoPasswords, _designMenuManager.m_colorTextErrorMessage);
                    infoPasswords.text = _dbManager.m_message.NewPasswordSameThanOldPassword();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                ChangeInputFieldColor(inputConfirmPassword, _designMenuManager.m_colorInputError);
                ChangeTextMeshProUGUIColor(infoPasswords, _designMenuManager.m_colorTextErrorMessage);
                infoPasswords.text = _dbManager.m_message.ConfirmPasswordDifferent();
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    #endregion
}
