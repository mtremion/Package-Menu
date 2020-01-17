using UnityEngine;
using System;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas Sign On.
/// </summary>
[Serializable]
public class LanguageCanvasSignOn
{
    #region SerializeField
    [Header("Canvas Sign On.")]
    [Tooltip("Title of the canvas Sign On.")]
    [SerializeField] protected string txtTitleCanvasSignOn = "";
    [Tooltip("Default text in the input Pseudo.")]
    [SerializeField] protected string txtPHInputPseudoCanvasSignOn = "";
    [Tooltip("Default text in the input Password.")]
    [SerializeField] protected string txtPHInputPasswordCanvasSignOn = "";
    [Tooltip("Default text in the input Email.")]
    [SerializeField] protected string txtPHInputEmailCanvasSignOn = "";
    [Tooltip("Default text in the input First Name.")]
    [SerializeField] protected string txtPHInputFirstNameCanvasSignOn = "";
    [Tooltip("Default text in the input Last Name.")]
    [SerializeField] protected string txtPHInputLastNameCanvasSignOn = "";
    [Tooltip("Text in the button Register.")]
    [SerializeField] protected string txtBtnRegisterCanvasSignOn = "";
    [Tooltip("Text in the button Back.")]
    [SerializeField] protected string txtBtnBackCanvasSignOn = "";
    [Tooltip("Text in the button Back.")]
    [SerializeField] protected string txtPopUpRegisterCanvasSignOn = "";
    [Tooltip("Text in the button Back.")]
    [SerializeField] protected string txtBtnPopUpRegisterCanvasSignOn = "";
    #endregion

    #region Private
    GameObjectMenuManager _goManager = null;
    #endregion

    #region System
    public void Awake()
    {
        _goManager = GameObject.Find("GameObjectMenuManager").GetComponent<GameObjectMenuManager>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function is use to Change the language of data(s) for the Canvas Sign On.
    /// </summary>
    public void ChangeLanguage()
    {
        _goManager.m_goCanvasSignOn.m_tmpTxtTitleCanvasSignOn.text = txtTitleCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtPHInputPseudoCanvasSignOn.text = txtPHInputPseudoCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtPHInputPasswordCanvasSignOn.text = txtPHInputPasswordCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtPHInputEmailCanvasSignOn.text = txtPHInputEmailCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtPHInputFirstNameCanvasSignOn.text = txtPHInputFirstNameCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtPHInputLastNameCanvasSignOn.text = txtPHInputLastNameCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtBtnRegisterCanvasSignOn.text = txtBtnRegisterCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtBtnBackCanvasSignOn.text = txtBtnBackCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtPopUpRegisterCanvasSignOn.text = txtPopUpRegisterCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtBtnPopUpRegisterCanvasSignOn.text = txtBtnPopUpRegisterCanvasSignOn;
    }
    #endregion
}
