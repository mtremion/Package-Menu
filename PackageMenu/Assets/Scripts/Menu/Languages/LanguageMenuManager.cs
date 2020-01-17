using UnityEngine;

/// <summary>
/// This class contains data(s) lead all languages in the Menu.
/// </summary>
public class LanguageMenuManager : MonoBehaviour
{
    #region SerializeField
    [Header("Languages")]
    [Tooltip("English language.")]
    [SerializeField] English english = new English();
    [Tooltip("French language.")]
    [SerializeField] French french = new French();
    [Tooltip("French language.")]
    [SerializeField] Spanish spanish = new Spanish();
    #endregion

    #region Getters & Setters
    public English m_english { get { return english; } }
    public French m_french { get { return french; } }
    public Spanish m_spanish { get { return spanish; } }
    #endregion

    #region Private
    GameObjectMenuManager _goManager = null;
    #endregion

    #region System
    private void Awake()
    {
        _goManager = GameObject.Find("GameObjectMenuManager").GetComponent<GameObjectMenuManager>();

        english.Awake();
        french.Awake();
        spanish.Awake();
    }
    private void Start()
    {
        ChangeLanguage();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This fucntion will change language to the chosen one.
    /// </summary>
    public void ChangeLanguage()
    {
        switch (_goManager.m_goCanvasManager.m_dropdownDropdownLanguageCanvasManager.value)
        {
            case 0:
                english.ChangeLanguage();
                break;
            case 1:
                french.ChangeLanguage();
                break;
            case 2:
                spanish.ChangeLanguage();
                break;
            default:
                break;
        }
    }

    public void SetProfileCanvasProfile()
    {
       /* switch (_goManager.m_goCanvasManager.m_dropDownLanguageCanvasManager.value)
        {
            case 0:
                english.m_canvasProfile.SetProfile();
                break;
            case 1:
                french.m_canvasProfile.SetProfile();
                break;
            case 2:
                spanish.m_canvasProfile.SetProfile();
                break;
            default:
                break;
        }*/
    }
    #endregion
}
