using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Sign In.
/// </summary>
[Serializable]
public class GameObjectMenuCanvasSignIn
{
    #region SerializeField
    [Header("Canvas Sign In")]
    [Tooltip("GameObject Canvas Sign In.")]
    [SerializeField] GameObject goCanvasSignIn = null;
    [Header("Background")]
    [Tooltip("Background of the Canvas Sign In.")]
    [SerializeField] GameObject goBackgroundCanvasSignIn = null;
    [Header("Title")]
    [Tooltip("Title of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtTitleCanvasSignIn = null;
    [Header("Input Pseudo")]
    [Tooltip("Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goInputPseudoCanvasSignIn = null;
    [Tooltip("Placeholder Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtPHInputPseudoCanvasSignIn = null;
    [Tooltip("Text Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtInputPseudoCanvasSignIn = null;
    [Header("Input Password")]
    [Tooltip("Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goInputPasswordCanvasSignIn = null;
    [Tooltip("Placeholder Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtPHInputPasswordCanvasSignIn = null;
    [Tooltip("Text Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtInputPasswordCanvasSignIn = null;
    [Header("Info connection")]
    [Tooltip("Text Info connection of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtInfoConnectionCanvasSignIn = null;
    [Header("Forgot Password")]
    [Tooltip("Button Forgot Password of the Canvas Sign In.")]
    [SerializeField] GameObject goBtnForgotPasswordCanvasSignIn = null;
    [Tooltip("Text Button Forgot Password of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtBtnForgotPasswordCanvasSignIn = null;
    [Header("New Account")]
    [Tooltip("Button New Account of the Canvas Sign In.")]
    [SerializeField] GameObject goBtnNewAccountCanvasSignIn = null;
    [Tooltip("Text New Account Password of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtBtnNewAccountCanvasSignIn = null;
    [Header("Connection")]
    [Tooltip("Button Connection of the Canvas Sign In.")]
    [SerializeField] GameObject goBtnConnectionCanvasSignIn = null;
    [Tooltip("Text Button Connection of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtBtnConnectionCanvasSignIn = null;
    #endregion

    #region Getters & Setters
    public GameObject m_goCanvasSignIn { get { return goCanvasSignIn; } }

    public TextMeshProUGUI m_tmpTxtTitleCanvasSignIn { get { return _tmpTxtTitleCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtPHInputPseudoCanvasSignIn { get { return _tmpTxtPHInputPseudoCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtInputPseudoCanvasSignIn { get { return _tmpTxtInputPseudoCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtPHInputPasswordCanvasSignIn { get { return _tmpTxtPHInputPasswordCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtInputPasswordCanvasSignIn { get { return _tmpTxtInputPasswordCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtInfoConnectionCanvasSignIn { get { return _tmpTxtInfoConnectionCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtBtnForgotPasswordCanvasSignIn { get { return _tmpTxtBtnForgotPasswordCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtBtnNewAccountCanvasSignIn { get { return _tmpTxtBtnNewAccountCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtBtnConnectionCanvasSignIn { get { return _tmpTxtBtnConnectionCanvasSignIn; } }

    public Button m_btnBtnForgotPasswordCanvasSignIn { get { return _btnBtnForgotPasswordCanvasSignIn; } }
    public Button m_btnBtnNewAccountCanvasSignIn { get { return _btnBtnNewAccountCanvasSignIn; } }
    public Button m_btnBtnConnectionCanvasSignIn { get { return _btnBtnConnectionCanvasSignIn; } }

    public TMP_InputField m_inputInputPseudoCanvasSignIn { get { return _inputInputPseudoCanvasSignIn; } }
    public TMP_InputField m_inputInputPasswordCanvasSignIn { get { return _inputInputPasswordCanvasSignIn; } }

    public Image m_imgBackgroundCanvasSignIn { get { return _imgBackgroundCanvasSignIn; } }
    public Image m_imgInputPseudoCanvasSignIn { get { return _imgInputPseudoCanvasSignIn; } }
    public Image m_imgInputPasswordCanvasSignIn { get { return _imgInputPasswordCanvasSignIn; } }
    public Image m_imgBtnForgotPasswordCanvasSignIn { get { return _imgBtnForgotPasswordCanvasSignIn; } }
    public Image m_imgBtnNewAccountCanvasSignIn { get { return _imgBtnNewAccountCanvasSignIn; } }
    public Image m_imgBtnConnectionCanvasSignIn { get { return _imgBtnConnectionCanvasSignIn; } }


    #endregion

    #region private
    DataBaseManager _dbManager = null;
    DesignMenuManager _designMenuManager = null;
    TextMeshProUGUI _tmpTxtTitleCanvasSignIn = null, _tmpTxtPHInputPseudoCanvasSignIn = null, _tmpTxtInputPseudoCanvasSignIn = null,
                _tmpTxtPHInputPasswordCanvasSignIn = null, _tmpTxtInputPasswordCanvasSignIn = null, _tmpTxtInfoConnectionCanvasSignIn = null,
                _tmpTxtBtnForgotPasswordCanvasSignIn = null, _tmpTxtBtnNewAccountCanvasSignIn = null, _tmpTxtBtnConnectionCanvasSignIn = null;
    Button _btnBtnForgotPasswordCanvasSignIn = null, _btnBtnNewAccountCanvasSignIn = null, _btnBtnConnectionCanvasSignIn = null;
    TMP_InputField _inputInputPseudoCanvasSignIn = null, _inputInputPasswordCanvasSignIn = null;
    Image _imgBackgroundCanvasSignIn = null, _imgInputPseudoCanvasSignIn = null, _imgInputPasswordCanvasSignIn = null,
        _imgBtnForgotPasswordCanvasSignIn = null, _imgBtnNewAccountCanvasSignIn = null, _imgBtnConnectionCanvasSignIn = null;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();
        _designMenuManager = GameObject.Find("DesignMenuManager").GetComponent<DesignMenuManager>();

        _tmpTxtTitleCanvasSignIn = goTxtTitleCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputPseudoCanvasSignIn = goTxtPHInputPseudoCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputPseudoCanvasSignIn = goTxtInputPseudoCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputPasswordCanvasSignIn = goTxtPHInputPasswordCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputPasswordCanvasSignIn = goTxtInputPasswordCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoConnectionCanvasSignIn = goTxtInfoConnectionCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnForgotPasswordCanvasSignIn = goTxtBtnForgotPasswordCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnNewAccountCanvasSignIn = goTxtBtnNewAccountCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnConnectionCanvasSignIn = goTxtBtnConnectionCanvasSignIn.GetComponent<TextMeshProUGUI>();

        _btnBtnForgotPasswordCanvasSignIn = goBtnForgotPasswordCanvasSignIn.GetComponent<Button>();
        _btnBtnNewAccountCanvasSignIn = goBtnNewAccountCanvasSignIn.GetComponent<Button>();
        _btnBtnConnectionCanvasSignIn = goBtnConnectionCanvasSignIn.GetComponent<Button>();

        _inputInputPseudoCanvasSignIn = goInputPseudoCanvasSignIn.GetComponent<TMP_InputField>();
        _inputInputPasswordCanvasSignIn = goInputPasswordCanvasSignIn.GetComponent<TMP_InputField>();

        _imgBackgroundCanvasSignIn = goBackgroundCanvasSignIn.GetComponent<Image>();
        _imgInputPseudoCanvasSignIn = goInputPseudoCanvasSignIn.GetComponent<Image>();
        _imgInputPasswordCanvasSignIn = goInputPasswordCanvasSignIn.GetComponent<Image>();
        _imgBtnForgotPasswordCanvasSignIn = goBtnForgotPasswordCanvasSignIn.GetComponent<Image>();
        _imgBtnNewAccountCanvasSignIn = goBtnNewAccountCanvasSignIn.GetComponent<Image>();
        _imgBtnConnectionCanvasSignIn = goBtnConnectionCanvasSignIn.GetComponent<Image>();
    }
    #endregion

    #region Main Methods
    public void Init()
    {
        _tmpTxtTitleCanvasSignIn.font = _designMenuManager.m_font;
        _tmpTxtTitleCanvasSignIn.color = _designMenuManager.m_colorText;
        _tmpTxtPHInputPseudoCanvasSignIn.font = _designMenuManager.m_font;
        _tmpTxtPHInputPseudoCanvasSignIn.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputPseudoCanvasSignIn.font = _designMenuManager.m_font;
        _tmpTxtInputPseudoCanvasSignIn.color = _designMenuManager.m_colorText;
        _tmpTxtPHInputPasswordCanvasSignIn.font = _designMenuManager.m_font;
        _tmpTxtPHInputPasswordCanvasSignIn.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputPasswordCanvasSignIn.font = _designMenuManager.m_font;
        _tmpTxtInputPasswordCanvasSignIn.color = _designMenuManager.m_colorText;
        _tmpTxtInfoConnectionCanvasSignIn.font = _designMenuManager.m_font;
        _tmpTxtBtnForgotPasswordCanvasSignIn.font = _designMenuManager.m_font;
        _tmpTxtBtnForgotPasswordCanvasSignIn.color = _designMenuManager.m_colorTextLink;
        _tmpTxtBtnNewAccountCanvasSignIn.font = _designMenuManager.m_font;
        _tmpTxtBtnNewAccountCanvasSignIn.color = _designMenuManager.m_colorTextLink;
        _tmpTxtBtnConnectionCanvasSignIn.font = _designMenuManager.m_font;
        _tmpTxtBtnConnectionCanvasSignIn.color = _designMenuManager.m_colorText;

        _imgBackgroundCanvasSignIn.sprite = _designMenuManager.m_imgPopUp;
        _imgInputPseudoCanvasSignIn.sprite = _designMenuManager.m_imgInput;
        _imgInputPasswordCanvasSignIn.sprite = _designMenuManager.m_imgInput;
        _imgBtnForgotPasswordCanvasSignIn.enabled = false;
        _imgBtnNewAccountCanvasSignIn.enabled = false;
        _imgBtnConnectionCanvasSignIn.sprite = _designMenuManager.m_imgButton;

        ActivateObjects();
    }
    /// <summary>
    /// This function will reinitialize info text and input block Color for the Canvas Sign In.
    /// </summary>
    public void Reinitialize()
    {
        _tmpTxtInfoConnectionCanvasSignIn.text = _dbManager.m_message.BaseMessage();
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputPseudoCanvasSignIn, _designMenuManager.m_colorInputBase);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputPasswordCanvasSignIn, _designMenuManager.m_colorInputBase);
        _tmpTxtInputPseudoCanvasSignIn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInputPasswordCanvasSignIn.text = _dbManager.m_message.BaseMessage();

        ActivateObjects();
    }
    /// <summary>
    /// This function is use to desactive buttons/inputs/dropdows on the canvas sign in.
    /// </summary>
    public void DesactivateObjects()
    {
        _btnBtnForgotPasswordCanvasSignIn.interactable = false;
        _btnBtnNewAccountCanvasSignIn.interactable = false;
        _btnBtnConnectionCanvasSignIn.interactable = false;

        _inputInputPseudoCanvasSignIn.interactable = false;
        _inputInputPasswordCanvasSignIn.interactable = false;
    }
    /// <summary>
    /// This function is use to active buttons/inputs/dropdows on the canvas sign in.
    /// </summary>
    public void ActivateObjects()
    {
        _btnBtnForgotPasswordCanvasSignIn.interactable = true;
        _btnBtnNewAccountCanvasSignIn.interactable = true;
        _btnBtnConnectionCanvasSignIn.interactable = true;

        _inputInputPseudoCanvasSignIn.interactable = true;
        _inputInputPasswordCanvasSignIn.interactable = true;
    }
    #endregion
}
