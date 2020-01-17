using UnityEngine;

/// <summary>
/// This class contains functions to write a message depend on the actual language.
/// </summary>
public class Message : MonoBehaviour
{
    #region Private
    LanguageMenuManager _languageManager = null;
    GameObjectMenuManager _goManager = null;
    #endregion

    #region System
    private void Awake()
    {
        _languageManager = GameObject.Find("LanguageMenuManager").GetComponent<LanguageMenuManager>();
        _goManager = GameObject.Find("GameObjectMenuManager").GetComponent<GameObjectMenuManager>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The base message (Should be "") depend on the actual language.</return>
    /// </summary>
    public string BaseMessage()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_baseMessage;
            case 1:
                return _languageManager.m_french.m_message.m_baseMessage;
            case 2:
                return _languageManager.m_spanish.m_message.m_baseMessage;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message Can't be Empty depend on the actual language.</return>
    /// </summary>
    public string CantBeEmpty()
    {
        switch(_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_cantBeEmpty;
            case 1:
                return _languageManager.m_french.m_message.m_cantBeEmpty;
            case 2:
                return _languageManager.m_spanish.m_message.m_cantBeEmpty;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message Need at least depend on the actual language.</return>
    /// </summary>
    public string NeedAtLeast()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_needAtLeast;
            case 1:
                return _languageManager.m_french.m_message.m_needAtLeast;
            case 2:
                return _languageManager.m_spanish.m_message.m_needAtLeast;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message Need max depend on the actual language.</return>
    /// </summary>
    public string NeedMax()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_needMax;
            case 1:
                return _languageManager.m_french.m_message.m_needMax;
            case 2:
                return _languageManager.m_spanish.m_message.m_needMax;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message characters depend on the actual language.</return>
    /// </summary>
    public string Characters()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_characters;
            case 1:
                return _languageManager.m_french.m_message.m_characters;
            case 2:
                return _languageManager.m_spanish.m_message.m_characters;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message Pseudo is already use depend on the actual language.</return>
    /// </summary>
    public string PseudoAlreadyUse()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_pseudoAlreadyUse;
            case 1:
                return _languageManager.m_french.m_message.m_pseudoAlreadyUse;
            case 2:
                return _languageManager.m_spanish.m_message.m_pseudoAlreadyUse;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message Email is already use depend on the actual language.</return>
    /// </summary>
    public string EmailAlreadyUse()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_emailAlreadyUse;
            case 1:
                return _languageManager.m_french.m_message.m_emailAlreadyUse;
            case 2:
                return _languageManager.m_spanish.m_message.m_emailAlreadyUse;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message Invalid email depend on the actual language.</return>
    /// </summary>
    public string InvalidEmail()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_invalidEmail;
            case 1:
                return _languageManager.m_french.m_message.m_invalidEmail;
            case 2:
                return _languageManager.m_spanish.m_message.m_invalidEmail;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message This pseudo or password is incorrect depend on the actual language.</return>
    /// </summary>
    public string IncorrectPseudoOrPassword()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:                
                return _languageManager.m_english.m_message.m_incorrectPseudoOrPassword;
            case 1:
                return _languageManager.m_french.m_message.m_incorrectPseudoOrPassword;
            case 2:
                return _languageManager.m_spanish.m_message.m_incorrectPseudoOrPassword;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message This email does not exist depend on the actual language.</return>
    /// </summary>
    public string EmailDoesNotExist()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_emailDoesNotExist;
            case 1:
                return _languageManager.m_french.m_message.m_emailDoesNotExist;
            case 2:
                return _languageManager.m_spanish.m_message.m_emailDoesNotExist;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message This email does not exist depend on the actual language.</return>
    /// </summary>
    public string WrongVerifyCode()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_wrongCode;
            case 1:
                return _languageManager.m_french.m_message.m_wrongCode;
            case 2:
                return _languageManager.m_spanish.m_message.m_wrongCode;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message Confirm password is different that New password depend on the actual language.</return>
    /// </summary>
    public string ConfirmPasswordDifferent()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_confirmPasswordDifferent;
            case 1:
                return _languageManager.m_french.m_message.m_confirmPasswordDifferent;
            case 2:
                return _languageManager.m_spanish.m_message.m_confirmPasswordDifferent;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message The New password is the same than Old password depend on the actual language.</return>
    /// </summary>
    public string NewPasswordSameThanOldPassword()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_newPasswordSameThanOld;
            case 1:
                return _languageManager.m_french.m_message.m_newPasswordSameThanOld;
            case 2:
                return _languageManager.m_spanish.m_message.m_newPasswordSameThanOld;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message object of mail verification : You forgot your Password ? depend on the actual language.</return>
    /// </summary>
    public string EmailCodeVerificationObjectPasswordForgot()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_emailCodeVerificationObjectPasswordForgot;
            case 1:
                return _languageManager.m_french.m_message.m_emailCodeVerificationObjectPasswordForgot;
            case 2:
                return _languageManager.m_spanish.m_message.m_emailCodeVerificationObjectPasswordForgot;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message body of mail verification : Your code is depend on the actual language.</return>
    /// </summary>
    public string EmailCodeVerificationBodyPasswordForgot()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_emailCodeVerificationBodyPasswordForgot;
            case 1:
                return _languageManager.m_french.m_message.m_emailCodeVerificationBodyPasswordForgot;
            case 2:
                return _languageManager.m_spanish.m_message.m_emailCodeVerificationBodyPasswordForgot;
            default:
                return "";
        }
    }
    /// <summary>
    /// This function will write a string depend on the actual language.
    /// <return>The message Pseudo is Free depend on the actual language.</return>
    /// </summary>
    public string PseudoIsFree()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                return _languageManager.m_english.m_message.m_pseudoIsFree;
            case 1:
                return _languageManager.m_french.m_message.m_pseudoIsFree;
            case 2:
                return _languageManager.m_spanish.m_message.m_pseudoIsFree;
            default:
                return "";
        }
    }
    #endregion
}
