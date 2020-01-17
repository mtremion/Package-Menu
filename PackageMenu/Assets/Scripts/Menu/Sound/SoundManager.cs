using UnityEngine;

/// <summary>
/// This class contains mains data(s) for the sound on the Menu.
/// </summary>
public class SoundManager : MonoBehaviour
{
    #region SerializeField
    [Header("Audio Source of the menu")]
    [Tooltip("Audio Source background.")]
    [SerializeField] AudioSource audioSourceBackground = null;
    [Tooltip("Audio Source click mouse button.")]
    [SerializeField] AudioSource audioSourceClickMouseButton = null;
    [Tooltip("Audio Source switch.")]
    [SerializeField] AudioSource audioSourceSwitch = null;
    #endregion

    #region Getters & Setters
    public bool m_mute { get { return _mute; } set { _mute = value; } }
    #endregion

    #region Private
    DesignMenuManager _designMenuManager = null;
    bool _mute = false;
    #endregion

    #region System
    public void Awake()
    {
        _designMenuManager = GameObject.Find("DesignMenuManager").GetComponent<DesignMenuManager>();

        audioSourceBackground.clip = _designMenuManager.m_sndBackground;
        audioSourceClickMouseButton.clip = _designMenuManager.m_sndMouseClickButton;
        audioSourceSwitch.clip = _designMenuManager.m_sndSwitch;
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function is use to start background music.
    /// </summary>
    public void PlayBackgroundSnd()
    {
        audioSourceBackground.Play();
    }
    /// <summary>
    /// This function is use to stop background music.
    /// </summary>
    public void StopBackgroundSnd()
    {
        audioSourceBackground.Stop();
    }
    /// <summary>
    /// This function is use to play sound mouse click button.
    /// </summary>
    public void PlayMouseClickButtonSnd()
    {
        if(!_mute)
        {
            audioSourceClickMouseButton.Play();
        }      
    }
    /// <summary>
    /// This function is use to play sound switch.
    /// </summary>
    public void PlaySwitchSnd()
    {
        if (!_mute)
        {
            audioSourceSwitch.Play();
        }      
    }
    #endregion
}
