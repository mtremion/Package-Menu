using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas Manager.
/// </summary>
[Serializable]
public class LanguageCanvasManager
{
    #region SerializeField
    [Header("Canvas Manager.")]
    [Tooltip("Title of the Canvas Manager")]
    [SerializeField] protected string titleCanvasManager = "";
    [Tooltip("Text button Credit.")]
    [SerializeField] protected string txtBtnCredit = "";
    [Tooltip("Text Credits.")]
    [TextArea]
    [SerializeField] string txtCreditPopUpCredit = "";
    [Tooltip("Text button Close Pop Up Credit.")]
    [SerializeField] protected string txtBtnClosePopUpCredit = "";
    [Tooltip("Text button Quit.")]
    [SerializeField] protected string txtBtnQuit = "";
    [Tooltip("Text PopUp Quit.")]
    [SerializeField] protected string txtPopUpQuit = "";
    [Tooltip("Text button Yes PopUp Quit.")]
    [SerializeField] protected string txtBtnYesPopUpQuit = "";
    [Tooltip("Text button No PopUp Quit.")]
    [SerializeField] protected string txtBtnNoPopUpQuit = "";
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
    /// This function is use to Change the language of data(s) for the Canvas Manager.
    /// </summary>
    public void ChangeLanguage()
    {
        _goManager.m_goCanvasManager.m_tmpTxtTitleCanvasManager.text = titleCanvasManager;

        _goManager.m_goCanvasManager.m_tmpTxtPopUpCreditCanvasManager.text = txtCreditPopUpCredit;

        _goManager.m_goCanvasManager.m_tmpTxtBtnCreditCanvasManager.text = txtBtnCredit;
        _goManager.m_goCanvasManager.m_tmpTxtBtnClosePopUpCreditCanvasManager.text = txtBtnClosePopUpCredit;
        _goManager.m_goCanvasManager.m_tmpTxtBtnQuitCanvasManager.text = txtBtnQuit;
        _goManager.m_goCanvasManager.m_tmpTxtPopUpQuitCanvasManager.text = txtPopUpQuit;
        _goManager.m_goCanvasManager.m_tmpTxtBtnYesPopUpQuitCanvasManager.text = txtBtnYesPopUpQuit;
        _goManager.m_goCanvasManager.m_tmpTxtBtnNoPopUpQuitCanvasManager.text = txtBtnNoPopUpQuit;    
    }
    #endregion
}
