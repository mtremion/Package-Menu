using UnityEngine;
using TMPro;
using UnityEngine.UI;

/// <summary>
/// This class contains data(s) to lead GameObject of the Menu.
/// </summary>
public class GameObjectMenuManager : MonoBehaviour
{
    #region SerializeField
    [Header("Canvas Manager")]
    [Tooltip("Canvas Manager.")]
    [SerializeField] GameObjectMenuCanvasManager goCanvasManager = new GameObjectMenuCanvasManager();
    [Tooltip("Canvas Sign In.")]
    [SerializeField] GameObjectMenuCanvasSignIn goCanvasSignIn = new GameObjectMenuCanvasSignIn();
    [Tooltip("Canvas Sign On.")]
    [SerializeField] GameObjectMenuCanvasSignOn goCanvasSignOn = new GameObjectMenuCanvasSignOn();
    [Tooltip("Canvas Forgot Password.")]
    [SerializeField] GameObjectMenuCanvasForgotPassword goCanvasForgotPassword = new GameObjectMenuCanvasForgotPassword();
    #endregion

    #region Getters & Setters
    public GameObjectMenuCanvasManager m_goCanvasManager { get { return goCanvasManager; } }
    public GameObjectMenuCanvasSignIn m_goCanvasSignIn { get { return goCanvasSignIn; } }
    public GameObjectMenuCanvasSignOn m_goCanvasSignOn { get { return goCanvasSignOn; } }
    public GameObjectMenuCanvasForgotPassword m_goCanvasForgotPassword { get { return goCanvasForgotPassword; } }
    #endregion

    #region System
    private void Awake()
    {
        goCanvasManager.Awake();
        goCanvasSignIn.Awake();
        goCanvasSignOn.Awake();
        goCanvasForgotPassword.Awake();

        goCanvasManager.m_goCanvasManager.SetActive(true);
        goCanvasManager.m_goPopUpCreditCanvasManager.SetActive(false);
        goCanvasManager.m_goPopUpQuitCanvasManager.SetActive(false);
        goCanvasSignIn.m_goCanvasSignIn.SetActive(true);
        goCanvasSignOn.m_goCanvasSignOn.SetActive(false);
        goCanvasSignOn.m_goPopUpRegisterCanvasSignOn.SetActive(false);
        goCanvasForgotPassword.m_goCanvasForgotPassword.SetActive(false);
        goCanvasForgotPassword.m_goPopUpVerification.SetActive(false);
        goCanvasForgotPassword.m_goPopUpChangePassword.SetActive(false);
        goCanvasForgotPassword.m_goPopUpPasswordChange.SetActive(false);
    }
    private void Start()
    {
        goCanvasManager.Init();
        goCanvasSignIn.Init();
        goCanvasSignOn.Init();
        goCanvasForgotPassword.Init();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function will enable a gameobject.
    /// </summary>
    public void EnableGameObject(GameObject go)
    {
        go.SetActive(true);
    }
    /// <summary>
    /// This function will disable a gameobject.
    /// </summary>
    public void DisableGameObject(GameObject go)
    {
        go.SetActive(false);
    }
    /// <summary>
    /// This function will change the visibility of the password on Canvas Sign On.
    /// </summary>
    public void ChangePasswordVisibilityCanvasSignOn()
    {
        goCanvasSignOn.ChangePasswordVisibility();
    }
    /// <summary>
    /// This function will change the visibility of the new password on Canvas Forgot Password.
    /// </summary>
    public void ChangeNewPasswordVisibilityCanvasForgotPassword()
    {
        goCanvasForgotPassword.ChangeNewPasswordVisibility();
    }
    /// <summary>
    /// This function will change the visibility of the confirm password on Canvas Forgot Password.
    /// </summary>
    public void ChangeConfirmPasswordVisibilityCanvasForgotPassword()
    {
        goCanvasForgotPassword.ChangeConfirmPasswordVisibility();
    }
    /// <summary>
    /// This function will reinitialize All Canvas.
    /// </summary>
    public void ReinitializeAllCanvas()
    {
        goCanvasSignIn.Reinitialize();
        goCanvasSignOn.Reinitialize();
        goCanvasForgotPassword.Reinitialize();
    }
    /// <summary>
    /// This function will will desactivate all buttons/inputs/dropdown on the menu.
    /// </summary>
    public void DesactivateAllObjects()
    {
        goCanvasManager.DesactivateObjects();
        goCanvasSignIn.DesactivateObjects();
        goCanvasSignOn.DesactivateAllObjects();
        goCanvasForgotPassword.DesactivateAllObjects();
    }
    /// <summary>
    /// This function will will activate buttons/inputs/dropdown on the menu depend on the actual canvas.
    /// </summary>
    public void ActivateGoodObjects()
    {
        if (goCanvasSignIn.m_goCanvasSignIn.activeSelf)
        {
            goCanvasSignIn.ActivateObjects();
        }
        else if (goCanvasSignOn.m_goCanvasSignOn.activeSelf)
        {
            if (goCanvasSignOn.m_goPopUpRegisterCanvasSignOn.activeSelf)
            {
                goCanvasSignOn.ActivateObjectsPopUpRegister();
            }
            else
            {
                goCanvasSignOn.ActivateObjects();
            }
        }
        else if (goCanvasForgotPassword.m_goCanvasForgotPassword.activeSelf)
        {
            if (goCanvasForgotPassword.m_goPopUpVerification.activeSelf)
            {
                goCanvasForgotPassword.ActivateObjectsPopUpVerification();
            }
            else if (goCanvasForgotPassword.m_goPopUpChangePassword.activeSelf)
            {
                goCanvasForgotPassword.ActivateObjectsPopUpChangePassword();
            }
            else if (goCanvasForgotPassword.m_goPopUpPasswordChange.activeSelf)
            {
                goCanvasForgotPassword.ActivateObjectsPopUpPasswordChange();
            }
            else
            {
                goCanvasForgotPassword.ActivateObjects();
            }
        }
    }
    #endregion
}
