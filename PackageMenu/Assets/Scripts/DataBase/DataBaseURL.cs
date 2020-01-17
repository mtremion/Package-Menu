using UnityEngine;

public class DataBaseURL : MonoBehaviour
{
    #region SerialiazeField
    [Header("URL informations")]
    [Tooltip("Facebook")]
    [SerializeField] string urlFacebook = "";
    [Tooltip("Linkedin")]
    [SerializeField] string urlLinkedin = "";
    [Tooltip("DoYouBuzz")]
    [SerializeField] string urlDoYouBuzz = "";
    [Tooltip("GitHub")]
    [SerializeField] string urlGitHub = "";
    [Tooltip("Web Site")]
    [SerializeField] string urlWebSite = "";
    [Header("URL Project")]
    [Tooltip("url Projet1 : TicTacToe")]
    [SerializeField] string urlProjet1 = "";
    [Tooltip("url Projet2 : Labyrinthe")]
    [SerializeField] string urlProjet2 = "";
    [Tooltip("url Projet3 : Knightmare")]
    [SerializeField] string urlProjet3 = "";
    [Tooltip("url Projet4 : Save Kids !")]
    [SerializeField] string urlProjet4 = "";
    [Tooltip("url Projet5 : AI Zombie")]
    [SerializeField] string urlProjet5 = "";
    #endregion

    #region Main Methods
    public void OpenFacebook()
    {
        Application.OpenURL(urlFacebook);
    }
    public void OpenLinkedin()
    {
        Application.OpenURL(urlLinkedin);
    }
    public void OpenDoYouBuzz()
    {
        Application.OpenURL(urlDoYouBuzz);
    }
    public void OpenGitHub()
    {
        Application.OpenURL(urlGitHub);
    }
    public void OpenWebSite()
    {
        Application.OpenURL(urlWebSite);
    }
    public void DownloadProjet1()
    {
        Application.OpenURL(urlProjet1);
    }
    public void DownloadProjet2()
    {
        Application.OpenURL(urlProjet2);
    }
    public void DownloadProjet3()
    {
        Application.OpenURL(urlProjet3);
    }
    public void DownloadProjet4()
    {
        Application.OpenURL(urlProjet4);
    }
    public void DownloadProjet5()
    {
        Application.OpenURL(urlProjet5);
    }
    #endregion
}
