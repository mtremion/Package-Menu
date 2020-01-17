using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Manager.
/// </summary>
[Serializable]
public class GameObjectMenuCanvasManager
{
    #region SerializeField
    [Header("Canvas Manager")]
    [Tooltip("GameObject Canvas Manager")]
    [SerializeField] GameObject goCanvasManager = null;
    [Header("Background")]
    [Tooltip("Background of the Canvas Manager.")]
    [SerializeField] GameObject goBackgroundCanvasManager = null;
    [Header("Title")]
    [Tooltip("Title of the Canvas Manager.")]
    [SerializeField] GameObject goTxtTitleCanvasManager = null;
    [Header("Button Mute")]
    [Tooltip("Button mute of the Canvas Manager.")]
    [SerializeField] GameObject goBtnMuteCanvasManager = null;
    [Header("DropDown Language")]
    [Tooltip("DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goDropdownLanguageCanvasManager = null;
    [Tooltip("Label DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goTxtLabelDropDownLanguageCanvasManager = null;
    [Tooltip("Arrow DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goArrowDropDownLanguageCanvasManager = null;
    [Tooltip("Background Template DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goBackgroundTemplateDropDownLanguageCanvasManager = null;
    [Tooltip("CheckMark Template DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goCheckmarkTemplateDropDownLanguageCanvasManager = null;
    [Tooltip("Label Template DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goTxtLabelTemplateDropDownLanguageCanvasManager = null;
    [Tooltip("Scrollbar Template DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goScrollbarDropDownLanguageCanvasManager = null;
    [Tooltip("Handle scrollbar Template DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goHandleScrollbarDropDownLanguageCanvasManager = null;
    [Header("Button Credit")]
    [Tooltip("Button Credit.")]
    [SerializeField] GameObject goBtnCreditCanvasManager = null;
    [Tooltip("Text Button Credit.")]
    [SerializeField] GameObject goTxtBtnCreditCanvasManager = null;
    [Header("PopUp Credit")]
    [Tooltip("PopUp Credit.")]
    [SerializeField] GameObject goPopUpCreditCanvasManager = null;
    [Tooltip("Background PopUp Credit.")]
    [SerializeField] GameObject goBackgroundPopUpCreditCanvasManager = null;
    [Tooltip("Scrollview of Credit.")]
    [SerializeField] GameObject goScrollviewPopUpCreditCanvasManager = null;
    [Tooltip("Scrollbar vertical of Credit.")]
    [SerializeField] GameObject goScrollbarVerticalPopUpCreditCanvasManager = null;
    [Tooltip("Handle Scrollbar vertical of Credit.")]
    [SerializeField] GameObject goHandleSBVPopUpCreditCanvasManager = null;
    [Tooltip("Text of credits.")]
    [SerializeField] GameObject goTxtPopUpCreditCanvasManager = null;
    [Tooltip("Button Close.")]
    [SerializeField] GameObject goBtnClosePopUpCreditCanvasManager = null;
    [Tooltip("Text Button Close.")]
    [SerializeField] GameObject goTxtBtnClosePopUpCreditCanvasManager = null;
    [Header("Button Quit")]
    [Tooltip("Button Quit.")]
    [SerializeField] GameObject goBtnQuitCanvasManager = null;
    [Tooltip("Text Button Quit.")]
    [SerializeField] GameObject goTxtBtnQuitCanvasManager = null;
    [Header("Pop Up Quit")]
    [Tooltip("GameObject Pop up Quit.")]
    [SerializeField] GameObject goPopUpQuitCanvasManager = null;
    [Tooltip("Sprite Img back PopUp Quit.")]
    [SerializeField] GameObject goBackgroundPopUpQuitCanvasManager = null;
    [Tooltip("Text PopUp Quit.")]
    [SerializeField] GameObject goTxtPopUpQuitCanvasManager = null;
    [Tooltip("Button Yes PopUp Quit.")]
    [SerializeField] GameObject goBtnYesPopUpQuitCanvasManager = null;
    [Tooltip("Text Button Yes PopUp Quit.")]
    [SerializeField] GameObject goTxtBtnYesPopUpQuitCanvasManager = null;
    [Tooltip("Button Yes PopUp Quit.")]
    [SerializeField] GameObject goBtnNoPopUpQuitCanvasManager = null;
    [Tooltip("Text Button Yes PopUp Quit.")]
    [SerializeField] GameObject goTxtBtnNoPopUpQuitCanvasManager = null;
    #endregion

    #region Getters & Setters
    public GameObject m_goCanvasManager { get { return goCanvasManager; } }
    public GameObject m_goPopUpCreditCanvasManager { get { return goPopUpCreditCanvasManager; } }
    public GameObject m_goPopUpQuitCanvasManager { get { return goPopUpQuitCanvasManager; } }

    public TextMeshProUGUI m_tmpTxtTitleCanvasManager { get { return _tmpTxtTitleCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtLabelDropDownLanguageCanvasManager { get { return _tmpTxtLabelDropDownLanguageCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtLabelTemplateDropDownLanguageCanvasManager { get { return _tmpTxtLabelTemplateDropDownLanguageCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtBtnCreditCanvasManager { get { return _tmpTxtBtnCreditCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtPopUpCreditCanvasManager { get { return _tmpTxtPopUpCreditCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtBtnClosePopUpCreditCanvasManager { get { return _tmpTxtBtnClosePopUpCreditCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtBtnQuitCanvasManager { get { return _tmpTxtBtnQuitCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtPopUpQuitCanvasManager { get { return _tmpTxtPopUpQuitCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtBtnYesPopUpQuitCanvasManager { get { return _tmpTxtBtnYesPopUpQuitCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtBtnNoPopUpQuitCanvasManager { get { return _tmpTxtBtnNoPopUpQuitCanvasManager; } }

    public Button m_btnBtnMuteCanvasManager { get { return _btnBtnMuteCanvasManager; } }
    public Button m_btnBtnCreditCanvasManager { get { return _btnBtnCreditCanvasManager; } }
    public Button m_btnBtnClosePopUpCreditCanvasManager { get { return _btnBtnClosePopUpCreditCanvasManager; } }
    public Button m_btnBtnQuitCanvasManager { get { return _btnBtnQuitCanvasManager; } }
    public Button m_btnBtnYesPopUpQuitCanvasManager { get { return _btnBtnYesPopUpQuitCanvasManager; } }
    public Button m_btnBtnNoPopUpQuitCanvasManager { get { return _btnBtnNoPopUpQuitCanvasManager; } }

    public TMP_Dropdown m_dropdownDropdownLanguageCanvasManager { get { return _dropdownDropdownLanguageCanvasManager; } }

    public Image m_imgBackgroundCanvasManager { get { return _imgBackgroundCanvasManager; } }
    public Image m_imgBtnMuteCanvasManager { get { return _imgBtnMuteCanvasManager; } }
    public Image m_imgArrowDropDownLanguageCanvasManager { get { return _imgArrowDropDownLanguageCanvasManager; } }
    public Image m_imgBackgroundTemplateDropDownLanguageCanvasManager { get { return _imgBackgroundTemplateDropDownLanguageCanvasManager; } }
    public Image m_imgCheckmarkTemplateDropDownLanguageCanvasManager { get { return _imgCheckmarkTemplateDropDownLanguageCanvasManager; } }
    public Image m_imgBtnCreditCanvasManager { get { return _imgBtnCreditCanvasManager; } }
    public Image m_imgBackgroundImgPopUpCreditCanvasManager { get { return _imgBackgroundImgPopUpCreditCanvasManager; } }
    public Image m_imgScrollviewPopUpCreditCanvasManager { get { return _imgScrollviewPopUpCreditCanvasManager; } }
    public Image m_imgScrollbarVerticalPopUpCreditCanvasManager { get { return _imgScrollbarVerticalPopUpCreditCanvasManager; } }
    public Image m_imgHandleSBVPopUpCreditCanvasManager { get { return _imgHandleSBVPopUpCreditCanvasManager; } }
    public Image m_imgBtnClosePopUpCreditCanvasManager { get { return _imgBtnClosePopUpCreditCanvasManager; } }
    public Image m_imgBtnQuitCanvasManager { get { return _imgBtnQuitCanvasManager; } }
    public Image m_imgBackgroundImgPopUpQuitCanvasManager { get { return _imgBackgroundImgPopUpQuitCanvasManager; } }
    public Image m_imgBtnYesPopUpQuitCanvasManager { get { return _imgBtnYesPopUpQuitCanvasManager; } }
    public Image m_imgBtnNoPopUpQuitCanvasManager { get { return _imgBtnNoPopUpQuitCanvasManager; } }
    #endregion

    #region Private
    DesignMenuManager _designMenuManager = null;
    SoundManager _sndManager = null;
    TextMeshProUGUI _tmpTxtTitleCanvasManager = null, _tmpTxtLabelDropDownLanguageCanvasManager = null, _tmpTxtLabelTemplateDropDownLanguageCanvasManager = null,
                _tmpTxtBtnCreditCanvasManager = null, _tmpTxtPopUpCreditCanvasManager = null, _tmpTxtBtnClosePopUpCreditCanvasManager = null,
                _tmpTxtBtnQuitCanvasManager = null, _tmpTxtPopUpQuitCanvasManager = null, _tmpTxtBtnYesPopUpQuitCanvasManager = null,
                _tmpTxtBtnNoPopUpQuitCanvasManager = null;
    Button _btnBtnMuteCanvasManager = null, _btnBtnCreditCanvasManager = null, _btnBtnClosePopUpCreditCanvasManager = null,
        _btnBtnQuitCanvasManager = null, _btnBtnYesPopUpQuitCanvasManager = null, _btnBtnNoPopUpQuitCanvasManager = null;
    TMP_Dropdown _dropdownDropdownLanguageCanvasManager = null;
    Image _imgBackgroundCanvasManager = null, _imgBtnMuteCanvasManager = null, _imgArrowDropDownLanguageCanvasManager = null,
        _imgBackgroundTemplateDropDownLanguageCanvasManager = null, _imgCheckmarkTemplateDropDownLanguageCanvasManager = null, _imgScrollbarDropDownLanguageCanvasManager = null,
        _imgHandleScrollbarDropDownLanguageCanvasManager = null, _imgBtnCreditCanvasManager = null, _imgBackgroundImgPopUpCreditCanvasManager = null, 
        _imgScrollviewPopUpCreditCanvasManager = null, _imgScrollbarVerticalPopUpCreditCanvasManager = null, _imgHandleSBVPopUpCreditCanvasManager = null,
        _imgBtnClosePopUpCreditCanvasManager = null, _imgBtnQuitCanvasManager = null, _imgBackgroundImgPopUpQuitCanvasManager = null,
        _imgBtnYesPopUpQuitCanvasManager = null, _imgBtnNoPopUpQuitCanvasManager = null;
    #endregion

    #region System
    public void Awake()
    {
        _designMenuManager = GameObject.Find("DesignMenuManager").GetComponent<DesignMenuManager>();
        _sndManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        _tmpTxtTitleCanvasManager = goTxtTitleCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtLabelDropDownLanguageCanvasManager = goTxtLabelDropDownLanguageCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtLabelTemplateDropDownLanguageCanvasManager = goTxtLabelTemplateDropDownLanguageCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnCreditCanvasManager = goTxtBtnCreditCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtPopUpCreditCanvasManager = goTxtPopUpCreditCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnClosePopUpCreditCanvasManager = goTxtBtnClosePopUpCreditCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnQuitCanvasManager = goTxtBtnQuitCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtPopUpQuitCanvasManager = goTxtPopUpQuitCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnYesPopUpQuitCanvasManager = goTxtBtnYesPopUpQuitCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnNoPopUpQuitCanvasManager = goTxtBtnNoPopUpQuitCanvasManager.GetComponent<TextMeshProUGUI>();

        _btnBtnMuteCanvasManager = goBtnMuteCanvasManager.GetComponent<Button>();
        _btnBtnCreditCanvasManager = goBtnCreditCanvasManager.GetComponent<Button>();
        _btnBtnClosePopUpCreditCanvasManager = goBtnClosePopUpCreditCanvasManager.GetComponent<Button>();
        _btnBtnQuitCanvasManager = goBtnQuitCanvasManager.GetComponent<Button>();
        _btnBtnYesPopUpQuitCanvasManager = goBtnYesPopUpQuitCanvasManager.GetComponent<Button>();
        _btnBtnNoPopUpQuitCanvasManager = goBtnNoPopUpQuitCanvasManager.GetComponent<Button>();

        _dropdownDropdownLanguageCanvasManager = goDropdownLanguageCanvasManager.GetComponent<TMP_Dropdown>();

        _imgBackgroundCanvasManager = goBackgroundCanvasManager.GetComponent<Image>();
        _imgBtnMuteCanvasManager = goBtnMuteCanvasManager.GetComponent<Image>();
        _imgArrowDropDownLanguageCanvasManager = goArrowDropDownLanguageCanvasManager.GetComponent<Image>();
        _imgBackgroundTemplateDropDownLanguageCanvasManager = goBackgroundTemplateDropDownLanguageCanvasManager.GetComponent<Image>();
        _imgCheckmarkTemplateDropDownLanguageCanvasManager = goCheckmarkTemplateDropDownLanguageCanvasManager.GetComponent<Image>();
        _imgScrollbarDropDownLanguageCanvasManager = goScrollbarDropDownLanguageCanvasManager.GetComponent<Image>();
        _imgHandleScrollbarDropDownLanguageCanvasManager = goHandleScrollbarDropDownLanguageCanvasManager.GetComponent<Image>();
        _imgBtnCreditCanvasManager = goBtnCreditCanvasManager.GetComponent<Image>();
        _imgBackgroundImgPopUpCreditCanvasManager = goBackgroundPopUpCreditCanvasManager.GetComponent<Image>();
        _imgScrollviewPopUpCreditCanvasManager = goScrollviewPopUpCreditCanvasManager.GetComponent<Image>();
        _imgScrollbarVerticalPopUpCreditCanvasManager = goScrollbarVerticalPopUpCreditCanvasManager.GetComponent<Image>();
        _imgHandleSBVPopUpCreditCanvasManager = goHandleSBVPopUpCreditCanvasManager.GetComponent<Image>();
        _imgBtnClosePopUpCreditCanvasManager = goBtnClosePopUpCreditCanvasManager.GetComponent<Image>();
        _imgBtnQuitCanvasManager = goBtnQuitCanvasManager.GetComponent<Image>();
        _imgBackgroundImgPopUpQuitCanvasManager = goBackgroundPopUpQuitCanvasManager.GetComponent<Image>();
        _imgBtnYesPopUpQuitCanvasManager = goBtnYesPopUpQuitCanvasManager.GetComponent<Image>();
        _imgBtnNoPopUpQuitCanvasManager = goBtnNoPopUpQuitCanvasManager.GetComponent<Image>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function is use to initialize the canvas Manager.
    /// </summary>
    public void Init()
    {
        _tmpTxtTitleCanvasManager.font = _designMenuManager.m_font;
        _tmpTxtTitleCanvasManager.color = _designMenuManager.m_colorText;
        _tmpTxtLabelDropDownLanguageCanvasManager.font = _designMenuManager.m_font;
        _tmpTxtLabelDropDownLanguageCanvasManager.color = _designMenuManager.m_colorText;
        _tmpTxtLabelTemplateDropDownLanguageCanvasManager.font = _designMenuManager.m_font;
        _tmpTxtLabelTemplateDropDownLanguageCanvasManager.color = _designMenuManager.m_colorText;
        _tmpTxtBtnCreditCanvasManager.font = _designMenuManager.m_font;
        _tmpTxtBtnCreditCanvasManager.color = _designMenuManager.m_colorText;
        _tmpTxtPopUpCreditCanvasManager.font = _designMenuManager.m_font;
        _tmpTxtPopUpCreditCanvasManager.color = _designMenuManager.m_colorText;
        _tmpTxtBtnClosePopUpCreditCanvasManager.font = _designMenuManager.m_font;
        _tmpTxtBtnClosePopUpCreditCanvasManager.color = _designMenuManager.m_colorText;
        _tmpTxtBtnQuitCanvasManager.font = _designMenuManager.m_font;
        _tmpTxtBtnQuitCanvasManager.color = _designMenuManager.m_colorText;
        _tmpTxtPopUpQuitCanvasManager.font = _designMenuManager.m_font;
        _tmpTxtPopUpQuitCanvasManager.color = _designMenuManager.m_colorText;
        _tmpTxtBtnYesPopUpQuitCanvasManager.font = _designMenuManager.m_font;
        _tmpTxtBtnYesPopUpQuitCanvasManager.color = _designMenuManager.m_colorText;
        _tmpTxtBtnNoPopUpQuitCanvasManager.font = _designMenuManager.m_font;
        _tmpTxtBtnNoPopUpQuitCanvasManager.color = _designMenuManager.m_colorText;

        _imgBackgroundCanvasManager.sprite = _designMenuManager.m_imgBackground;

        if(_sndManager.m_mute)
        {
            _imgBtnMuteCanvasManager.sprite = _designMenuManager.m_imgMute;
        }
        else
        {
            _imgBtnMuteCanvasManager.sprite = _designMenuManager.m_imgNotMute;
            _sndManager.PlayBackgroundSnd();
        }    
        
        _imgArrowDropDownLanguageCanvasManager.sprite = _designMenuManager.m_imgArrowDropdown;
        _imgBackgroundTemplateDropDownLanguageCanvasManager.sprite = _designMenuManager.m_imgBackgroundTemplateDropdown;
        _imgCheckmarkTemplateDropDownLanguageCanvasManager.sprite = _designMenuManager.m_imgCheckmarkTemplateDropdown;
        _imgScrollbarDropDownLanguageCanvasManager.sprite = _designMenuManager.m_imgScrollbarDropdown;
        _imgHandleScrollbarDropDownLanguageCanvasManager.sprite = _designMenuManager.m_imgHandleScrollbarDropdown;
        _imgBtnCreditCanvasManager.sprite = _designMenuManager.m_imgButton;
        _imgBackgroundImgPopUpCreditCanvasManager.sprite = _designMenuManager.m_imgPopUp;
        _imgScrollviewPopUpCreditCanvasManager.sprite = _designMenuManager.m_imgScrollview;
        _imgScrollbarVerticalPopUpCreditCanvasManager.sprite = _designMenuManager.m_imgScrollbarScrollview;
        _imgHandleSBVPopUpCreditCanvasManager.sprite = _designMenuManager.m_imgHandleScrollbarScrollview;
        _imgBtnClosePopUpCreditCanvasManager.sprite = _designMenuManager.m_imgButton;
        _imgBtnQuitCanvasManager.sprite = _designMenuManager.m_imgButton;
        _imgBackgroundImgPopUpQuitCanvasManager.sprite = _designMenuManager.m_imgPopUp;
        _imgBtnYesPopUpQuitCanvasManager.sprite = _designMenuManager.m_imgButton;
        _imgBtnNoPopUpQuitCanvasManager.sprite = _designMenuManager.m_imgButton;

        ActivateObjects();
    }
    /// <summary>
    /// This function is use to mute/demute sound on the canvas Manager.
    /// </summary>
    public void ClickOnMute()
    {
        _sndManager.m_mute = !_sndManager.m_mute;

        if (_sndManager.m_mute)
        {
            _imgBtnMuteCanvasManager.sprite = _designMenuManager.m_imgMute;
            _sndManager.PlaySwitchSnd();
            _sndManager.StopBackgroundSnd();
        }
        else
        {
            _imgBtnMuteCanvasManager.sprite = _designMenuManager.m_imgNotMute;
            _sndManager.PlaySwitchSnd();
            _sndManager.PlayBackgroundSnd();
        }
    }
    /// <summary>
    /// This function is use to desactive buttons/inputs/dropdows on the canvas Manager.
    /// </summary>
    public void DesactivateObjects()
    {
        _btnBtnMuteCanvasManager.interactable = false;
        _btnBtnCreditCanvasManager.interactable = false;
        _btnBtnQuitCanvasManager.interactable = false;

        _dropdownDropdownLanguageCanvasManager.interactable = false;
    }
    /// <summary>
    /// This function is use to active buttons/inputs/dropdows on the canvas Manager.
    /// </summary>
    public void ActivateObjects()
    {
        _btnBtnMuteCanvasManager.interactable = true;
        _btnBtnCreditCanvasManager.interactable = true;
        _btnBtnQuitCanvasManager.interactable = true;

        _dropdownDropdownLanguageCanvasManager.interactable = true;
    }
    #endregion
}
