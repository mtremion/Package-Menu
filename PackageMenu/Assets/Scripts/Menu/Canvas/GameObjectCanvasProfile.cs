using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Profile.
/// </summary>
[Serializable]
public class GameObjectCanvasProfile
{
    #region SerializeField
    [Header("Canvas Profile / Personnals Informations")]
    [Tooltip("Background of part Personals Informations.")]
    [SerializeField] GameObject goImgBackPersonnalsInformationsCanvasProfile = null;
    [Tooltip("Background of part text Personals Informations.")]
    [SerializeField] GameObject goImgBackTxtPersonnalsInformationsCanvasProfile = null;
    [Tooltip("Text Personals Informations.")]
    [SerializeField] GameObject goTxtPersonnalsInformationsCanvasProfile = null;
    [Tooltip("Text Pseudo.")]
    [SerializeField] GameObject goTxtPseudoCanvasProfile = null;
    [Tooltip("Text Last Name.")]
    [SerializeField] GameObject goTxtLastNameCanvasProfile = null;
    [Tooltip("Text First Name.")]
    [SerializeField] GameObject goTxtFirstNameCanvasProfile = null;
    [Tooltip("Text Email.")]
    [SerializeField] GameObject goTxtEmailCanvasProfile = null;
    [Tooltip("Imgage Profile.")]
    [SerializeField] GameObject goImgProfileCanvasProfile = null;
    [Tooltip("Button Change Profile.")]
    [SerializeField] GameObject goBtnChangeProfileCanvasProfile = null;
    [Tooltip("Text Button Change Profile.")]
    [SerializeField] GameObject goTxtBtnChangeProfileCanvasProfile = null;
    [Header("Canvas Profile / Change Password")]
    [Tooltip("Background of part Change Password.")]
    [SerializeField] GameObject goImgBackChangePasswordCanvasProfile = null;
    [Tooltip("Background of part text Change Password.")]
    [SerializeField] GameObject goImgBackTxtChangePasswordCanvasProfile = null;
    [Tooltip("Text Change Password.")]
    [SerializeField] GameObject goTxtChangePasswordCanvasProfile = null;
    [Tooltip("Input New Password.")]
    [SerializeField] GameObject goInputNewPasswordCanvasProfile = null;
    [Tooltip("Text Placeholder Input New Password.")]
    [SerializeField] GameObject goTxtPHInputNewPasswordCanvasProfile = null;
    [Tooltip("Text Input New Password.")]
    [SerializeField] GameObject goTxtInputNewPasswordCanvasProfile = null;
    [Tooltip("Button Visibility New Password.")]
    [SerializeField] GameObject goBtnVisibilityNewPasswordCanvasProfile = null;
    [Tooltip("Input Confirm Password.")]
    [SerializeField] GameObject goInputConfirmPasswordCanvasProfile = null;
    [Tooltip("Text Placeholder Input Confirm Password.")]
    [SerializeField] GameObject goTxtPHInputConfirmPasswordCanvasProfile = null;
    [Tooltip("Text Input Confirm Password.")]
    [SerializeField] GameObject goTxtInputConfirmPasswordCanvasProfile = null;
    [Tooltip("Button Visibility Confirm Password.")]
    [SerializeField] GameObject goBtnVisibilityConfirmPasswordCanvasProfile = null;
    [Tooltip("Text info Passwords.")]
    [SerializeField] GameObject goTxtInfoPasswordsCanvasProfile = null;
    [Tooltip("Button Change Password.")]
    [SerializeField] GameObject goBtnChangePasswordCanvasProfile = null;
    [Tooltip("Text Button Change Password.")]
    [SerializeField] GameObject goTxtBtnChangePasswordCanvasProfile = null;
    [Tooltip("PopUp Change Password.")]
    [SerializeField] GameObject goPopUpChangePasswordCanvasProfile = null;
    [Tooltip("Image PopUp Change Password.")]
    [SerializeField] GameObject goImgPopUpChangePasswordCanvasProfile = null;
    [Tooltip("Text PopUp Change Password.")]
    [SerializeField] GameObject goTxtPopUpChangePasswordCanvasProfile = null;
    [Tooltip("Button Ok PopUp Change Password.")]
    [SerializeField] GameObject goBtnOkPopUpChangePasswordCanvasProfile = null;
    [Tooltip("Text Button Ok PopUp Change Password.")]
    [SerializeField] GameObject goTxtBtnOkPopUpChangePasswordCanvasProfile = null;
    [Header("Canvas Profile / Delete Account")]
    [Tooltip("Background of part Delete Account.")]
    [SerializeField] GameObject goImgBackDeleteAccountCanvasProfile = null;
    [Tooltip("Background of part text Delete Account.")]
    [SerializeField] GameObject goImgBackTxtDeleteAccountCanvasProfile = null;
    [Tooltip("Text Delete Account.")]
    [SerializeField] GameObject goTxtDeleteAccountCanvasProfile = null;
    [Tooltip("Button Delete PopUp Change Password.")]
    [SerializeField] GameObject goBtnDeleteAccountCanvasProfile = null;
    [Tooltip("Text Button Ok PopUp Change Password.")]
    [SerializeField] GameObject goTxtBtnDeleteAccountPasswordCanvasProfile = null;
    [Tooltip("PopUp Delete Account.")]
    [SerializeField] GameObject goPopUpDeleteAccountCanvasProfile = null;
    [Tooltip("Image PopUp Delete Account.")]
    [SerializeField] GameObject goImgPopUpDeleteAccountCanvasProfile = null;
    [Tooltip("Text PopUp Delete Account.")]
    [SerializeField] GameObject goTxtPopUpDeleteAccountCanvasProfile = null;
    [Tooltip("Button Yes PopUp Delete Account.")]
    [SerializeField] GameObject goBtnYesPopUpDeleteAccountCanvasProfile = null;
    [Tooltip("Text Button Yes PopUp Delete Account.")]
    [SerializeField] GameObject goTxtBtnYesPopUpDeleteAccountCanvasProfile = null;
    [Tooltip("Button Cancel PopUp Delete Account.")]
    [SerializeField] GameObject goBtnCancelPopUpDeleteAccountCanvasProfile = null;
    [Tooltip("Text Button Cancel PopUp Delete Account.")]
    [SerializeField] GameObject goTxtBtnCancelPopUpDeleteAccountCanvasProfile = null;
    #endregion

    #region Getters & Setters
    public GameObject m_goPopUpChangePasswordCanvasProfile { get { return goPopUpChangePasswordCanvasProfile; } }
    public GameObject m_goPopUpDeleteAccountCanvasProfile { get { return goPopUpDeleteAccountCanvasProfile; } }

    public RectTransform m_transformImgBackPersonnalsInformationsCanvasProfile { get { return _transformImgBackPersonnalsInformationsCanvasProfile; } }
    public RectTransform m_transformImgBackTxtPersonnalsInformationsCanvasProfile { get { return _transformImgBackTxtPersonnalsInformationsCanvasProfile; } }
    public RectTransform m_transformTxtPersonnalsInformationsCanvasProfile { get { return _transformTxtPersonnalsInformationsCanvasProfile; } }
    public RectTransform m_transformTxtPseudoCanvasProfile { get { return _transformTxtPseudoCanvasProfile; } }
    public RectTransform m_transformTxtLastNameCanvasProfile { get { return _transformTxtLastNameCanvasProfile; } }
    public RectTransform m_transformTxtFirstNameCanvasProfile { get { return _transformTxtFirstNameCanvasProfile; } }
    public RectTransform m_transformTxtEmailCanvasProfile { get { return _transformTxtEmailCanvasProfile; } }
    public RectTransform m_transformImgProfileCanvasProfile { get { return _transformImgProfileCanvasProfile; } }
    public RectTransform m_transformBtnChangeProfileCanvasProfile { get { return _transformBtnChangeProfileCanvasProfile; } }
    public RectTransform m_transformImgBackChangePasswordCanvasProfile { get { return _transformImgBackChangePasswordCanvasProfile; } }
    public RectTransform m_transformImgBackTxtChangePasswordCanvasProfile { get { return _transformImgBackTxtChangePasswordCanvasProfile; } }
    public RectTransform m_transformTxtChangePasswordCanvasProfile { get { return _transformTxtChangePasswordCanvasProfile; } }
    public RectTransform m_transformInputNewPasswordCanvasProfile { get { return _transformInputNewPasswordCanvasProfile; } }
    public RectTransform m_transformBtnVisibilityNewPasswordCanvasProfile { get { return _transformBtnVisibilityNewPasswordCanvasProfile; } }
    public RectTransform m_transformInputConfirmPasswordCanvasProfile { get { return _transformInputConfirmPasswordCanvasProfile; } }
    public RectTransform m_transformBtnVisibilityConfirmPasswordCanvasProfile { get { return _transformBtnVisibilityConfirmPasswordCanvasProfile; } }
    public RectTransform m_transformTxtInfoPasswordsCanvasProfile { get { return _transformTxtInfoPasswordsCanvasProfile; } }
    public RectTransform m_transformBtnChangePasswordCanvasProfile { get { return _transformBtnChangePasswordCanvasProfile; } }
    public RectTransform m_transformImgPopUpChangePasswordCanvasProfile { get { return _transformImgPopUpChangePasswordCanvasProfile; } }
    public RectTransform m_transformTxtPopUpChangePasswordCanvasProfile { get { return _transformTxtPopUpChangePasswordCanvasProfile; } }
    public RectTransform m_transformBtnOkPopUpChangePasswordCanvasProfile { get { return _transformBtnOkPopUpChangePasswordCanvasProfile; } }
    public RectTransform m_transformImgBackDeleteAccountCanvasProfile { get { return _transformImgBackDeleteAccountCanvasProfile; } }
    public RectTransform m_transformImgBackTxtDeleteAccountCanvasProfile { get { return _transformImgBackTxtDeleteAccountCanvasProfile; } }
    public RectTransform m_transformTxtDeleteAccountCanvasProfile { get { return _transformTxtDeleteAccountCanvasProfile; } }
    public RectTransform m_transformBtnDeleteAccountCanvasProfile { get { return _transformBtnDeleteAccountCanvasProfile; } }
    public RectTransform m_transformImgPopUpDeleteAccountCanvasProfile { get { return _transformImgPopUpDeleteAccountCanvasProfile; } }
    public RectTransform m_transformTxtPopUpDeleteAccountCanvasProfile { get { return _transformTxtPopUpDeleteAccountCanvasProfile; } }
    public RectTransform m_transformBtnYesPopUpDeleteAccountCanvasProfile { get { return _transformBtnYesPopUpDeleteAccountCanvasProfile; } }
    public RectTransform m_transformBtnCancelPopUpDeleteAccountCanvasProfile { get { return _transformBtnCancelPopUpDeleteAccountCanvasProfile; } }

    public Image m_imgImgBackPersonnalsInformationsCanvasProfile { get { return _imgImgBackPersonnalsInformationsCanvasProfile; } }
    public Image m_imgImgBackTxtPersonnalsInformationsCanvasProfile { get { return _imgImgBackTxtPersonnalsInformationsCanvasProfile; } }
    public Image m_imgImgProfileCanvasProfile { get { return _imgImgProfileCanvasProfile; } }
    public Image m_imgBtnChangeProfileCanvasProfile { get { return _imgBtnChangeProfileCanvasProfile; } }
    public Image m_imgImgBackChangePasswordCanvasProfile { get { return _imgImgBackChangePasswordCanvasProfile; } }
    public Image m_imgImgBackTxtChangePasswordCanvasProfile { get { return _imgImgBackTxtChangePasswordCanvasProfile; } }
    public Image m_imgInputNewPasswordCanvasProfile { get { return _imgInputNewPasswordCanvasProfile; } }
    public Image m_imgBtnVisibilityNewPasswordCanvasProfile { get { return _imgBtnVisibilityNewPasswordCanvasProfile; } }
    public Image m_imgInputConfirmPasswordCanvasProfile { get { return _imgInputConfirmPasswordCanvasProfile; } }
    public Image m_imgBtnVisibilityConfirmPasswordCanvasProfile { get { return _imgBtnVisibilityConfirmPasswordCanvasProfile; } }
    public Image m_imgBtnChangePasswordCanvasProfile { get { return _imgBtnChangePasswordCanvasProfile; } }
    public Image m_imgImgPopUpChangePasswordCanvasProfile { get { return _imgImgPopUpChangePasswordCanvasProfile; } }
    public Image m_imgBtnOkPopUpChangePasswordCanvasProfile { get { return _imgBtnOkPopUpChangePasswordCanvasProfile; } }
    public Image m_imgImgBackDeleteAccountCanvasProfile { get { return _imgImgBackDeleteAccountCanvasProfile; } }
    public Image m_imgImgBackTxtDeleteAccountCanvasProfile { get { return _imgImgBackTxtDeleteAccountCanvasProfile; } }
    public Image m_imgBtnDeleteAccountCanvasProfile { get { return _imgBtnDeleteAccountCanvasProfile; } }
    public Image m_imgImgPopUpDeleteAccountCanvasProfile { get { return _imgImgPopUpDeleteAccountCanvasProfile; } }
    public Image m_imgBtnYesPopUpDeleteAccountCanvasProfile { get { return _imgBtnYesPopUpDeleteAccountCanvasProfile; } }
    public Image m_imgBtnCancelPopUpDeleteAccountCanvasProfile { get { return _imgBtnCancelPopUpDeleteAccountCanvasProfile; } }

    public TMP_InputField m_inputInputNewPasswordCanvasProfile { get { return _inputInputNewPasswordCanvasProfile; } }
    public TMP_InputField m_inputInputConfirmPasswordCanvasProfile { get { return _inputInputConfirmPasswordCanvasProfile; } }

    public TextMeshProUGUI m_tmpTxtPersonnalsInformationsCanvasProfile { get { return _tmpTxtPersonnalsInformationsCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtPseudoCanvasProfile { get { return _tmpTxtPseudoCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtLastNameCanvasProfile { get { return _tmpTxtLastNameCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtFirstNameCanvasProfile { get { return _tmpTxtFirstNameCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtEmailCanvasProfile { get { return _tmpTxtEmailCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtBtnChangeProfileCanvasProfile { get { return _tmpTxtBtnChangeProfileCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtChangePasswordCanvasProfile { get { return _tmpTxtChangePasswordCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtPHInputNewPasswordCanvasProfile { get { return _tmpTxtPHInputNewPasswordCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtInputNewPasswordCanvasProfile { get { return _tmpTxtInputNewPasswordCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtPHInputConfirmPasswordCanvasProfile { get { return _tmpTxtPHInputConfirmPasswordCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtInputConfirmPasswordCanvasProfile { get { return _tmpTxtInputConfirmPasswordCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtInfoPasswordsCanvasProfile { get { return _tmpTxtInfoPasswordsCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtBtnChangePasswordCanvasProfile { get { return _tmpTxtBtnChangePasswordCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtPopUpChangePasswordCanvasProfile { get { return _tmpTxtPopUpChangePasswordCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtBtnOkPopUpChangePasswordCanvasProfile { get { return _tmpTxtBtnOkPopUpChangePasswordCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtDeleteAccountCanvasProfile { get { return _tmpTxtDeleteAccountCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtBtnDeleteAccountPasswordCanvasProfile { get { return _tmpTxtBtnDeleteAccountPasswordCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtPopUpDeleteAccountCanvasProfile { get { return _tmpTxtPopUpDeleteAccountCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtBtnYesPopUpDeleteAccountCanvasProfile { get { return _tmpTxtBtnYesPopUpDeleteAccountCanvasProfile; } }
    public TextMeshProUGUI m_tmpTxtBtnCancelPopUpDeleteAccountCanvasProfile { get { return _tmpTxtBtnCancelPopUpDeleteAccountCanvasProfile; } }
    #endregion

    #region Private
    DataBaseManager _dbManager = null;
    RectTransform _transformImgBackPersonnalsInformationsCanvasProfile = null, _transformImgBackTxtPersonnalsInformationsCanvasProfile = null, _transformTxtPersonnalsInformationsCanvasProfile = null,
                _transformTxtPseudoCanvasProfile = null, _transformTxtLastNameCanvasProfile = null, _transformTxtFirstNameCanvasProfile = null,
                _transformTxtEmailCanvasProfile = null, _transformImgProfileCanvasProfile = null, _transformBtnChangeProfileCanvasProfile = null,
                _transformImgBackChangePasswordCanvasProfile = null, _transformImgBackTxtChangePasswordCanvasProfile = null, _transformTxtChangePasswordCanvasProfile = null,
                _transformInputNewPasswordCanvasProfile = null, _transformBtnVisibilityNewPasswordCanvasProfile = null, _transformInputConfirmPasswordCanvasProfile = null,
                _transformBtnVisibilityConfirmPasswordCanvasProfile = null, _transformTxtInfoPasswordsCanvasProfile = null, _transformBtnChangePasswordCanvasProfile = null,
                _transformImgPopUpChangePasswordCanvasProfile = null, _transformTxtPopUpChangePasswordCanvasProfile = null, _transformBtnOkPopUpChangePasswordCanvasProfile = null,
                _transformImgBackDeleteAccountCanvasProfile = null, _transformImgBackTxtDeleteAccountCanvasProfile = null, _transformTxtDeleteAccountCanvasProfile = null,
                _transformBtnDeleteAccountCanvasProfile = null, _transformImgPopUpDeleteAccountCanvasProfile = null, _transformTxtPopUpDeleteAccountCanvasProfile = null,
                _transformBtnYesPopUpDeleteAccountCanvasProfile = null, _transformBtnCancelPopUpDeleteAccountCanvasProfile = null;
    Image _imgImgBackPersonnalsInformationsCanvasProfile = null, _imgImgBackTxtPersonnalsInformationsCanvasProfile = null, _imgImgProfileCanvasProfile = null,
        _imgBtnChangeProfileCanvasProfile = null, _imgImgBackChangePasswordCanvasProfile = null, _imgImgBackTxtChangePasswordCanvasProfile = null,
        _imgInputNewPasswordCanvasProfile = null, _imgBtnVisibilityNewPasswordCanvasProfile = null, _imgInputConfirmPasswordCanvasProfile = null,
        _imgBtnVisibilityConfirmPasswordCanvasProfile = null, _imgBtnChangePasswordCanvasProfile = null, _imgImgPopUpChangePasswordCanvasProfile = null,
        _imgBtnOkPopUpChangePasswordCanvasProfile = null, _imgImgBackDeleteAccountCanvasProfile = null, _imgImgBackTxtDeleteAccountCanvasProfile = null,
        _imgBtnDeleteAccountCanvasProfile = null, _imgImgPopUpDeleteAccountCanvasProfile = null, _imgBtnYesPopUpDeleteAccountCanvasProfile = null,
        _imgBtnCancelPopUpDeleteAccountCanvasProfile = null;
    TMP_InputField _inputInputNewPasswordCanvasProfile = null, _inputInputConfirmPasswordCanvasProfile = null;
    TextMeshProUGUI _tmpTxtPersonnalsInformationsCanvasProfile = null, _tmpTxtPseudoCanvasProfile = null, _tmpTxtLastNameCanvasProfile = null,
                _tmpTxtFirstNameCanvasProfile = null, _tmpTxtEmailCanvasProfile = null, _tmpTxtBtnChangeProfileCanvasProfile = null,
                _tmpTxtChangePasswordCanvasProfile = null, _tmpTxtPHInputNewPasswordCanvasProfile = null, _tmpTxtInputNewPasswordCanvasProfile = null,
                _tmpTxtPHInputConfirmPasswordCanvasProfile = null, _tmpTxtInputConfirmPasswordCanvasProfile = null, _tmpTxtInfoPasswordsCanvasProfile = null,
                _tmpTxtBtnChangePasswordCanvasProfile = null, _tmpTxtPopUpChangePasswordCanvasProfile = null, _tmpTxtBtnOkPopUpChangePasswordCanvasProfile = null,
                _tmpTxtDeleteAccountCanvasProfile = null, _tmpTxtBtnDeleteAccountPasswordCanvasProfile = null, _tmpTxtPopUpDeleteAccountCanvasProfile = null,
                _tmpTxtBtnYesPopUpDeleteAccountCanvasProfile = null,_tmpTxtBtnCancelPopUpDeleteAccountCanvasProfile = null;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _transformImgBackPersonnalsInformationsCanvasProfile = goImgBackPersonnalsInformationsCanvasProfile.GetComponent<RectTransform>();
        _transformImgBackTxtPersonnalsInformationsCanvasProfile = goImgBackTxtPersonnalsInformationsCanvasProfile.GetComponent<RectTransform>();
        _transformTxtPersonnalsInformationsCanvasProfile = goTxtPersonnalsInformationsCanvasProfile.GetComponent<RectTransform>();
        _transformTxtPseudoCanvasProfile = goTxtPseudoCanvasProfile.GetComponent<RectTransform>();
        _transformTxtLastNameCanvasProfile = goTxtLastNameCanvasProfile.GetComponent<RectTransform>();
        _transformTxtFirstNameCanvasProfile = goTxtFirstNameCanvasProfile.GetComponent<RectTransform>();
        _transformTxtEmailCanvasProfile = goTxtEmailCanvasProfile.GetComponent<RectTransform>();
        _transformImgProfileCanvasProfile = goImgProfileCanvasProfile.GetComponent<RectTransform>();
        _transformBtnChangeProfileCanvasProfile = goBtnChangeProfileCanvasProfile.GetComponent<RectTransform>();
        _transformImgBackChangePasswordCanvasProfile = goImgBackChangePasswordCanvasProfile.GetComponent<RectTransform>();
        _transformImgBackTxtChangePasswordCanvasProfile = goImgBackTxtChangePasswordCanvasProfile.GetComponent<RectTransform>();
        _transformTxtChangePasswordCanvasProfile = goTxtChangePasswordCanvasProfile.GetComponent<RectTransform>();
        _transformInputNewPasswordCanvasProfile = goInputNewPasswordCanvasProfile.GetComponent<RectTransform>();
        _transformBtnVisibilityNewPasswordCanvasProfile = goBtnVisibilityNewPasswordCanvasProfile.GetComponent<RectTransform>();
        _transformInputConfirmPasswordCanvasProfile = goInputConfirmPasswordCanvasProfile.GetComponent<RectTransform>();
        _transformBtnVisibilityConfirmPasswordCanvasProfile = goBtnVisibilityConfirmPasswordCanvasProfile.GetComponent<RectTransform>();
        _transformTxtInfoPasswordsCanvasProfile = goTxtInfoPasswordsCanvasProfile.GetComponent<RectTransform>();
        _transformBtnChangePasswordCanvasProfile = goBtnChangePasswordCanvasProfile.GetComponent<RectTransform>();
        _transformImgPopUpChangePasswordCanvasProfile = goImgPopUpChangePasswordCanvasProfile.GetComponent<RectTransform>();
        _transformTxtPopUpChangePasswordCanvasProfile = goTxtPopUpChangePasswordCanvasProfile.GetComponent<RectTransform>();
        _transformBtnOkPopUpChangePasswordCanvasProfile = goBtnOkPopUpChangePasswordCanvasProfile.GetComponent<RectTransform>();
        _transformImgBackDeleteAccountCanvasProfile = goImgBackDeleteAccountCanvasProfile.GetComponent<RectTransform>();
        _transformImgBackTxtDeleteAccountCanvasProfile = goImgBackTxtDeleteAccountCanvasProfile.GetComponent<RectTransform>();
        _transformTxtDeleteAccountCanvasProfile = goTxtDeleteAccountCanvasProfile.GetComponent<RectTransform>();
        _transformBtnDeleteAccountCanvasProfile = goBtnDeleteAccountCanvasProfile.GetComponent<RectTransform>();
        _transformImgPopUpDeleteAccountCanvasProfile = goImgPopUpDeleteAccountCanvasProfile.GetComponent<RectTransform>();
        _transformTxtPopUpDeleteAccountCanvasProfile = goTxtPopUpDeleteAccountCanvasProfile.GetComponent<RectTransform>();
        _transformBtnYesPopUpDeleteAccountCanvasProfile = goBtnYesPopUpDeleteAccountCanvasProfile.GetComponent<RectTransform>();
        _transformBtnCancelPopUpDeleteAccountCanvasProfile = goBtnCancelPopUpDeleteAccountCanvasProfile.GetComponent<RectTransform>();

        _imgImgBackPersonnalsInformationsCanvasProfile = goImgBackPersonnalsInformationsCanvasProfile.GetComponent<Image>();
        _imgImgBackTxtPersonnalsInformationsCanvasProfile = goImgBackTxtPersonnalsInformationsCanvasProfile.GetComponent<Image>();
        _imgImgProfileCanvasProfile = goImgProfileCanvasProfile.GetComponent<Image>();
        _imgBtnChangeProfileCanvasProfile = goBtnChangeProfileCanvasProfile.GetComponent<Image>();
        _imgImgBackChangePasswordCanvasProfile = goImgBackChangePasswordCanvasProfile.GetComponent<Image>();
        _imgImgBackTxtChangePasswordCanvasProfile = goImgBackTxtChangePasswordCanvasProfile.GetComponent<Image>();
        _imgInputNewPasswordCanvasProfile = goInputNewPasswordCanvasProfile.GetComponent<Image>();
        _imgBtnVisibilityNewPasswordCanvasProfile = goBtnVisibilityNewPasswordCanvasProfile.GetComponent<Image>();
        _imgInputConfirmPasswordCanvasProfile = goInputConfirmPasswordCanvasProfile.GetComponent<Image>();
        _imgBtnVisibilityConfirmPasswordCanvasProfile = goBtnVisibilityConfirmPasswordCanvasProfile.GetComponent<Image>();
        _imgBtnChangePasswordCanvasProfile = goBtnChangePasswordCanvasProfile.GetComponent<Image>();
        _imgImgPopUpChangePasswordCanvasProfile = goImgPopUpChangePasswordCanvasProfile.GetComponent<Image>();
        _imgBtnOkPopUpChangePasswordCanvasProfile = goBtnOkPopUpChangePasswordCanvasProfile.GetComponent<Image>();
        _imgImgBackDeleteAccountCanvasProfile = goImgBackDeleteAccountCanvasProfile.GetComponent<Image>();
        _imgImgBackTxtDeleteAccountCanvasProfile = goImgBackTxtDeleteAccountCanvasProfile.GetComponent<Image>();
        _imgBtnDeleteAccountCanvasProfile = goBtnDeleteAccountCanvasProfile.GetComponent<Image>();
        _imgImgPopUpDeleteAccountCanvasProfile = goImgPopUpDeleteAccountCanvasProfile.GetComponent<Image>();
        _imgBtnYesPopUpDeleteAccountCanvasProfile = goBtnYesPopUpDeleteAccountCanvasProfile.GetComponent<Image>();
        _imgBtnCancelPopUpDeleteAccountCanvasProfile = goBtnCancelPopUpDeleteAccountCanvasProfile.GetComponent<Image>();

        _inputInputNewPasswordCanvasProfile = goInputNewPasswordCanvasProfile.GetComponent<TMP_InputField>();
        _inputInputConfirmPasswordCanvasProfile = goInputConfirmPasswordCanvasProfile.GetComponent<TMP_InputField>();

        _tmpTxtPersonnalsInformationsCanvasProfile = goTxtPersonnalsInformationsCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtPseudoCanvasProfile = goTxtPseudoCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtLastNameCanvasProfile = goTxtLastNameCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtFirstNameCanvasProfile = goTxtFirstNameCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtEmailCanvasProfile = goTxtEmailCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnChangeProfileCanvasProfile = goTxtBtnChangeProfileCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtChangePasswordCanvasProfile = goTxtChangePasswordCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputNewPasswordCanvasProfile = goTxtPHInputNewPasswordCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputNewPasswordCanvasProfile = goTxtInputNewPasswordCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtPHInputConfirmPasswordCanvasProfile = goTxtPHInputConfirmPasswordCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputConfirmPasswordCanvasProfile = goTxtInputConfirmPasswordCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoPasswordsCanvasProfile = goTxtInfoPasswordsCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnChangePasswordCanvasProfile = goTxtBtnChangePasswordCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtPopUpChangePasswordCanvasProfile = goTxtPopUpChangePasswordCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnOkPopUpChangePasswordCanvasProfile = goTxtBtnOkPopUpChangePasswordCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtDeleteAccountCanvasProfile = goTxtDeleteAccountCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnDeleteAccountPasswordCanvasProfile = goTxtBtnDeleteAccountPasswordCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtPopUpDeleteAccountCanvasProfile = goTxtPopUpDeleteAccountCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnYesPopUpDeleteAccountCanvasProfile = goTxtBtnYesPopUpDeleteAccountCanvasProfile.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnCancelPopUpDeleteAccountCanvasProfile = goTxtBtnCancelPopUpDeleteAccountCanvasProfile.GetComponent<TextMeshProUGUI>();

    }
    #endregion

    #region Main Methods
    public void ReinitializeAllProfile()
    {
        _tmpTxtInfoPasswordsCanvasProfile.text = _dbManager.m_message.BaseMessage();
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputNewPasswordCanvasProfile, Color.white);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputInputConfirmPasswordCanvasProfile, Color.white);
        _inputInputNewPasswordCanvasProfile.text = "";
        _inputInputConfirmPasswordCanvasProfile.text = "";
    }
    #endregion
}
