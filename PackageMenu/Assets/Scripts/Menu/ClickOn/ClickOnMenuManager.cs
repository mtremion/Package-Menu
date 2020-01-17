using UnityEngine;
using TMPro;
using System.Collections;

/// <summary>
/// This class contains mains data(s) for click's action(s) on the Menu.
/// </summary>
public class ClickOnMenuManager : MonoBehaviour
{
    #region Private
    DataBaseManager _dbManager = null;
    GameObjectMenuManager _goManager = null;
    LanguageMenuManager _languageManager = null;
    SoundManager _sndManager = null;
    //BrowserFileManager _bfManager = null;
    #endregion

    #region System
    private void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();
        _goManager = GameObject.Find("GameObjectMenuManager").GetComponent<GameObjectMenuManager>();
        _languageManager = GameObject.Find("LanguageMenuManager").GetComponent<LanguageMenuManager>();
        _sndManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        // _bfManager = GameObject.Find("BrowserFileManager").GetComponent<BrowserFileManager>();
    }
    #endregion

    #region Main Methods
    #region Canvas Manager
    /// <summary>
    /// This function will stop or play the music.
    /// </summary>
    public void ClickOnMute()
    {
        _goManager.m_goCanvasManager.ClickOnMute();
    }
    /// <summary>
    /// This function will change Language.
    /// </summary>
    public void OnValueChangeLanguage()
    {
        _sndManager.PlayMouseClickButtonSnd();
        _languageManager.ChangeLanguage();      
    }
    /// <summary>
    /// Function use to show Pop Up Credit from Canvas Manager.
    /// </summary>
    public void ClickOnCreditCanvasManager()
    {
        _sndManager.PlayMouseClickButtonSnd();
        _goManager.EnableGameObject(_goManager.m_goCanvasManager.m_goPopUpCreditCanvasManager);

        _goManager.DesactivateAllObjects();
    }
    /// <summary>
    /// Function use to hide Pop Up Credit from Canvas Manager.
    /// </summary>
    public void ClickOnClosePopUpCreditCanvasManager()
    {
        _sndManager.PlayMouseClickButtonSnd();
        _goManager.DisableGameObject(_goManager.m_goCanvasManager.m_goPopUpCreditCanvasManager);

        _goManager.m_goCanvasManager.ActivateObjects();
        _goManager.ActivateGoodObjects();
    }
    /// <summary>
    /// Function use to show Pop Up Quit from Canvas Manager.
    /// </summary>
    public void ClickOnQuitCanvasManager()
    {
        _sndManager.PlayMouseClickButtonSnd();
        _goManager.EnableGameObject(_goManager.m_goCanvasManager.m_goPopUpQuitCanvasManager);

        _goManager.DesactivateAllObjects();
    }
    /// <summary>
    /// Function use to Quit Application.
    /// </summary>
    public void ClickOnYesPopUpQuitCanvasManager()
    {
        _sndManager.PlayMouseClickButtonSnd();
        Application.Quit();
    }
    /// <summary>
    /// Function use to cancel Quit Application.
    /// </summary>
    public void ClickOnNoPopUpQuitCanvasManager()
    {
        _sndManager.PlayMouseClickButtonSnd();
        _goManager.DisableGameObject(_goManager.m_goCanvasManager.m_goPopUpQuitCanvasManager);

        _goManager.m_goCanvasManager.ActivateObjects();
        _goManager.ActivateGoodObjects();
    }
    #endregion

    #region Canvas Sign In
    /// <summary>
    /// This function will try to connect the player to his account.
    /// </summary>
    public void ClickOnConnectionCanvasSignIn()
    {
        _sndManager.PlayMouseClickButtonSnd();

        string pseudo = _goManager.m_goCanvasSignIn.m_inputInputPseudoCanvasSignIn.text;
        string password = _goManager.m_goCanvasSignIn.m_inputInputPasswordCanvasSignIn.text;
        TextMeshProUGUI infoText = _goManager.m_goCanvasSignIn.m_tmpTxtInfoConnectionCanvasSignIn;
        TMP_InputField inputPseudo = _goManager.m_goCanvasSignIn.m_inputInputPseudoCanvasSignIn;
        TMP_InputField inputPassword = _goManager.m_goCanvasSignIn.m_inputInputPasswordCanvasSignIn;

        if (_dbManager.m_dbVerification.IsGoodPassword(pseudo, password, infoText, inputPseudo, inputPassword))
        {
            _goManager.DisableGameObject(_goManager.m_goCanvasManager.m_goCanvasManager);
           

            _dbManager.m_actualPseudo = pseudo;
            _dbManager.m_actualEmail = _dbManager.m_dbGet.GetEmail(pseudo);
            _dbManager.m_actualLastName = _dbManager.m_dbGet.GetLastName(pseudo);
            _dbManager.m_actualFirstName = _dbManager.m_dbGet.GetFirstName(pseudo);

            _goManager.m_goCanvasSignIn.Reinitialize();

            _goManager.DisableGameObject(_goManager.m_goCanvasManager.m_goCanvasManager);
            // _languageManager.SetProfileCanvasProfile();
            //_dbManager.m_dbGet.GetProfileImage(_dbManager.m_actualPseudo);
        }
    }
    /// <summary>
    /// Function use to access to the functionnality "Forgot Password".
    /// </summary>
    public void ClickOnForgotPassword()
    {
        _sndManager.PlayMouseClickButtonSnd();

        _goManager.DisableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
        _goManager.EnableGameObject(_goManager.m_goCanvasForgotPassword.m_goCanvasForgotPassword);

        _goManager.m_goCanvasForgotPassword.Reinitialize();
    }
    /// <summary>
    /// Function use to access to the functionnality "Register".
    /// </summary>
    public void ClickOnNeedAnAccount()
    {
        _sndManager.PlayMouseClickButtonSnd();

        _goManager.DisableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
        _goManager.EnableGameObject(_goManager.m_goCanvasSignOn.m_goCanvasSignOn);

        _goManager.m_goCanvasSignOn.Reinitialize();
    }
    #endregion

    #region Canvas Sign On
    /// <summary>
    /// Function use to check if a pseudo and a password exist on the database, if exist, the connection to the launcher is allow, else an error's message is sent.
    /// </summary>
    public void ClickOnPseudoExistCanvasSignOn()
    {
        _sndManager.PlayMouseClickButtonSnd();

        TMP_InputField inputPseudo = _goManager.m_goCanvasSignOn.m_inputInputPseudoCanvasSignOn;
        TextMeshProUGUI info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoPseudoCanvasSignOn;
        _dbManager.m_dbVerification.IsFreePseudo(inputPseudo, info);
    }
    /// <summary>
    /// Function use to change visibilty of the password for the canvas Sign On.
    /// </summary>
    public void ClickOnPasswordVisibilityCanvasSignOn()
    {
        _sndManager.PlaySwitchSnd();

        _goManager.m_goCanvasSignOn.ChangePasswordVisibility();
    }
    /// <summary>
    /// Function use to Register a player. If it's ok, the player will be register.
    /// </summary>
    public void ClickOnRegisterCanvasSignOn()
    {
        _sndManager.PlayMouseClickButtonSnd();

        TMP_InputField input = _goManager.m_goCanvasSignOn.m_inputInputPseudoCanvasSignOn;
        TextMeshProUGUI info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoPseudoCanvasSignOn;
        _dbManager.m_dbVerification.IsValidPseudo(input, info);
        string pseudo = input.text;

        input = _goManager.m_goCanvasSignOn.m_inputInputPasswordCanvasSignOn;
        info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoPasswordCanvasSignOn;
        _dbManager.m_dbVerification.IsValidPassword(input, info);
        string password = input.text;

        input = _goManager.m_goCanvasSignOn.m_inputInputEmailCanvasSignOn;
        info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoEmailCanvasSignOn;
        _dbManager.m_dbVerification.IsValidEmail(input, info);
        string email = input.text;

        input = _goManager.m_goCanvasSignOn.m_inputInputFirstNameCanvasSignOn;
        info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoFirstNameCanvasSignOn;
        _dbManager.m_dbVerification.IsValidFirstName(input, info);
        string firstName = input.text;

        input = _goManager.m_goCanvasSignOn.m_inputInputLastNameCanvasSignOn;
        info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoLastNameCanvasSignOn;
        _dbManager.m_dbVerification.IsValidLastName(input, info);
        string lastName = input.text;

        if (_dbManager.m_dbVerification.IsValidRegister())
        {
            _goManager.EnableGameObject(_goManager.m_goCanvasSignOn.m_goPopUpRegisterCanvasSignOn);
            _goManager.m_goCanvasSignOn.DesactivateObjects();
            _dbManager.m_dbRegister.Register(pseudo, password, email, firstName, lastName);
        }
    }
    /// <summary>
    /// Function use to back to the Sign In Canvas after a register.
    /// </summary>
    public void ClickOnSignInCanvasSignOn()
    {
        _sndManager.PlayMouseClickButtonSnd();

        _goManager.m_goCanvasSignIn.Reinitialize();

        _goManager.DisableGameObject(_goManager.m_goCanvasSignOn.m_goPopUpRegisterCanvasSignOn);
        _goManager.DisableGameObject(_goManager.m_goCanvasSignOn.m_goCanvasSignOn);
        _goManager.EnableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);

        _goManager.m_goCanvasSignOn.Reinitialize();     
    }
    /// <summary>
    /// Function use to back to the Sign In Canvas, cancel a registration.
    /// </summary>
    public void ClickOnBackCanvasSignOn()
    {
        _sndManager.PlayMouseClickButtonSnd();

        _goManager.m_goCanvasSignIn.Reinitialize();

        _goManager.DisableGameObject(_goManager.m_goCanvasSignOn.m_goCanvasSignOn);
        _goManager.EnableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);

        _goManager.m_goCanvasSignOn.Reinitialize();
    }
    #endregion

    #region Canvas Forgot Password
    /// <summary>
    /// Function use to send an email to the user with a Verification Code.
    /// </summary>
    public void ClickOnSendEmailCanvasForgotPassword()
    {
        _sndManager.PlayMouseClickButtonSnd();

        TMP_InputField inputEmail = _goManager.m_goCanvasForgotPassword.m_inputInputEmailForgotPassword;
        TextMeshProUGUI infoEmail = _goManager.m_goCanvasForgotPassword.m_tmpTxtInfoInputEmailForgotPassword;
        string email = inputEmail.text;

        if (_dbManager.m_dbVerification.DoesEmailExist(inputEmail, infoEmail))
        {
            _dbManager.m_sendEmail.ForgotPassword(email);

            _goManager.EnableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpVerification);
            _goManager.m_goCanvasForgotPassword.Reinitialize();
            _goManager.m_goCanvasForgotPassword.DesactivateObjects();
        }
    }
    /// <summary>
    /// Function use to back to Sign In from Forgot Password.
    /// </summary>
    public void ClickOnBackCanvasForgotPassword()
    {
        _sndManager.PlayMouseClickButtonSnd();

        _goManager.m_goCanvasSignIn.Reinitialize();

        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goCanvasForgotPassword);
        _goManager.EnableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);

        _goManager.m_goCanvasForgotPassword.Reinitialize();
    }
    /// <summary>
    /// Function use to check if an enter code is the good one.
    /// </summary>
    public void ClickOnVerifyPopUpVerificationCanvasForgotPassword()
    {
        _sndManager.PlayMouseClickButtonSnd();

        string actualVerifyCode = _dbManager.m_sendEmail.m_actualVerifyCode;

        TMP_InputField inputCode = _goManager.m_goCanvasForgotPassword.m_inputInputCodePopUpVerification;
        TextMeshProUGUI infoCode = _goManager.m_goCanvasForgotPassword.m_tmpTxtInfoInputCodePopUpVerification;
        string enterCode = inputCode.text;

        if (_dbManager.m_dbVerification.VerifyCode(inputCode, infoCode, actualVerifyCode, enterCode))
        {
            _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpVerification);
            _goManager.EnableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpChangePassword);

            _goManager.m_goCanvasForgotPassword.Reinitialize();
            _goManager.m_goCanvasForgotPassword.DesactivateObjects();
        }
    }
    /// <summary>
    /// Function use to back to forgot password from Pop Up verification.
    /// </summary>
    public void ClickOnBackPopUpVerificationCanvasForgotPassword()
    {
        _sndManager.PlayMouseClickButtonSnd();

        _goManager.m_goCanvasForgotPassword.Reinitialize();

        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpVerification);
    }
    /// <summary>
    /// Function use to check if a password and his confirm are the same. If it is, change the actual password for the player.
    /// </summary>
    public void ClickOnConfirmPopUpChangePasswordCanvasForgotPassword()
    {
        _sndManager.PlayMouseClickButtonSnd();

        TMP_InputField inputNewPassword = _goManager.m_goCanvasForgotPassword.m_inputInputNewPasswordPopUpChangePassword;
        TMP_InputField inputConfirmPassword = _goManager.m_goCanvasForgotPassword.m_inputInputConfirmPasswordPopUpChangePassword;
        TextMeshProUGUI infoPasswords = _goManager.m_goCanvasForgotPassword.m_tmpTxtInfoPasswordPopUpChangePassword;
        string actualEmailSend = _dbManager.m_sendEmail.m_actualemailSent;

        if (_dbManager.m_dbVerification.VerifyNewPasswordAndConfirmPassword(inputNewPassword, inputConfirmPassword, infoPasswords, actualEmailSend))
        {
            _dbManager.m_dbChangePassword.ChangePassword(actualEmailSend, inputNewPassword.text);

            _goManager.m_goCanvasForgotPassword.Reinitialize();
            _goManager.m_goCanvasForgotPassword.DesactivateObjects();

            _goManager.EnableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpPasswordChange);         
        }
    }
    /// <summary>
    /// Function use to change visibilty of the new password for the Pop Up Change Password from the canvas forgot password.
    /// </summary>
    public void ClickOnNewPasswordVisibilityPopUpChangePasswordCanvasForgotPassword()
    {
        _sndManager.PlaySwitchSnd();

        _goManager.m_goCanvasForgotPassword.ChangeNewPasswordVisibility();
    }
    /// <summary>
    /// Function use to change visibilty of the confirm password for the Pop Up Change Password from the canvas forgot password.
    /// </summary>
    public void ClickOnConfirmPasswordVisibilityPopUpChangePasswordCanvasForgotPassword()
    {
        _sndManager.PlaySwitchSnd();

        _goManager.m_goCanvasForgotPassword.ChangeNewPasswordVisibility();
    }
    /// <summary>
    /// Function use back to Forgot Password for from Pop Up Change Password.
    /// </summary>
    public void ClickOnCancelPopUpChangePasswordCanvasForgotPassword()
    {
        _goManager.m_goCanvasForgotPassword.Reinitialize();

        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpChangePassword);      
    }
    /// <summary>
    /// Function use back to Sign In from Pop Up Password Change.
    /// </summary>
    public void ClickOnSignInPopUpPasswordChangeCanvasForgotPassword()
    {
        _goManager.m_goCanvasSignIn.Reinitialize();

        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpPasswordChange);
        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpChangePassword);
        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goCanvasForgotPassword);
        _goManager.EnableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);

        _goManager.m_goCanvasForgotPassword.Reinitialize();
    }
    #endregion

    #endregion
}
