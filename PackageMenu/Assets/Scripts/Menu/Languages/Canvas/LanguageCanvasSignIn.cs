using UnityEngine;
using System;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas Sign In.
/// </summary>
[Serializable]
public class LanguageCanvasSignIn
{
    #region SerializeField
    [Header("Canvas Sign In.")]
    [Tooltip("Title of the canvas Sign In.")]
    [SerializeField] protected string txtTitleCanvasSignIn = "";
    [Tooltip("Default text in the input Pseudo.")]
    [SerializeField] protected string txtPHInputPseudoCanvasSignIn = "";
    [Tooltip("Default text in the input Password.")]
    [SerializeField] protected string txtPHInputPasswordCanvasSignIn = "";
    [Tooltip("Text of the button forgot password.")]
    [SerializeField] protected string txtForgotPasswordCanvasSignIn = "";
    [Tooltip("Text of the button new account.")]
    [SerializeField] protected string txtNewAccountCanvasSignIn = "";
    [Tooltip("Text of the button connection.")]
    [SerializeField] protected string txtConnectionCanvasSignIn = "";
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
    /// This function is use to Change the language of data(s) for the Canvas Sign In.
    /// </summary>
    public void ChangeLanguage()
    {
        _goManager.m_goCanvasSignIn.m_tmpTxtTitleCanvasSignIn.text = txtTitleCanvasSignIn;
        _goManager.m_goCanvasSignIn.m_tmpTxtPHInputPseudoCanvasSignIn.text = txtPHInputPseudoCanvasSignIn;
        _goManager.m_goCanvasSignIn.m_tmpTxtPHInputPasswordCanvasSignIn.text = txtPHInputPasswordCanvasSignIn;
        _goManager.m_goCanvasSignIn.m_tmpTxtBtnForgotPasswordCanvasSignIn.text = txtForgotPasswordCanvasSignIn;
        _goManager.m_goCanvasSignIn.m_tmpTxtBtnNewAccountCanvasSignIn.text = txtNewAccountCanvasSignIn;
        _goManager.m_goCanvasSignIn.m_tmpTxtBtnConnectionCanvasSignIn.text = txtConnectionCanvasSignIn;
    }
    #endregion
}
