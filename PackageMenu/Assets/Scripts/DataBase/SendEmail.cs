using System.Net;
using System.Net.Mail;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

/// <summary>
/// Class contains function(s) to send email(s).
/// </summary>
public class SendEmail : MonoBehaviour {

    #region SerializeField
    [Header("Sender's datas.")]
    [Tooltip("The smtpClient of the mail.")]
    [SerializeField] string smtpClient = null;
    [Header("Code.")]
    [Tooltip("The lenght of the code.")]
    [Range(2,10)]
    [SerializeField] int lenghtRandomCode = 0;
    #endregion

    #region Getters & Setters
    public string m_actualVerifyCode { get { return _actualVerifyCode; } }
    public string m_actualemailSent { get { return _actualemailSent; } }
    #endregion

    #region Private
    string _actualVerifyCode, _actualemailSent;
    DataBaseManager _dbManager = null;
    #endregion

    #region System
    private void Awake()
    {
        _dbManager = GetComponent<DataBaseManager>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// Generate a random code length X.
    /// </summary>
    /// <param name="length">Length of the code.</param>
    /// <returns>An integer with the lenght of the param.</returns>
    public void GenerateRandomCode(int length)
    {
        _actualVerifyCode = "";
        int randomCode;

        for(int i = 0; i < length; i++)
        {
            randomCode = Random.Range(0, 10);
            _actualVerifyCode += randomCode.ToString();
        }
    }
    /// <summary>
    /// Send a mail to an email.
    /// </summary>
    /// <param name="email">The destination mail.</param>
    /// <returns>An integer with the lenght of the param.</returns>
    public void ForgotPassword(string email)
    {
        _actualemailSent = email;

        GenerateRandomCode(lenghtRandomCode);

        Debug.Log(_actualVerifyCode);

        MailMessage mail = new MailMessage();

        mail.From = new MailAddress(email);
        mail.To.Add(email);
        mail.Subject = _dbManager.m_message.EmailCodeVerificationObjectPasswordForgot();
        mail.Body = _dbManager.m_message.EmailCodeVerificationBodyPasswordForgot() + " " + _actualVerifyCode + ".";

        SmtpClient smtpServer = new SmtpClient(smtpClient);
        smtpServer.Port = 587;
        smtpServer.Credentials = new NetworkCredential("PortFolioMaxT@gmail.com", "portfolio") as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        };
        smtpServer.Send(mail);
    }
    #endregion
}
