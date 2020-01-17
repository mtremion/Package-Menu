using UnityEngine;

/// <summary>
/// This class contains function(s) to crypte datas in the database.
/// </summary>
public class DataBaseCryptage : MonoBehaviour
{
    #region Main Methods
    /// <summary>
    /// Cryptage by using MD5SUM's method.
    /// </summary>
    /// <param name="strToEncrypt">Text that we want to encrypte.</param>
    /// <returns>The encryptate text.</returns>
    public string Md5Sum(string strToEncrypt)
    {
        System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
        byte[] bytes = ue.GetBytes(strToEncrypt);

        // encrypt bytes
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);

        // Convert the encrypted bytes back to a string (base 16)
        string hashString = "";

        for (int i = 0; i < hashBytes.Length; i++)
        {
            hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
        }

        return hashString.PadLeft(32, '0');     
    }
    #endregion
}
