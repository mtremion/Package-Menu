using UnityEngine;

/// <summary>
/// Abstract class for structure a language.
/// </summary>
public abstract class Language
{
    #region SerializeField
    [Header("Canvas Manager")]
    [Tooltip("Canvas manager.")]
    [SerializeField] LanguageCanvasManager canvasManager = new LanguageCanvasManager();
    [Header("Canvas Sign In")]
    [Tooltip("Canvas sign in.")]
    [SerializeField] LanguageCanvasSignIn canvasSignIn = new LanguageCanvasSignIn();
    [Header("Canvas Sign On")]
    [Tooltip("Canvas sign on.")]
    [SerializeField] LanguageCanvasSignOn canvasSignOn = new LanguageCanvasSignOn();
    [Header("Canvas Forgot Password")]
    [Tooltip("Canvas forgot password.")]
    [SerializeField] LanguageCanvasForgotPassword canvasForgotPassword = new LanguageCanvasForgotPassword();
    [Header("Message")]
    [Tooltip("Message.")]
    [SerializeField] LanguageMessage message = new LanguageMessage();
    #endregion

    #region Getters & Setters
    public LanguageCanvasManager m_canvasManager { get { return canvasManager; } }
    public LanguageCanvasSignIn m_canvasSignIn { get { return canvasSignIn; } }
    public LanguageCanvasSignOn m_canvasSignOn { get { return canvasSignOn; } }
    public LanguageCanvasForgotPassword m_canvasForgotPassword { get { return canvasForgotPassword; } }
    public LanguageMessage m_message { get { return message; } }
    #endregion

    #region Main Methods
    public void ChangeLanguage()
    {
        canvasManager.ChangeLanguage();
        canvasSignIn.ChangeLanguage();
        canvasSignOn.ChangeLanguage();
        canvasForgotPassword.ChangeLanguage();
    }
    #endregion
}
