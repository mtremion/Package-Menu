using System;
using UnityEngine;

/// <summary>
/// This class contains data(s) for the lead the language of Message from Launcher to the player.
/// </summary>
[Serializable]
public class LanguageMessage
{
    #region SerializeField
    [Header("Message.")]
    [Tooltip("Message : \"\". Should be empty.")]
    [SerializeField] protected string baseMessage = "";
    [Tooltip("Message : Can't be empty.")]
    [SerializeField] protected string cantBeEmpty = "";
    [Tooltip("Message : Need at least X characters")]
    [SerializeField] protected string needAtLeast = "";
    [Tooltip("Message : Need max X characters")]
    [SerializeField] protected string needMax = "";
    [Tooltip("Message : characters")]
    [SerializeField] protected string characters = "";
    [Tooltip("Message : This pseudo is already use.")]
    [SerializeField] protected string pseudoAlreadyUse = "";
    [Tooltip("Message : This email is already use.")]
    [SerializeField] protected string emailAlreadyUse = "";
    [Tooltip("Message : Invalid email.")]
    [SerializeField] protected string invalidEmail = "";
    [Tooltip("Message : The pseudo or the password is incorrect.")]
    [SerializeField] protected string incorrectPseudoOrPassword = "";
    [Tooltip("Message : This email does not exist.")]
    [SerializeField] protected string emailDoesNotExist = "";
    [Tooltip("Message : Wrong code.")]
    [SerializeField] protected string wrongCode = "";
    [Tooltip("Message : Confirm Password is different that New password.")]
    [SerializeField] protected string confirmPasswordDifferent = "";
    [Tooltip("Message : The New password is the same than the Old password.")]
    [SerializeField] protected string newPasswordSameThanOld = "";
    [Tooltip("Message Email Object : You forget your password ? .")]
    [SerializeField] protected string emailCodeVerificationObjectPasswordForgot = "";
    [Tooltip("Message Email Body : Your code is : .")]
    [TextArea]
    [SerializeField] protected string emailCodeVerificationBodyPasswordForgot = "";
    [Tooltip("Message : This Pseudo is Free.")]
    [SerializeField] protected string pseudoIsFree = "";
    #endregion

    #region Getters & Setters
    public string m_baseMessage { get { return baseMessage; } }
    public string m_cantBeEmpty { get { return cantBeEmpty; } }
    public string m_needAtLeast{ get { return needAtLeast; } }
    public string m_needMax { get { return needMax; } }
    public string m_characters { get { return characters; } }
    public string m_pseudoAlreadyUse { get { return pseudoAlreadyUse; } }
    public string m_emailAlreadyUse { get { return emailAlreadyUse; } }
    public string m_invalidEmail { get { return invalidEmail; } }
    public string m_incorrectPseudoOrPassword { get { return incorrectPseudoOrPassword; } }
    public string m_emailDoesNotExist { get { return emailDoesNotExist; } }
    public string m_wrongCode { get { return wrongCode; } }
    public string m_confirmPasswordDifferent { get { return confirmPasswordDifferent; } }
    public string m_newPasswordSameThanOld { get { return newPasswordSameThanOld; } }
    public string m_emailCodeVerificationObjectPasswordForgot { get { return emailCodeVerificationObjectPasswordForgot; } }
    public string m_emailCodeVerificationBodyPasswordForgot { get { return emailCodeVerificationBodyPasswordForgot; } }
    public string m_pseudoIsFree { get { return pseudoIsFree; } }
    #endregion
}
