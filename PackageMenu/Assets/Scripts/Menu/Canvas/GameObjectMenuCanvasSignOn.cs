using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Sign On.
/// </summary>
[Serializable]
public class GameObjectMenuCanvasSignOn
{
    #region SerializeField
    [Header("Canvas Sign On")]
    [Tooltip("GameObject Canvas Sign On.")]
    [SerializeField] GameObject goCanvasSignOn = null;
    [Header("Background")]
    [Tooltip("Background of the Canvas Sign On.")]
    [SerializeField] GameObject goBackgroundCanvasSignOn = null;
    [Header("Title")]
    [Tooltip("Title of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtTitleCanvasSignOn = null;
    [Header("Input Pseudo")]
    [Tooltip("Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goInputPseudoCanvasSignOn = null;
    [Tooltip("Placeholder Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtPHInputPseudoCanvasSignOn = null;
    [Tooltip("Text Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInputPseudoCanvasSignOn = null;
    [Header("Button Pseudo")]
    [Tooltip("Button pseudo exist of the Canvas Sign On.")]
    [SerializeField] GameObject goBtnPseudoExistCanvasSignOn = null;
    [Header("Info Pseudo")]
    [Tooltip("Text info pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInfoPseudoCanvasSignOn = null;
    [Header("Input Password")]
    [Tooltip("Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goInputPasswordCanvasSignOn = null;
    [Tooltip("Placeholder Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtPHInputPasswordCanvasSignOn = null;
    [Tooltip("Text Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInputPasswordCanvasSignOn = null;
    [Header("Button Password")]
    [Tooltip("Button password visible of the Canvas Sign On.")]
    [SerializeField] GameObject goBtnPasswordVisibleCanvasSignOn = null;
    [Header("Info Password")]
    [Tooltip("Text info password of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInfoPasswordCanvasSignOn = null;
    [Header("Input Email")]
    [Tooltip("Input email of the Canvas Sign On.")]
    [SerializeField] GameObject goInputEmailCanvasSignOn = null;
    [Tooltip("Placeholder Input email of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtPHInputEmailCanvasSignOn = null;
    [Tooltip("Text Input email of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInputEmailCanvasSignOn = null;
    [Header("Info Email")]
    [Tooltip("Text info email of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInfoEmailCanvasSignOn = null;
    [Header("Input First Name")]
    [Tooltip("Input First Name of the Canvas Sign On.")]
    [SerializeField] GameObject goInputFirstNameCanvasSignOn = null;
    [Tooltip("Placeholder Input First Name of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtPHInputFirstNameCanvasSignOn = null;
    [Tooltip("Text Input First Name of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInputFirstNameCanvasSignOn = null;
    [Header("Info First Name")]
    [Tooltip("Text info first name of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInfoFirstNameCanvasSignOn = null;
    [Header("Input Last Name")]
    [Tooltip("Input Last Name of the Canvas Sign On.")]
    [SerializeField] GameObject goInputLastNameCanvasSignOn = null;
    [Tooltip("Placeholder Input Last Name of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtPHInputLastNameCanvasSignOn = null;
    [Tooltip("Text Input Last Name of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInputLastNameCanvasSignOn = null;
    [Header("Info Last Name")]
    [Tooltip("Text info last name of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInfoLastNameCanvasSignOn = null;
    [Header("Register")]
    [Tooltip("Button Register of the Canvas Sign On.")]
    [SerializeField] GameObject goBtnRegisterCanvasSignOn = null;
    [Tooltip("Text Button Register of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtBtnRegisterCanvasSignOn = null;
    [Header("Back")]
    [Tooltip("Button Back of the Canvas Sign On.")]
    [SerializeField] GameObject goBtnBackCanvasSignOn = null;
    [Tooltip("Text Button Back of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtBtnBackCanvasSignOn = null;
    [Header("PopUp Register")]
    [Tooltip("PopUp Register of the Canvas Sign On.")]
    [SerializeField] GameObject goPopUpRegisterCanvasSignOn = null;
    [Tooltip("PopUp Register of the Canvas Sign On.")]
    [SerializeField] GameObject goImgPopUpRegisterCanvasSignOn = null;
    [Tooltip("Text PopUp Register of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtPopUpRegisterCanvasSignOn = null;
    [Tooltip("Button PopUp Register of the Canvas Sign On.")]
    [SerializeField] GameObject goBtnPopUpRegisterCanvasSignOn = null;
    [Tooltip("Button PopUp Register of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtBtnPopUpRegisterCanvasSignOn = null;
    #endregion

    #region Getters & Setters
    public GameObject m_goCanvasSignOn { get { return goCanvasSignOn; } }
    public GameObject m_goPopUpRegisterCanvasSignOn { get { return goPopUpRegisterCanvasSignOn; } }

    public TextMeshProUGUI m_tmpTxtTitleCanvasSignOn { get { return _tmpTxtTitleCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtPHInputPseudoCanvasSignOn { get { return _tmpTxtPHInputPseudoCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInputPseudoCanvasSignOn { get { return _tmpTxtInputPseudoCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInfoPseudoCanvasSignOn { get { return _tmpTxtInfoPseudoCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtPHInputPasswordCanvasSignOn { get { return _tmpTxtPHInputPasswordCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInputPasswordCanvasSignOn { get { return _tmpTxtInputPasswordCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInfoPasswordCanvasSignOn { get { return _tmpTxtInfoPasswordCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtPHInputEmailCanvasSignOn { get { return _tmpTxtPHInputEmailCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInputEmailCanvasSignOn { get { return _tmpTxtInputEmailCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInfoEmailCanvasSignOn { get { return _tmpTxtInfoEmailCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtPHInputFirstNameCanvasSignOn { get { return _tmpTxtPHInputFirstNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInputFirstNameCanvasSignOn { get { return _tmpTxtInputFirstNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInfoFirstNameCanvasSignOn { get { return _tmpTxtInfoFirstNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtPHInputLastNameCanvasSignOn { get { return _tmpTxtPHInputLastNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInputLastNameCanvasSignOn { get { return _tmpTxtInputLastNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInfoLastNameCanvasSignOn { get { return _tmpTxtInfoLastNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtBtnRegisterCanvasSignOn { get { return _tmpTxtBtnRegisterCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtBtnBackCanvasSignOn { get { return _tmpTxtBtnBackCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtPopUpRegisterCanvasSignOn { get { return _tmpTxtPopUpRegisterCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtBtnPopUpRegisterCanvasSignOn { get { return _tmpTxtBtnPopUpRegisterCanvasSignOn; } }

    public Button m_btnBtnPseudoExistCanvasSignOn { get { return _btnBtnPseudoExistCanvasSignOn; } }
    public Button m_btnBtnPasswordVisibleCanvasSignOn { get { return _btnBtnPasswordVisibleCanvasSignOn; } }
    public Button m_btnBtnRegisterCanvasSignOn { get { return _btnBtnRegisterCanvasSignOn; } }
    public Button m_btnBtnBackCanvasSignOn { get { return _btnBtnBackCanvasSignOn; } }
    public Button m_btnBtnPopUpRegisterCanvasSignOn { get { return _btnBtnPopUpRegisterCanvasSignOn; } }

    public TMP_InputField m_inputInputPseudoCanvasSignOn { get { return _inputInputPseudoCanvasSignOn; } }
    public TMP_InputField m_inputInputPasswordCanvasSignOn { get { return _inputInputPasswordCanvasSignOn; } }
    public TMP_InputField m_inputInputEmailCanvasSignOn { get { return _inputInputEmailCanvasSignOn; } }
    public TMP_InputField m_inputInputFirstNameCanvasSignOn { get { return _inputInputFirstNameCanvasSignOn; } }
    public TMP_InputField m_inputInputLastNameCanvasSignOn { get { return _inputInputLastNameCanvasSignOn; } }

    public Image m_imgBackgroundCanvasSignOn { get { return _imgBackgroundCanvasSignOn; } }
    public Image m_imgInputPseudoCanvasSignOn { get { return _imgInputPseudoCanvasSignOn; } }
    public Image m_imgBtnPseudoExistCanvasSignOn { get { return _imgBtnPseudoExistCanvasSignOn; } }
    public Image m_imgInputPasswordCanvasSignOn { get { return _imgInputPasswordCanvasSignOn; } }
    public Image m_imgBtnPasswordVisibleCanvasSignOn { get { return _imgBtnPasswordVisibleCanvasSignOn; } }
    public Image m_imgInputEmailCanvasSignOn { get { return _imgInputEmailCanvasSignOn; } }
    public Image m_imgInputFirstNameCanvasSignOn { get { return _imgInputFirstNameCanvasSignOn; } }
    public Image m_imgInputLastNameCanvasSignOn { get { return _imgInputLastNameCanvasSignOn; } }
    public Image m_imgBtnRegisterCanvasSignOn { get { return _imgBtnRegisterCanvasSignOn; } }
    public Image m_imgBtnBackCanvasSignOn { get { return _imgBtnBackCanvasSignOn; } }
    public Image m_imgImgPopUpRegisterCanvasSignOn { get { return _imgImgPopUpRegisterCanvasSignOn; } }
    public Image m_imgBtnPopUpRegisterCanvasSignOn { get { return _imgBtnPopUpRegisterCanvasSignOn; } }
    #endregion

    #region private
    DataBaseManager _dbManager = null;
    DesignMenuManager _designMenuManager = null;
    TextMeshProUGUI _tmpTxtTitleCanvasSignOn = null, _tmpTxtPHInputPseudoCanvasSignOn = null, _tmpTxtInputPseudoCanvasSignOn = null,
                _tmpTxtInfoPseudoCanvasSignOn = null, _tmpTxtPHInputPasswordCanvasSignOn = null, _tmpTxtInputPasswordCanvasSignOn = null,
                _tmpTxtInfoPasswordCanvasSignOn = null, _tmpTxtPHInputEmailCanvasSignOn = null, _tmpTxtInputEmailCanvasSignOn = null,
                _tmpTxtInfoEmailCanvasSignOn = null, _tmpTxtInputFirstNameCanvasSignOn = null, _tmpTxtPHInputFirstNameCanvasSignOn = null,
                _tmpTxtInfoFirstNameCanvasSignOn = null, _tmpTxtPHInputLastNameCanvasSignOn = null, _tmpTxtInputLastNameCanvasSignOn = null,
                _tmpTxtInfoLastNameCanvasSignOn = null, _tmpTxtBtnRegisterCanvasSignOn = null, _tmpTxtBtnBackCanvasSignOn = null,
                _tmpTxtPopUpRegisterCanvasSignOn = null, _tmpTxtBtnPopUpRegisterCanvasSignOn = null;
    Button _btnBtnPseudoExistCanvasSignOn = null, _btnBtnPasswordVisibleCanvasSignOn = null, _btnBtnRegisterCanvasSignOn = null,
        _btnBtnBackCanvasSignOn = null, _btnBtnPopUpRegisterCanvasSignOn = null;
    TMP_InputField _inputInputPseudoCanvasSignOn = null, _inputInputPasswordCanvasSignOn = null, _inputInputEmailCanvasSignOn = null,
                _inputInputFirstNameCanvasSignOn = null, _inputInputLastNameCanvasSignOn = null;
    Image _imgBackgroundCanvasSignOn = null, _imgInputPseudoCanvasSignOn = null, _imgBtnPseudoExistCanvasSignOn = null,
        _imgInputPasswordCanvasSignOn = null, _imgBtnPasswordVisibleCanvasSignOn = null, _imgInputEmailCanvasSignOn = null,
        _imgInputFirstNameCanvasSignOn = null, _imgInputLastNameCanvasSignOn = null, _imgBtnRegisterCanvasSignOn = null,
        _imgBtnBackCanvasSignOn = null, _imgImgPopUpRegisterCanvasSignOn = null, _imgBtnPopUpRegisterCanvasSignOn = null;
    bool _passwordVisible = false;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();
        _designMenuManager = GameObject.Find("DesignMenuManager").GetComponent<DesignMenuManager>();

        _tmpTxtTitleCanvasSignOn = goTxtTitleCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputPseudoCanvasSignOn = goTxtPHInputPseudoCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputPseudoCanvasSignOn = goTxtInputPseudoCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoPseudoCanvasSignOn = goTxtInfoPseudoCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputPasswordCanvasSignOn = goTxtPHInputPasswordCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputPasswordCanvasSignOn = goTxtInputPasswordCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoPasswordCanvasSignOn = goTxtInfoPasswordCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputEmailCanvasSignOn = goTxtPHInputEmailCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputEmailCanvasSignOn = goTxtInputEmailCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoEmailCanvasSignOn = goTxtInfoEmailCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputFirstNameCanvasSignOn = goTxtPHInputFirstNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputFirstNameCanvasSignOn = goTxtInputFirstNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoFirstNameCanvasSignOn = goTxtInfoFirstNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputLastNameCanvasSignOn = goTxtPHInputLastNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputLastNameCanvasSignOn = goTxtInputLastNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoLastNameCanvasSignOn = goTxtInfoLastNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnRegisterCanvasSignOn = goTxtBtnRegisterCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnBackCanvasSignOn = goTxtBtnBackCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtPopUpRegisterCanvasSignOn = goTxtPopUpRegisterCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnPopUpRegisterCanvasSignOn = goTxtBtnPopUpRegisterCanvasSignOn.GetComponent<TextMeshProUGUI>();

        _btnBtnPseudoExistCanvasSignOn = goBtnPseudoExistCanvasSignOn.GetComponent<Button>();
        _btnBtnPasswordVisibleCanvasSignOn = goBtnPasswordVisibleCanvasSignOn.GetComponent<Button>();
        _btnBtnRegisterCanvasSignOn = goBtnRegisterCanvasSignOn.GetComponent<Button>();
        _btnBtnBackCanvasSignOn = goBtnBackCanvasSignOn.GetComponent<Button>();
        _btnBtnPopUpRegisterCanvasSignOn = goBtnPopUpRegisterCanvasSignOn.GetComponent<Button>();

        _inputInputPseudoCanvasSignOn = goInputPseudoCanvasSignOn.GetComponent<TMP_InputField>();
        _inputInputPasswordCanvasSignOn = goInputPasswordCanvasSignOn.GetComponent<TMP_InputField>();
        _inputInputEmailCanvasSignOn = goInputEmailCanvasSignOn.GetComponent<TMP_InputField>();
        _inputInputFirstNameCanvasSignOn = goInputFirstNameCanvasSignOn.GetComponent<TMP_InputField>();
        _inputInputLastNameCanvasSignOn = goInputLastNameCanvasSignOn.GetComponent<TMP_InputField>();

        _imgBackgroundCanvasSignOn = goBackgroundCanvasSignOn.GetComponent<Image>();
        _imgInputPseudoCanvasSignOn = goInputPseudoCanvasSignOn.GetComponent<Image>();
        _imgBtnPseudoExistCanvasSignOn = goBtnPseudoExistCanvasSignOn.GetComponent<Image>();
        _imgInputPasswordCanvasSignOn = goInputPasswordCanvasSignOn.GetComponent<Image>();
        _imgBtnPasswordVisibleCanvasSignOn = goBtnPasswordVisibleCanvasSignOn.GetComponent<Image>();
        _imgInputEmailCanvasSignOn = goInputEmailCanvasSignOn.GetComponent<Image>();
        _imgInputFirstNameCanvasSignOn = goInputFirstNameCanvasSignOn.GetComponent<Image>();
        _imgInputLastNameCanvasSignOn = goInputLastNameCanvasSignOn.GetComponent<Image>();
        _imgBtnRegisterCanvasSignOn = goBtnRegisterCanvasSignOn.GetComponent<Image>();
        _imgBtnBackCanvasSignOn = goBtnBackCanvasSignOn.GetComponent<Image>();
        _imgImgPopUpRegisterCanvasSignOn = goImgPopUpRegisterCanvasSignOn.GetComponent<Image>();
        _imgBtnPopUpRegisterCanvasSignOn = goBtnPopUpRegisterCanvasSignOn.GetComponent<Image>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function will init object for the Canvas Sign On.
    /// </summary>
    public void Init()
    {
        _tmpTxtTitleCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtTitleCanvasSignOn.color = _designMenuManager.m_colorText;
        _tmpTxtPHInputPseudoCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtPHInputPseudoCanvasSignOn.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputPseudoCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtInputPseudoCanvasSignOn.color = _designMenuManager.m_colorText;
        _tmpTxtInfoPseudoCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtPHInputPasswordCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtPHInputPasswordCanvasSignOn.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputPasswordCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtInputPasswordCanvasSignOn.color = _designMenuManager.m_colorText;
        _tmpTxtInfoPasswordCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtPHInputEmailCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtPHInputEmailCanvasSignOn.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputEmailCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtInputEmailCanvasSignOn.color = _designMenuManager.m_colorText;
        _tmpTxtInfoEmailCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtPHInputFirstNameCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtPHInputFirstNameCanvasSignOn.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputFirstNameCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtInputFirstNameCanvasSignOn.color = _designMenuManager.m_colorText;
        _tmpTxtInfoFirstNameCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtPHInputLastNameCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtPHInputLastNameCanvasSignOn.color = _designMenuManager.m_colorTextPHInput;
        _tmpTxtInputLastNameCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtInputLastNameCanvasSignOn.color = _designMenuManager.m_colorText;
        _tmpTxtInfoLastNameCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtBtnRegisterCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtBtnRegisterCanvasSignOn.color = _designMenuManager.m_colorText;
        _tmpTxtBtnBackCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtBtnBackCanvasSignOn.color = _designMenuManager.m_colorText;
        _tmpTxtPopUpRegisterCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtPopUpRegisterCanvasSignOn.color = _designMenuManager.m_colorText;
        _tmpTxtBtnPopUpRegisterCanvasSignOn.font = _designMenuManager.m_font;
        _tmpTxtBtnPopUpRegisterCanvasSignOn.color = _designMenuManager.m_colorText;

        _imgBackgroundCanvasSignOn.sprite = _designMenuManager.m_imgPopUp;
        _imgInputPseudoCanvasSignOn.sprite = _designMenuManager.m_imgInput;
        _imgBtnPseudoExistCanvasSignOn.sprite = _designMenuManager.m_imgInterogation;
        _imgInputPasswordCanvasSignOn.sprite = _designMenuManager.m_imgInput;
        _imgBtnPasswordVisibleCanvasSignOn.sprite = _designMenuManager.m_imgNotVisible;
        _imgInputEmailCanvasSignOn.sprite = _designMenuManager.m_imgInput;
        _imgInputFirstNameCanvasSignOn.sprite = _designMenuManager.m_imgInput;
        _imgInputLastNameCanvasSignOn.sprite = _designMenuManager.m_imgInput;
        _imgBtnRegisterCanvasSignOn.sprite = _designMenuManager.m_imgButton;
        _imgBtnBackCanvasSignOn.sprite = _designMenuManager.m_imgButton;
        _imgImgPopUpRegisterCanvasSignOn.sprite = _designMenuManager.m_imgPopUp;
        _imgBtnPopUpRegisterCanvasSignOn.sprite = _designMenuManager.m_imgButton;

        _inputInputPasswordCanvasSignOn.contentType = TMP_InputField.ContentType.Password;

        ActivateAllObjects();
    }
    /// <summary>
    /// This function will reinitialize info text and input block Color for the Canvas Sign On.
    /// </summary>
    public void Reinitialize()
    {
        _tmpTxtInfoPseudoCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoPasswordCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoEmailCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoFirstNameCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoLastNameCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputPseudoCanvasSignOn, _designMenuManager.m_colorInputBase);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputPasswordCanvasSignOn, _designMenuManager.m_colorInputBase);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputEmailCanvasSignOn, _designMenuManager.m_colorInputBase);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputFirstNameCanvasSignOn, _designMenuManager.m_colorInputBase);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputLastNameCanvasSignOn, _designMenuManager.m_colorInputBase);
        _tmpTxtInputPseudoCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInputPasswordCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInputEmailCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInputFirstNameCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInputLastNameCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _imgBtnPasswordVisibleCanvasSignOn.sprite = _designMenuManager.m_imgNotVisible;
        _inputInputPasswordCanvasSignOn.contentType = TMP_InputField.ContentType.Password;
        _passwordVisible = false;

        ActivateAllObjects();
    }
    /// <summary>
    /// This function will change the visibility of the password.
    /// </summary>
    public void ChangePasswordVisibility()
    {
        _passwordVisible = !_passwordVisible;

        if(_passwordVisible)
        {
            _imgBtnPasswordVisibleCanvasSignOn.sprite = _designMenuManager.m_imgVisible;
            _inputInputPasswordCanvasSignOn.contentType = TMP_InputField.ContentType.Alphanumeric;
        }
        else
        {
            _imgBtnPasswordVisibleCanvasSignOn.sprite = _designMenuManager.m_imgNotVisible;
            _inputInputPasswordCanvasSignOn.contentType = TMP_InputField.ContentType.Password;
        }
    }
    /// <summary>
    /// This function is use to desactive buttons/inputs/dropdows on the canvas sign on.
    /// </summary>
    public void DesactivateObjects()
    {
        _btnBtnPseudoExistCanvasSignOn.interactable = false;
        _btnBtnPasswordVisibleCanvasSignOn.interactable = false;
        _btnBtnRegisterCanvasSignOn.interactable = false;
        _btnBtnBackCanvasSignOn.interactable = false;

        _inputInputPseudoCanvasSignOn.interactable = false;
        _inputInputPasswordCanvasSignOn.interactable = false;
        _inputInputEmailCanvasSignOn.interactable = false;
        _inputInputFirstNameCanvasSignOn.interactable = false;
        _inputInputLastNameCanvasSignOn.interactable = false;
    }
    /// <summary>
    /// This function is use to desactive buttons/inputs/dropdows on the canvas sign on PopUp Register.
    /// </summary>
    public void DesactivateObjectsPopUpRegister()
    {
        _btnBtnPopUpRegisterCanvasSignOn.interactable = false;
    }
    /// <summary>
    /// This function is use to desactive all buttons/inputs/dropdows on the canvas sign on PopUp Register.
    /// </summary>
    public void DesactivateAllObjects()
    {
        DesactivateObjects();
        DesactivateObjectsPopUpRegister();
    }
    /// <summary>
    /// This function is use to active buttons/inputs/dropdows on the canvas sign on.
    /// </summary>
    public void ActivateObjects()
    {
        _btnBtnPseudoExistCanvasSignOn.interactable = true;
        _btnBtnPasswordVisibleCanvasSignOn.interactable = true;
        _btnBtnRegisterCanvasSignOn.interactable = true;
        _btnBtnBackCanvasSignOn.interactable = true;

        _inputInputPseudoCanvasSignOn.interactable = true;
        _inputInputPasswordCanvasSignOn.interactable = true;
        _inputInputEmailCanvasSignOn.interactable = true;
        _inputInputFirstNameCanvasSignOn.interactable = true;
        _inputInputLastNameCanvasSignOn.interactable = true;
    }
    /// <summary>
    /// This function is use to active buttons/inputs/dropdows on the canvas sign on PopUp Register.
    /// </summary>
    public void ActivateObjectsPopUpRegister()
    {
        _btnBtnPopUpRegisterCanvasSignOn.interactable = true;
    }
    /// <summary>
    /// This function is use to active all buttons/inputs/dropdows on the canvas sign on PopUp Register.
    /// </summary>
    public void ActivateAllObjects()
    {
        ActivateObjects();
        ActivateObjectsPopUpRegister();
    }
    #endregion
}
