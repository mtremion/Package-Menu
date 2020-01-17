﻿using System;

/// <summary>
/// This class contains data(s) for the language Espanol. Herite from Language.
/// </summary>
[Serializable]
public class Spanish : Language
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
