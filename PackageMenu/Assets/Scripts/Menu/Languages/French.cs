using System;

/// <summary>
/// This class contains data(s) for the language French. Herite from Language.
/// </summary>
[Serializable]
public class French : Language
{
    #region System
    public void Awake()
    {
        m_canvasManager.Awake();
        m_canvasSignIn.Awake();
        m_canvasSignOn.Awake();
        m_canvasForgotPassword.Awake();
    }
    #endregion
}

