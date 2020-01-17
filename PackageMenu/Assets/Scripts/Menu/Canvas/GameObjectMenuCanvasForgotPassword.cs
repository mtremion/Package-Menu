using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Forgot Password.
/// </summary>
[Serializable]
public class GameObjectMenuCanvasForgotPassword
{
    #region SerializeField
    [Header("Canvas Forgot Password")]
    [Tooltip("GameObject Canvas Forgot Password")]
    [SerializeField] GameObject goCanvasForgotPassword = null;
    [Header("Background")]
    [Tooltip("Background of the Canvas Forgot Password.")]
    [SerializeField] GameObject goBackgroundForgotPassword = null;
    [Header("Title")]
    [Tooltip("Title of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTxtTitleForgotPassword = null;
    [Header("Input Email")]
    [Tooltip("Input Email of the Canvas Forgot Password.")]
    [SerializeField] GameObject goInputEmailForgotPassword = null;
    [Tooltip("Placeholder Input Email of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTxtPHInputEmailForgotPassword = null;
    [Tooltip("Txt Input Email of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTxtInputEmailForgotPassword = null;
    [Header("Info Input Email")]
    [Tooltip("Txt Info Input Email of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTxtInfoInputEmailForgotPassword = null;
    [Header("Button Send")]
    [Tooltip("Button Send of the Canvas Forgot Password.")]
    [SerializeField] GameObject goBtnSendForgotPassword = null;
    [Tooltip("Txt Button Send of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTxtBtnSendForgotPassword = null;
    [Header("Button Back")]
    [Tooltip("Button Back of the Canvas Forgot Password.")]
    [SerializeField] GameObject goBtnBackForgotPassword = null;
    [Tooltip("Txt Button Back of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTxtBtnBackForgotPassword = null;
    [Header("Pop Up Verification / Canvas Pop Up Verification")]
    [Tooltip("GameObject Canvas Pop Up Verification of Forgot Password")]
    [SerializeField] GameObject goPopUpVerifyForgotPassword = null;
    [Header("Background Pop Up Verification")]
    [Tooltip("Background of the Pop Up Verification.")]
    [SerializeField] GameObject goBackgroundPopUpVerification = null;
    [Header("Title Pop Up Verification")]
    [Tooltip("Title of the Pop Up Verification.")]
    [SerializeField] GameObject goTxtTitlePopUpVerification = null;
    [Header("Input Code Pop Up Verification")]
    [Tooltip("Input Code of the Pop Up Verification.")]
    [SerializeField] GameObject goInputCodePopUpVerification = null;
    [Tooltip("Placeholder Input Code of the Pop Up Verification.")]
    [SerializeField] GameObject goTxtPHInputCodePopUpVerification = null;
    [Tooltip("Txt Input Code of the Pop Up Verification.")]
    [SerializeField] GameObject goTxtInputCodePopUpVerification = null;
    [Header("Info Input Code Pop Up Verification")]
    [Tooltip("Txt Input Code of the Pop Up Verification.")]
    [SerializeField] GameObject goTxtInfoInputCodePopUpVerification = null;
    [Header("Button Verify Pop Up Verification")]
    [Tooltip("Button Verify of the Pop Up Verification.")]
    [SerializeField] GameObject goBtnVerifyPopUpVerification = null;
    [Tooltip("Txt Button Back of the Pop Up Verification.")]
    [SerializeField] GameObject goTxtBtnVerifyPopUpVerification = null;
    [Header("Button Back")]
    [Tooltip("Button Back of the Pop Up Verification.")]
    [SerializeField] GameObject goBtnBackPopUpVerification = null;
    [Tooltip("Txt Button Back of the Pop Up Verification.")]
    [SerializeField] GameObject goTxtBtnBackPopUpVerification = null;
    [Header("Pop Up Change Password / Canvas Pop Up Change Password")]
    [Tooltip("GameObject Canvas Pop Up Change Password of Forgot Password")]
    [SerializeField] GameObject goPopUpChangePasswordForgotPassword = null;
    [Header("Background Pop Up Change Password")]
    [Tooltip("Background of the Pop Up Change Password.")]
    [SerializeField] GameObject goBackgroundPopUpChangePassword = null;
    [Header("Title Pop Up Change Password")]
    [Tooltip("Title of the Pop Up Change Password.")]
    [SerializeField] GameObject goTxtTitlePopUpChangePassword = null;
    [Header("Input New Password Pop Up Change Passwod")]
    [Tooltip("Input New Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goInputNewPasswordPopUpChangePassword = null;
    [Tooltip("Placeholder Input New Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goTxtPHInputNewPasswordPopUpChangePassword = null;
    [Tooltip("Txt Input New Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goTxtInputNewPasswordPopUpChangePassword = null;
    [Header("Button New Password Visibility")]
    [Tooltip("Button New Password Visibility of the Pop Up Change Password.")]
    [SerializeField] GameObject goBtnNewPasswordVisibilityPopUpChangePassword = null;
    [Header("Input Confirm Password Pop Up Change Passwod")]
    [Tooltip("Input Confirm Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goInputConfirmPasswordPopUpChangePassword = null;
    [Tooltip("Placeholder Input Confirm Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goTxtPHInputConfirmPasswordPopUpChangePassword = null;
    [Tooltip("Txt Input Confirm Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goTxtInputConfirmPasswordPopUpChangePassword = null;
    [Header("Button Confirm Password Visibility")]
    [Tooltip("Button Confirm Password Visibility of the Pop Up Change Password.")]
    [SerializeField] GameObject goBtnConfirmPasswordVisibilityPopUpChangePassword = null;
    [Header("Txt Info Password")]
    [Tooltip("Txt Info Password of the Pop Up Change Passwod.")]
    [SerializeField] GameObject goTxtInfoPasswordPopUpChangePassword = null;
    [Header("Button Confirm")]
    [Tooltip("Button Confirm of the Pop Up Change Password.")]
    [SerializeField] GameObject goBtnConfirmPopUpChangePassword = null;
    [Tooltip("Txt Button Confirm of the Pop Up Change Password.")]
    [SerializeField] GameObject goTxtBtnConfirmPopUpChangePassword = null;
    [Header("Button Back")]
    [Tooltip("Button Back of the Pop Up Change Password.")]
    [SerializeField] GameObject goBtnBackPopUpChangePassword = null;
    [Tooltip("Txt Button Back of the Pop Up Change Password.")]
    [SerializeField] GameObject goTxtBtnBackPopUpChangePassword = null;
    [Header("Pop Up Password Change / Canvas Pop Up Password Change")]
    [Tooltip("GameObject Canvas Pop Up Password Change of Forgot Password")]
    [SerializeField] GameObject goPopUpPasswordChangeForgotPassword = null;
    [Header("Background Pop Up Change Password")]
    [Tooltip("Background of the Pop Up PasswordChange.")]
    [SerializeField] GameObject goBackgroundPopUpPasswordChange = null;
    [Header("Title Pop Up PasswordChange")]
    [Tooltip("Title of the Pop Up PasswordChange.")]
    [SerializeField] GameObject goTxtTitlePopUpPasswordChange = null;
    [Header("Button Sign In")]
    [Tooltip("Button Sign In of the Pop Up Change Password.")]
    [SerializeField] GameObject goBtnSignInPopUpChangePassword = null;
    [Tooltip("Txt Button Sign In of the Pop Up Change Password.")]
    [SerializeField] GameObject goTxtBtnSignInPopUpChangePassword = null;
    #endregion

    #region Getters & Setters
    public GameObject m_goCanvasForgotPassword { get { return goCanvasForgotPassword; } }
    public GameObject m_goPopUpVerification { get { return goPopUpVerifyForgotPassword; } }
    public GameObject m_goPopUpChangePassword { get { return goPopUpChangePasswordForgotPassword; } }
    public GameObject m_goPopUpPasswordChange { get { return goPopUpPasswordChangeForgotPassword; } }

    public TextMeshProUGUI m_tmpTxtTitleForgotPassword { get { return _tmpTxtTitleForgotPassword; } }
    public TextMeshProUGUI m_tmpTxtPHInputEmailForgotPassword { get { return _tmpTxtPHInputEmailForgotPassword; } }
    public TextMeshProUGUI m_tmpTxtInputEmailForgotPassword { get { return _tmpTxtInputEmailForgotPassword; } }
    public TextMeshProUGUI m_tmpTxtInfoInputEmailForgotPassword { get { return _tmpTxtInfoInputEmailForgotPassword; } }
    public TextMeshProUGUI m_tmpTxtBtnSendForgotPassword { get { return _tmpTxtBtnSendForgotPassword; } }
    public TextMeshProUGUI m_tmpTxtBtnBackForgotPassword { get { return _tmpTxtBtnBackForgotPassword; } }
    public TextMeshProUGUI m_tmpTxtTitlePopUpVerification { get { return _tmpTxtTitlePopUpVerification; } }
    public TextMeshProUGUI m_tmpTxtPHInputCodePopUpVerification { get { return _tmpTxtPHInputCodePopUpVerification; } }
    public TextMeshProUGUI m_tmpTxtInputCodePopUpVerification { get { return _tmpTxtInputCodePopUpVerification; } }
    public TextMeshProUGUI m_tmpTxtInfoInputCodePopUpVerification { get { return _tmpTxtInfoInputCodePopUpVerification; } }
    public TextMeshProUGUI m_tmpTxtBtnVerifyPopUpVerification { get { return _tmpTxtBtnVerifyPopUpVerification; } }
    public TextMeshProUGUI m_tmpTxtBtnBackPopUpVerification { get { return _tmpTxtBtnBackPopUpVerification; } }
    public TextMeshProUGUI m_tmpTxtTitlePopUpChangePassword { get { return _tmpTxtTitlePopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtPHInputNewPasswordPopUpChangePassword { get { return _tmpTxtPHInputNewPasswordPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtInputNewPasswordPopUpChangePassword { get { return _tmpTxtInputNewPasswordPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtPHInputConfirmPasswordPopUpChangePassword { get { return _tmpTxtPHInputConfirmPasswordPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtInputConfirmPasswordPopUpChangePassword { get { return _tmpTxtInputConfirmPasswordPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtInfoPasswordPopUpChangePassword { get { return _tmpTxtInfoPasswordPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtBtnConfirmPopUpChangePassword { get { return _tmpTxtBtnConfirmPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtBtnBackPopUpChangePassword { get { return _tmpTxtBtnBackPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtTitlePopUpPasswordChange { get { return _tmpTxtTitlePopUpPasswordChange; } }
    public TextMeshProUGUI m_tmpTxtBtnSignInPopUpChangePassword { get { return _tmpTxtBtnSignInPopUpChangePassword; } }

    public Button m_btnBtnSendForgotPassword { get { return _btnBtnSendForgotPassword; } }
    public Button m_btnBtnBackForgotPassword { get { return _btnBtnBackForgotPassword; } }
    public Button m_btnBtnVerifyPopUpVerification { get { return _btnBtnVerifyPopUpVerification; } }
    public Button m_btnBtnBackPopUpVerification { get { return _btnBtnBackPopUpVerification; } }
    public Button m_btnBtnNewPasswordVisibilityPopUpChangePassword { get { return _btnBtnNewPasswordVisibilityPopUpChangePassword; } }
    public Button m_btnBtnConfirmPasswordVisibilityPopUpChangePassword { get { return _btnBtnConfirmPasswordVisibilityPopUpChangePassword; } }
    public Button m_btnBtnConfirmPopUpChangePassword { get { return _btnBtnConfirmPopUpChangePassword; } }
    public Button m_btnBtnBackPopUpChangePassword { get { return _btnBtnBackPopUpChangePassword; } }
    public Button m_btnBtnSignInPopUpChangePassword { get { return _btnBtnSignInPopUpChangePassword; } }

    public TMP_InputField m_inputInputEmailForgotPassword { get { return _inputInputEmailForgotPassword; } }
    public TMP_InputField m_inputInputCodePopUpVerification { get { return _inputInputCodePopUpVerification; } }
    public TMP_InputField m_inputInputNewPasswordPopUpChangePassword { get { return _inputInputNewPasswordPopUpChangePassword; } }
    public TMP_InputField m_inputInputConfirmPasswordPopUpChangePassword { get { return _inputInputConfirmPasswordPopUpChangePassword; } }

    public Image m_imgBackgroundForgotPassword { get { return _imgBackgroundForgotPassword; } }
    public Image m_imgInputEmailForgotPassword { get { return _imgInputEmailForgotPassword; } }
    public Image m_imgBtnSendForgotPassword { get { return _imgBtnSendForgotPassword; } }
    public Image m_imgBtnBackForgotPassword { get { return _imgBtnBackForgotPassword; } }
    public Image m_imgBackgroundPopUpVerification { get { return _imgBackgroundPopUpVerification; } }
    public Image m_imgInputCodePopUpVerification { get { return _imgInputCodePopUpVerification; } }
    public Image m_imgBtnVerifyPopUpVerification { get { return _imgBtnVerifyPopUpVerification; } }
    public Image m_imgBtnBackPopUpVerification { get { return _imgBtnBackPopUpVerification; } }
    public Image m_imgBackgroundPopUpChangePassword { get { return _imgBackgroundPopUpChangePassword; } }
    public Image m_imgInputNewPasswordPopUpChangePassword { get { return _imgInputNewPasswordPopUpChangePassword; } }
    public Image m_imgBtnNewPasswordVisibilityPopUpChangePassword { get { return _imgBtnNewPasswordVisibilityPopUpChangePassword; } }
    public Image m_imgInputConfirmPasswordPopUpChangePassword { get { return _imgInputConfirmPasswordPopUpChangePassword; } }
    public Image m_imgBtnConfirmPasswordVisibilityPopUpChangePassword { get { return _imgBtnConfirmPasswordVisibilityPopUpChangePassword; } }
    public Image m_imgBtnConfirmPopUpChangePassword { get { return _imgBtnConfirmPopUpChangePassword; } }
    public Image m_imgBtnBackPopUpChangePassword { get { return _imgBtnBackPopUpChangePassword; } }

    public Image m_imgBackgroundPopUpPasswordChange { get { return _imgBackgroundPopUpPasswordChange; } }
    public Image m_imgBtnSignInPopUpChangePassword { get { return _imgBtnSignInPopUpChangePassword; } }
    #endregion

    #region Private
    DataBaseManager _dbManager = null;
    DesignMenuManager _designMenuManager = null;
    TextMeshProUGUI _tmpTxtTitleForgotPassword = null, _tmpTxtPHInputEmailForgotPassword = null, _tmpTxtInputEmailForgotPassword = null,
                _tmpTxtInfoInputEmailForgotPassword = null, _tmpTxtBtnSendForgotPassword = null, _tmpTxtBtnBackForgotPassword = null,
                _tmpTxtTitlePopUpVerification = null, _tmpTxtPHInputCodePopUpVerification = null, _tmpTxtInputCodePopUpVerification = null,
                _tmpTxtInfoInputCodePopUpVerification = null, _tmpTxtBtnVerifyPopUpVerification = null, _tmpTxtBtnBackPopUpVerification = null,
                _tmpTxtTitlePopUpChangePassword = null, _tmpTxtPHInputNewPasswordPopUpChangePassword = null, _tmpTxtInputNewPasswordPopUpChangePassword = null,
                _tmpTxtPHInputConfirmPasswordPopUpChangePassword = null, _tmpTxtInputConfirmPasswordPopUpChangePassword = null, _tmpTxtInfoPasswordPopUpChangePassword = null,
                _tmpTxtBtnConfirmPopUpChangePassword = null, _tmpTxtBtnBackPopUpChangePassword = null, _tmpTxtTitlePopUpPasswordChange = null,
                _tmpTxtBtnSignInPopUpChangePassword = null;
    Button _btnBtnSendForgotPassword = null, _btnBtnBackForgotPassword = null, _btnBtnVerifyPopUpVerification = null,
        _btnBtnBackPopUpVerification = null, _btnBtnNewPasswordVisibilityPopUpChangePassword = null, _btnBtnConfirmPasswordVisibilityPopUpChangePassword = null,
        _btnBtnConfirmPopUpChangePassword = null, _btnBtnBackPopUpChangePassword = null, _btnBtnSignInPopUpChangePassword = null;
    TMP_InputField _inputInputEmailForgotPassword = null, _inputInputCodePopUpVerification = null, _inputInputNewPasswordPopUpChangePassword = null,
                _inputInputConfirmPasswordPopUpChangePassword = null;
    Image _imgBackgroundForgotPassword = null, _imgInputEmailForgotPassword = null, _imgBtnSendForgotPassword = null,
        _imgBtnBackForgotPassword = null, _imgBackgroundPopUpVerification = null, _imgInputCodePopUpVerification = null,
        _imgBtnVerifyPopUpVerification = null, _imgBtnBackPopUpVerification = null, _imgBackgroundPopUpChangePassword = null,
        _imgInputNewPasswordPopUpChangePassword = null, _imgBtnNewPasswordVisibilityPopUpChangePassword = null, _imgInputConfirmPasswordPopUpChangePassword = null,
        _imgBtnConfirmPasswordVisibilityPopUpChangePassword = null, _imgBtnConfirmPopUpChangePassword = null, _imgBtnBackPopUpChangePassword = null,
        _imgBackgroundPopUpPasswordChange = null, _imgBtnSignInPopUpChangePassword = null;
    bool _newPasswordVisible = false, _confirmPasswordVisible = false;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();
        _designMenuManager = GameObject.Find("DesignMenuManager").GetComponent<DesignMenuManager>();

        _tmpTxtTitleForgotPassword = goTxtTitleForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputEmailForgotPassword = goTxtPHInputEmailForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputEmailForgotPassword = goTxtInputEmailForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoInputEmailForgotPassword = goTxtInfoInputEmailForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnSendForgotPassword = goTxtBtnSendForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnBackForgotPassword = goTxtBtnBackForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtTitlePopUpVerification = goTxtTitlePopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputCodePopUpVerification = goTxtPHInputCodePopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputCodePopUpVerification = goTxtInputCodePopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoInputCodePopUpVerification = goTxtInfoInputCodePopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnVerifyPopUpVerification = goTxtBtnVerifyPopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnBackPopUpVerification = goTxtBtnBackPopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTxtTitlePopUpChangePassword = goTxtTitlePopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputNewPasswordPopUpChangePassword = goTxtPHInputNewPasswordPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputNewPasswordPopUpChangePassword = goTxtInputNewPasswordPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputConfirmPasswordPopUpChangePassword = goTxtPHInputConfirmPasswordPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputConfirmPasswordPopUpChangePassword = goTxtInputConfirmPasswordPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoPasswordPopUpChangePassword = goTxtInfoPasswordPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnConfirmPopUpChangePassword = goTxtBtnConfirmPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnBackPopUpChangePassword = goTxtBtnBackPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtTitlePopUpPasswordChange = goTxtTitlePopUpPasswordChange.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnSignInPopUpChangePassword = goTxtBtnSignInPopUpChangePassword.GetComponent<TextMeshProUGUI>();

        _btnBtnSendForgotPassword = goBtnSendForgotPassword.GetComponent<Button>();
        _btnBtnBackForgotPassword = goBtnBackForgotPassword.GetComponent<Button>();
        _btnBtnVerifyPopUpVerification = goBtnVerifyPopUpVerification.GetComponent<Button>();
        _btnBtnBackPopUpVerification = goBtnBackPopUpVerification.GetComponent<Button>();
        _btnBtnNewPasswordVisibilityPopUpChangePassword = goBtnNewPasswordVisibilityPopUpChangePassword.GetComponent<Button>();
        _btnBtnConfirmPasswordVisibilityPopUpChangePassword = goBtnConfirmPasswordVisibilityPopUpChangePassword.GetComponent<Button>();
        _btnBtnConfirmPopUpChangePassword = goBtnConfirmPopUpChangePassword.GetComponent<Button>();
        _btnBtnBackPopUpChangePassword = goBtnBackPopUpChangePassword.GetComponent<Button>();
        _btnBtnSignInPopUpChangePassword = goBtnSignInPopUpChangePassword.GetComponent<Button>();

        _inputInputEmailForgotPassword = goInputEmailForgotPassword.GetComponent<TMP_InputField>();
        _inputInputCodePopUpVerification = goInputCodePopUpVerification.GetComponent<TMP_InputField>();
        _inputInputNewPasswordPopUpChangePassword = goInputNewPasswordPopUpChangePassword.GetComponent<TMP_InputField>();
        _inputInputConfirmPasswordPopUpChangePassword = goInputConfirmPasswordPopUpChangePassword.GetComponent<TMP_InputField>();

        _imgBackgroundForgotPassword = goBackgroundForgotPassword.GetComponent<Image>();
        _imgInputEmailForgotPassword = goInputEmailForgotPassword.GetComponent<Image>();
        _imgBtnSendForgotPassword = goBtnSendForgotPassword.GetComponent<Image>();
        _imgBtnBackForgotPassword = goBtnBackForgotPassword.GetComponent<Image>();
        _imgBackgroundPopUpVerification = goBackgroundPopUpVerification.GetComponent<Image>();
        _imgInputCodePopUpVerification = goInputCodePopUpVerification.GetComponent<Image>();
        _imgBtnVerifyPopUpVerification = goBtnVerifyPopUpVerification.GetComponent<Image>();
        _imgBtnBackPopUpVerification = goBtnBackPopUpVerification.GetComponent<Image>();
        _imgBackgroundPopUpChangePassword = goBackgroundPopUpChangePassword.GetComponent<Image>();
        _imgInputNewPasswordPopUpChangePassword = goInputNewPasswordPopUpChangePassword.GetComponent<Image>();
        _imgBtnNewPasswordVisibilityPopUpChangePassword = goBtnNewPasswordVisibilityPopUpChangePassword.GetComponent<Image>();
        _imgInputConfirmPasswordPopUpChangePassword = goInputConfirmPasswordPopUpChangePassword.GetComponent<Image>();
        _imgBtnConfirmPasswordVisibilityPopUpChangePassword = goBtnConfirmPasswordVisibilityPopUpChangePassword.GetComponent<Image>();
        _imgBtnConfirmPopUpChangePassword = goBtnConfirmPopUpChangePassword.GetComponent<Image>();
        _imgBtnBackPopUpChangePassword = goBtnBackPopUpChangePassword.GetComponent<Image>();
        _imgBackgroundPopUpPasswordChange = goBackgroundPopUpPasswordChange.GetComponent<Image>();
        _imgBtnSignInPopUpChangePassword = goBtnSignInPopUpChangePassword.GetComponent<Image>();

    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function will init object for the Canvas Sign On.
    /// </summary>
    public void Init()
    {
        _tmpTxtTitleForgotPassword.font = _designMenuManager.m_font;
        _tmpTxtTitleForgotPassword.color = _designMenuManager.m_colorText;
        _tmpTxtPHInputEmailForgotPassword.font = _designMenuManager.m_font;
        _tmpTxtPHInputEmailForgotPassword.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputEmailForgotPassword.font = _designMenuManager.m_font;
        _tmpTxtInputEmailForgotPassword.color = _designMenuManager.m_colorText;
        _tmpTxtInfoInputEmailForgotPassword.font = _designMenuManager.m_font;
        _tmpTxtBtnSendForgotPassword.font = _designMenuManager.m_font;
        _tmpTxtBtnSendForgotPassword.color = _designMenuManager.m_colorText;
        _tmpTxtBtnBackForgotPassword.font = _designMenuManager.m_font;
        _tmpTxtBtnBackForgotPassword.color = _designMenuManager.m_colorText;
        _tmpTxtTitlePopUpVerification.font = _designMenuManager.m_font;
        _tmpTxtTitlePopUpVerification.color = _designMenuManager.m_colorText;
        _tmpTxtPHInputCodePopUpVerification.font = _designMenuManager.m_font;
        _tmpTxtPHInputCodePopUpVerification.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputCodePopUpVerification.font = _designMenuManager.m_font;
        _tmpTxtInputCodePopUpVerification.color = _designMenuManager.m_colorText;
        _tmpTxtInfoInputCodePopUpVerification.font = _designMenuManager.m_font;
        _tmpTxtBtnVerifyPopUpVerification.font = _designMenuManager.m_font;
        _tmpTxtBtnVerifyPopUpVerification.color = _designMenuManager.m_colorText;
        _tmpTxtBtnBackPopUpVerification.font = _designMenuManager.m_font;
        _tmpTxtBtnBackPopUpVerification.color = _designMenuManager.m_colorText;
        _tmpTxtTitlePopUpChangePassword.font = _designMenuManager.m_font;
        _tmpTxtTitlePopUpChangePassword.color = _designMenuManager.m_colorText;
        _tmpTxtPHInputNewPasswordPopUpChangePassword.font = _designMenuManager.m_font;
        _tmpTxtPHInputNewPasswordPopUpChangePassword.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputNewPasswordPopUpChangePassword.font = _designMenuManager.m_font;
        _tmpTxtInputNewPasswordPopUpChangePassword.color = _designMenuManager.m_colorText;
        _tmpTxtPHInputConfirmPasswordPopUpChangePassword.font = _designMenuManager.m_font;
        _tmpTxtPHInputConfirmPasswordPopUpChangePassword.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputConfirmPasswordPopUpChangePassword.font = _designMenuManager.m_font;
        _tmpTxtInputConfirmPasswordPopUpChangePassword.color = _designMenuManager.m_colorText;
        _tmpTxtInfoPasswordPopUpChangePassword.font = _designMenuManager.m_font;
        _tmpTxtBtnConfirmPopUpChangePassword.font = _designMenuManager.m_font;
        _tmpTxtBtnConfirmPopUpChangePassword.color = _designMenuManager.m_colorText;
        _tmpTxtBtnBackPopUpChangePassword.font = _designMenuManager.m_font;
        _tmpTxtBtnBackPopUpChangePassword.color = _designMenuManager.m_colorText;
        _tmpTxtTitlePopUpPasswordChange.font = _designMenuManager.m_font;
        _tmpTxtTitlePopUpPasswordChange.color = _designMenuManager.m_colorText;
        _tmpTxtBtnSignInPopUpChangePassword.font = _designMenuManager.m_font;
        _tmpTxtBtnSignInPopUpChangePassword.color = _designMenuManager.m_colorText;

        _imgBackgroundForgotPassword.sprite = _designMenuManager.m_imgPopUp;
        _imgInputEmailForgotPassword.sprite = _designMenuManager.m_imgInput;
        _imgBtnSendForgotPassword.sprite = _designMenuManager.m_imgButton;
        _imgBtnBackForgotPassword.sprite = _designMenuManager.m_imgButton;
        _imgBackgroundPopUpVerification.sprite = _designMenuManager.m_imgPopUp;
        _imgInputCodePopUpVerification.sprite = _designMenuManager.m_imgInput;
        _imgBtnVerifyPopUpVerification.sprite = _designMenuManager.m_imgButton;
        _imgBtnBackPopUpVerification.sprite = _designMenuManager.m_imgButton;
        _imgBackgroundPopUpChangePassword.sprite = _designMenuManager.m_imgPopUp;
        _imgInputNewPasswordPopUpChangePassword.sprite = _designMenuManager.m_imgInput;
        _imgBtnNewPasswordVisibilityPopUpChangePassword.sprite = _designMenuManager.m_imgNotVisible;
        _imgInputConfirmPasswordPopUpChangePassword.sprite = _designMenuManager.m_imgInput;
        _imgBtnConfirmPasswordVisibilityPopUpChangePassword.sprite = _designMenuManager.m_imgNotVisible;
        _imgBtnConfirmPopUpChangePassword.sprite = _designMenuManager.m_imgButton;
        _imgBtnBackPopUpChangePassword.sprite = _designMenuManager.m_imgButton;
        _imgBackgroundPopUpPasswordChange.sprite = _designMenuManager.m_imgPopUp;
        _imgBtnSignInPopUpChangePassword.sprite = _designMenuManager.m_imgButton;

        _inputInputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        _inputInputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;

        ActivateObjects();
    }
    /// <summary>
    /// This function will reinitialize info text and input block Color for the Canvas Forgot Password.
    /// </summary>
    public void Reinitialize()
    {
        _tmpTxtInfoInputEmailForgotPassword.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoInputCodePopUpVerification.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoPasswordPopUpChangePassword.text = _dbManager.m_message.BaseMessage();
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputEmailForgotPassword, _designMenuManager.m_colorInputBase);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputCodePopUpVerification, _designMenuManager.m_colorInputBase);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputNewPasswordPopUpChangePassword, _designMenuManager.m_colorInputBase);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputConfirmPasswordPopUpChangePassword, _designMenuManager.m_colorInputBase);
        _tmpTxtInputEmailForgotPassword.text = _dbManager.m_message.BaseMessage(); ;
        _tmpTxtInputCodePopUpVerification.text = _dbManager.m_message.BaseMessage(); ;
        _tmpTxtInputNewPasswordPopUpChangePassword.text = _dbManager.m_message.BaseMessage(); ;
        _tmpTxtInputConfirmPasswordPopUpChangePassword.text = _dbManager.m_message.BaseMessage(); ;
        _imgBtnNewPasswordVisibilityPopUpChangePassword.sprite = _designMenuManager.m_imgNotVisible;
        _inputInputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        _imgBtnConfirmPasswordVisibilityPopUpChangePassword.sprite = _designMenuManager.m_imgNotVisible;
        _inputInputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        _newPasswordVisible = false;
        _confirmPasswordVisible = false;

        ActivateAllObjects();
    }
    /// <summary>
    /// This function will change the visibility of the new password.
    /// </summary>
    public void ChangeNewPasswordVisibility()
    {
        _newPasswordVisible = !_newPasswordVisible;

        if (_newPasswordVisible)
        {
            _imgBtnNewPasswordVisibilityPopUpChangePassword.sprite = _designMenuManager.m_imgVisible;
            _inputInputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Alphanumeric;
        }
        else
        {
            _imgBtnNewPasswordVisibilityPopUpChangePassword.sprite = _designMenuManager.m_imgNotVisible;
            _inputInputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        }
    }
    /// <summary>
    /// This function will change the visibility of the confirm password.
    /// </summary>
    public void ChangeConfirmPasswordVisibility()
    {
        _confirmPasswordVisible = !_confirmPasswordVisible;

        if (_confirmPasswordVisible)
        {
            _imgBtnConfirmPasswordVisibilityPopUpChangePassword.sprite = _designMenuManager.m_imgVisible;
            _inputInputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Alphanumeric;
        }
        else
        {
            _imgBtnConfirmPasswordVisibilityPopUpChangePassword.sprite = _designMenuManager.m_imgNotVisible;
            _inputInputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        }
    }
    /// <summary>
    /// This function is use to desactive buttons/inputs/dropdows on the canvas forgot password.
    /// </summary>
    public void DesactivateObjects()
    {
        _btnBtnSendForgotPassword.interactable = false;
        _btnBtnBackForgotPassword.interactable = false;

        _inputInputEmailForgotPassword.interactable = false;
    }
    /// <summary>
    /// This function is use to desactive buttons/inputs/dropdows on the canvas forgot password Pop Up Change password.
    /// </summary>
    public void DesactivateObjectsPopUpVerification()
    {
        _btnBtnVerifyPopUpVerification.interactable = false;
        _btnBtnBackPopUpVerification.interactable = false;

        _inputInputCodePopUpVerification.interactable = false;
    }
    /// <summary>
    /// This function is use to desactive buttons/inputs/dropdows on the canvas forgot password Pop Up Change password.
    /// </summary>
    public void DesactivateObjectsPopUpChangePassword()
    {
        _btnBtnNewPasswordVisibilityPopUpChangePassword.interactable = false;
        _btnBtnConfirmPasswordVisibilityPopUpChangePassword.interactable = false;
        _btnBtnConfirmPopUpChangePassword.interactable = false;
        _btnBtnBackPopUpChangePassword.interactable = false;

        _inputInputNewPasswordPopUpChangePassword.interactable = false;
        _inputInputConfirmPasswordPopUpChangePassword.interactable = false;
    }
    /// <summary>
    /// This function is use to desactive buttons/inputs/dropdows on the canvas forgot password Pop Up Change password.
    /// </summary>
    public void DesactivateObjectsPopUpPasswordChange()
    {
        _btnBtnSignInPopUpChangePassword.interactable = false;
    }
    /// <summary>
    /// This function is use to desactive all buttons/inputs/dropdows on the canvas forgot password Pop Up Change password.
    /// </summary>
    public void DesactivateAllObjects()
    {
        DesactivateObjects();
        DesactivateObjectsPopUpVerification();
        DesactivateObjectsPopUpChangePassword();
        DesactivateObjectsPopUpPasswordChange();
    }
    /// <summary>
    /// This function is use to active buttons/inputs/dropdows on the canvas forgot password.
    /// </summary>
    public void ActivateObjects()
    {
        _btnBtnSendForgotPassword.interactable = true;
        _btnBtnBackForgotPassword.interactable = true;

        _inputInputEmailForgotPassword.interactable = true;
    }
    /// <summary>
    /// This function is use to active buttons/inputs/dropdows on the canvas forgot password Pop Up Change password.
    /// </summary>
    public void ActivateObjectsPopUpVerification()
    {
        _btnBtnVerifyPopUpVerification.interactable = true;
        _btnBtnBackPopUpVerification.interactable = true;

        _inputInputCodePopUpVerification.interactable = true;
    }
    /// <summary>
    /// This function is use to active buttons/inputs/dropdows on the canvas forgot password Pop Up Change password.
    /// </summary>
    public void ActivateObjectsPopUpChangePassword()
    {
        _btnBtnNewPasswordVisibilityPopUpChangePassword.interactable = true;
        _btnBtnConfirmPasswordVisibilityPopUpChangePassword.interactable = true;
        _btnBtnConfirmPopUpChangePassword.interactable = true;
        _btnBtnBackPopUpChangePassword.interactable = true;

        _inputInputNewPasswordPopUpChangePassword.interactable = true;
        _inputInputConfirmPasswordPopUpChangePassword.interactable = true;
    }
    /// <summary>
    /// This function is use to active buttons/inputs/dropdows on the canvas forgot password Pop Up Change password.
    /// </summary>
    public void ActivateObjectsPopUpPasswordChange()
    {
        _btnBtnSignInPopUpChangePassword.interactable = false;
    }
    /// <summary>
    /// This function is use to active all buttons/inputs/dropdows on the canvas forgot password.
    /// </summary>
    public void ActivateAllObjects()
    {
        ActivateObjects();
        ActivateObjectsPopUpVerification();
        ActivateObjectsPopUpChangePassword();
        ActivateObjectsPopUpPasswordChange();
    }
    #endregion
}
