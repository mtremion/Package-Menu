using UnityEngine;
using TMPro;

/// <summary>
/// This class lead the design of the Menu.
/// </summary>
public class DesignMenuManager : MonoBehaviour
{
    #region SerializeField
    [Header("Sound")]
    [Tooltip("Background sound.")]
    [SerializeField] AudioClip sndBackground = null;
    [Tooltip("Mouse click button sound.")]
    [SerializeField] AudioClip sndMouseClickButton = null;
    [Tooltip("Switch sound.")]
    [SerializeField] AudioClip sndSwitch = null;
    [Header("Text")]
    [Tooltip("Font.")]
    [SerializeField] TMP_FontAsset font = null;
    [Tooltip("Text color.")]
    [SerializeField] Color colorText = Color.black;
    [Tooltip("Text link color.")]
    [SerializeField] Color colorTextLink = Color.black;
    [Tooltip("Text error message color.")]
    [SerializeField] Color colorTextErrorMessage = Color.red;
    [Tooltip("Text valid message color.")]
    [SerializeField] Color colorTextValidMessage = Color.green;
    [Tooltip("Text warning message color.")]
    [SerializeField] Color colorTextWarningMessage = Color.yellow;
    [Tooltip("Text placeholder input color.")]
    [SerializeField] Color colorTextPHInput = Color.black;
    [Header("Background")]
    [Tooltip("Sprite of background.")]
    [SerializeField] Sprite imgBackground = null;
    [Header("PopUp")]
    [Tooltip("Sprite of background.")]
    [SerializeField] Sprite imgPopUp = null;
    [Header("Buttons")]
    [Tooltip("Sprite of buttons.")]
    [SerializeField] Sprite imgButton = null;
    [Header("Button Mute")]
    [Tooltip("Sprite visible.")]
    [SerializeField] Sprite imgMute = null;
    [Tooltip("Sprite not visible.")]
    [SerializeField] Sprite imgNotMute = null;
    [Header("Button Visibility")]
    [Tooltip("Sprite visible.")]
    [SerializeField] Sprite imgVisible = null;
    [Tooltip("Sprite not visible.")]
    [SerializeField] Sprite imgNotVisible = null;
    [Header("Button '?'")]
    [Tooltip("Sprite '?'.")]
    [SerializeField] Sprite imgInterogation = null;
    [Header("Scrollview")]
    [Tooltip("Sprite Scrollview.")]
    [SerializeField] Sprite imgScrollview = null;
    [Tooltip("Sprite Scrollbar.")]
    [SerializeField] Sprite imgScrollbarScrollview = null;
    [Tooltip("Sprite Handle.")]
    [SerializeField] Sprite imgHandleScrollbarScrollview = null;
    [Header("Dropdown")]
    [Tooltip("Sprite dropdown.")]
    [SerializeField] Sprite imgDropdown = null;
    [Tooltip("Sprite arrow dropdown background.")]
    [SerializeField] Sprite imgArrowDropdown = null;
    [Tooltip("Sprite dropdown background.")]
    [SerializeField] Sprite imgBackgroundTemplateDropdown = null;
    [Tooltip("Sprite dropdown checkmark.")]
    [SerializeField] Sprite imgCheckmarkTemplateDropdown = null;
    [Tooltip("Sprite dropdown scrollbar.")]
    [SerializeField] Sprite imgScrollbarDropdown = null;
    [Tooltip("Sprite dropdown scrollbar.")]
    [SerializeField] Sprite imgHandleScrollbarDropdown = null;
    [Header("Input")]
    [Tooltip("Sprite input.")]
    [SerializeField] Sprite imgInput = null;
    [Tooltip("Color input base.")]
    [SerializeField] Color colorInputBase = Color.white;
    [Tooltip("Color input error.")]
    [SerializeField] Color colorInputError = Color.red;
    [Tooltip("Color input valid.")]
    [SerializeField] Color colorInputValid = Color.green;
    [Tooltip("Color input warning.")]
    [SerializeField] Color colorInputWarning = Color.yellow;
    #endregion

    #region Getters & Setters
    public AudioClip m_sndBackground { get { return sndBackground; } }
    public AudioClip m_sndMouseClickButton { get { return sndMouseClickButton; } }
    public AudioClip m_sndSwitch { get { return sndSwitch; } }

    public TMP_FontAsset m_font { get { return font; } }

    public Color m_colorText { get { return colorText; } }
    public Color m_colorTextLink { get { return colorTextLink; } }
    public Color m_colorTextErrorMessage { get { return colorTextErrorMessage; } }
    public Color m_colorTextPHInput { get { return colorTextPHInput; } }
    public Color m_colorInputBase { get { return colorInputBase; } }
    public Color m_colorInputError { get { return colorInputError; } }
    public Color m_colorInputValid { get { return colorInputValid; } }
    public Color m_colorInputWarning { get { return colorInputWarning; } }
    public Color m_colorTextValidMessage { get { return colorTextValidMessage; } }
    public Color m_colorTextWarningMessage { get { return colorTextWarningMessage; } }

    public Sprite m_imgBackground { get { return imgBackground; } }
    public Sprite m_imgButton { get { return imgButton; } }
    public Sprite m_imgMute { get { return imgMute; } }
    public Sprite m_imgNotMute { get { return imgNotMute; } }
    public Sprite m_imgVisible { get { return imgVisible; } }
    public Sprite m_imgNotVisible { get { return imgNotVisible; } }
    public Sprite m_imgInterogation { get { return imgInterogation; } }
    public Sprite m_imgScrollview { get { return imgScrollview; } }
    public Sprite m_imgScrollbarScrollview { get { return imgScrollbarScrollview; } }
    public Sprite m_imgHandleScrollbarScrollview { get { return imgHandleScrollbarScrollview; } }
    public Sprite m_imgPopUp { get { return imgPopUp; } }
    public Sprite m_imgDropdown { get { return imgDropdown; } }
    public Sprite m_imgArrowDropdown { get { return imgArrowDropdown; } }
    public Sprite m_imgBackgroundTemplateDropdown { get { return imgBackgroundTemplateDropdown; } }
    public Sprite m_imgCheckmarkTemplateDropdown { get { return imgCheckmarkTemplateDropdown; } }
    public Sprite m_imgScrollbarDropdown { get { return imgScrollbarDropdown; } }
    public Sprite m_imgHandleScrollbarDropdown { get { return imgHandleScrollbarDropdown; } }
    public Sprite m_imgInput{ get { return imgInput; } }
    #endregion
}
