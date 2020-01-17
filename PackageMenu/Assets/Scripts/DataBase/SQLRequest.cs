using UnityEngine;


/// <summary>
/// Classe regroupant toutes les requêtes SQL utilisées.
/// </summary>
public class SQLRequest : MonoBehaviour {

    /// <summary>
    /// Création de table en BDD sans options (ex FK ...)
    /// </summary>
    /// <param name="tableName">Nom de la table que l'on souhaite créer.</param>
    /// <param name="tabColName">Tableau contenant les noms des colonnes de nos tables.</param>
    /// <param name="tabType">Tableau contenant les types des colonnes présentes dans tabColName. tabType[i] correspond à tabColName[i].</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string CreateSQL(string tableName, string[] tabColName, string[] tabType)
    {
        string cmd = "create table " + tableName + " (";
        for(int i = 0; i < tabColName.Length; i++)
        {
            cmd += tabColName[i] + " " + tabType[i];
            if (i <= tabColName.Length-1)
            {
                cmd += ", ";
            }
        }
        return cmd;
    }

    /// <summary>
    /// Création de table en BDD avec options (ex FK ...)
    /// </summary>
    /// <param name="tableName">Nom de la table que l'on souhaite créer.</param>
    /// <param name="tabColName">Tableau contenant les noms des colonnes de nos tables.</param>
    /// <param name="tabType">Tableau contenant les types des colonnes présents dans tabColName. tabType[i] correspond à tabColName[i].</param>
    /// <param name="tabOption">Tableau contenant les options que vous souhaitez ajouter à vos colonnes présentes dans tabColName. tabOption[i] correspond à tabColName[i].</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string CreateSQL(string tableName, string[] tabColName, string[] tabType, string[] tabOption)
    {
        string cmd = "create table " + tableName + " (";
        for (int i = 0; i < tabColName.Length; i++)
        {
            cmd += tabColName[i] + " " + tabType[i] + " " + tabOption[i];
            if (i <= tabColName.Length-1)
            {
                cmd += ", ";
            }
        }
        cmd += ")";
        return cmd;
    }

    /// <summary>
    /// Insertion d'éléments dans une table à partir d'une autre requête sans préciser les colonnes.
    /// </summary>
    /// <param name="tableName">Nom de la table où l'on souhaite insérer.</param>
    /// <param name="cmdInit">Requête SQL comme par exemple un select.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string InsertSQL(string tableName, string cmdInit)
    {
        string cmd = "insert into " + tableName + " values(" + cmdInit + ")";
        return cmd;
    }

    /// <summary>
    /// Insertion d'éléments dans une table à partir d'une autre requête en précisant les colonnes.
    /// </summary>
    /// <param name="tableName">Nom de la table où l'on souhaite insérer.</param>
    /// <param name="tabColName">Tableau contenant les noms des colonnes souhaitées.</param>
    /// <param name="cmdInit">Requête SQL comme par exemple un select.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string InsertSQL(string tableName, string[] tabColName, string cmdInit)
    {
        string cmd = "insert into " + tableName + " ";
        for (int i = 0; i < tabColName.Length; i++)
        {
            cmd += tabColName[i];
            if (i <= tabColName.Length - 1)
            {
                cmd += ", ";
            }
        }
        cmd += "values(" + cmdInit + ")";
        return cmd;
    }

    /// <summary>
    /// Insertion d'éléments dans une table à partir d'une autre requête retournant une valeur en précisant une colonne.
    /// </summary>
    /// <param name="tableName">Nom de la table où l'on souhaite insérer.</param>
    /// <param name="colName">Nom de la colonne souhaité</param>
    /// <param name="cmdInit">Requête SQL comme par exemple un select.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string InsertSQL(string tableName, string colName, string cmdInit)
    {
        string cmd = "insert into " + tableName + " ("+colName+") values('"+cmdInit+"')";
        return cmd;
    }

    /// <summary>
    /// Insertion d'éléments dans une table à partir de valeurs renseignées sans renseigner les colonnes.
    /// </summary>
    /// <param name="tableName">Nom de la table où l'on souhaite insérer.</param>
    /// <param name="tabValue">Tableau contenant les valeurs que l'on souhaite insérer.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string InsertSQL(string tableName, string[] tabValue)
    {
        string cmd = "insert into " + tableName + " values(";
        for (int i = 0; i < tabValue.Length; i++)
        {
            cmd += tabValue[i];
            if (i <= tabValue.Length-1)
            {
                cmd += ", ";
            }
        }
        cmd += ")";
        return cmd;
    }

    /// <summary>
    /// Insertion d'éléments dans une table à partir de valeurs renseignées en précisant les colonnes.
    /// </summary>
    /// <param name="tableName">Nom de la table où l'on souhaite insérer.</param>
    /// <param name="tabColName">Tableau contenant les noms des colonnes souhaitées.</param>
    /// <param name="tabValue">Tableau contenant les valeurs que l'on souhaite insérer.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string InsertSQL(string tableName, string[] tabColName, string[] tabValue)
    {
        string cmd = "insert into " + tableName + "(";
        for (int i = 0; i < tabColName.Length; i++)
        {
            cmd += tabColName[i];
            if (i <= tabValue.Length-1)
            {
                cmd += ", ";
            }
        }
        cmd += ") values (";
        for (int i = 0; i < tabColName.Length; i++)
        {
            cmd += tabValue[i];
            if (i <= tabValue.Length-1)
            {
                cmd += ", ";
            }
        }
        cmd += ")";
        return cmd;
    }

    /// <summary>
    /// Mise à jour d'une ou plusieurs ligne avec 1 condition.
    /// </summary>
    /// <param name="tableName">Nom de la table que l'on souhaite mettre à jour.</param>
    /// <param name="colName">Nom de la colonne souhaitée.</param>
    /// <param name="value">Valeur que l'on souhaite avoir.</param>
    /// <param name="operat">Operateur de comparaison, par ex : " = ".</param>
    /// <param name="wanted">La valeur de la que doit respecter la condition.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string UpdateSQL(string tableName, string colName, string value, string operat, string wanted)
    {
        string cmd = "update " + tableName + " set " + colName + " = " + value;
        cmd = WhereSQL(cmd, colName, operat, wanted);
        return cmd;
    }

    /// <summary>
    /// Mise à jour d'une ou plusieurs ligne avec plusieurs conditions.
    /// </summary>
    /// <param name="tableName">Nom de la table que l'on souhaite mettre à jour.</param>
    /// <param name="colName">Nom de la colonne souhaitée.</param>
    /// <param name="value">Valeur que l'on souhaite avoir.</param>
    /// <param name="operat">Operateur de comparaison, par ex : " = ".</param>
    /// <param name="wanted">La valeur que doit respecter la condition.</param>
    /// <param name="moreCondition">Permet d'ajouter des conditions. Correspond par exemple à "and", "or".</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string UpdateSQL(string tableName, string[] colName, string[] value, string[] operat, string[] wanted, string[] moreCondition)
    {
        string cmd = "update " + tableName + " set " + colName + " = " + value;
        cmd = WhereSQL(cmd, colName, operat, wanted, moreCondition);
        return cmd;
    }

    /// <summary>
    /// Suppression de toutes les lignes d'une table (truncate est conseillé pour ça).
    /// </summary>
    /// <param name="tableName">Nom de la table souhaitée.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string Delete(string tableName)
    {
        string cmd = "delete from " + tableName;
        return cmd;
    }

    /// <summary>
    /// Suppression d'une ou plusieurs ligne d'une table d'après 1 condition.
    /// </summary>
    /// <param name="tableName">Nom de la table souhaitée.</param>
    /// <param name="colName">Nom de la colonne souhaitée.</param>
    /// <param name="operat">Operateur de comparaison, par ex : " = ".</param>
    /// <param name="wanted">La valeur que doit respecter la condition.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string DeleteSQL(string tableName, string colName, string operat, string wanted)
    {
        string cmd = "delete from " + tableName;
        cmd = WhereSQL(cmd, colName, operat, wanted);
        return cmd;
    }

    /// <summary>
    /// Suppression d'une ou plusieurs ligne d'une table d'après plusieurs conditions.
    /// </summary>
    /// <param name="tableName">Nom de la table où l'on souhaite supprimer d'après plusieurs conditions.</param>
    /// <param name="tabColName">Tableau contenant le nom des colonnes souhaitées.</param>
    /// <param name="tabOperat">Tableau contenant les operateurs souhaitées.</param>
    /// <param name="tabWanted">Tableau contenant les valeurs que doivent respecter les conditions.</param>
    /// <param name="tabMoreCondition">Tableau contenant les liens entre les différentes conditions ex "and", "or".</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string DeleteSQL(string tableName, string[] tabColName, string[] tabOperat, string[] tabWanted, string[] tabMoreCondition)
    {
        string cmd = "delete from " + tableName;
        cmd = WhereSQL(cmd, tabColName, tabOperat, tabWanted, tabMoreCondition);
        return cmd;
    }

    /// <summary>
    /// Remonter un résultat d'une recherche d'une colonne dans une table.
    /// </summary>
    /// <param name="tableName">Nom de la table souhaitée.</param>
    /// <param name="colName">Nom de la colonne souhaitée.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string SelectSQL(string tableName, string colName)
    {
        string cmd = "select " + colName + " from " + tableName;
        return cmd;
    }

    /// <summary>
    /// Remonter un résultat d'une recherche de plusieurs colonne dans une table.
    /// </summary>
    /// <param name="tableName">Nom de la table où l'on souhaite remonter un résultat.</param>
    /// <param name="tabColName">Tableau contenant les noms des colonnes souhaitées.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string SelectSQL(string tableName, string[] tabColName)
    {
        string cmd = "select ";
        for(int i = 0; i < tabColName.Length; i++)
        {
            cmd += tabColName + " ";
        }
        cmd += "from " + tableName;
        return cmd;
    }

    /// <summary>
    /// Remonter toutes les lignes d'une table.
    /// </summary>
    /// <param name="tableName">Nom de la table où l'on souhaite remonter un résultat.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string SelectSQL(string tableName)
    {
        string cmd = "select * from " + tableName;
        return cmd;
    }

    /// <summary>
    /// Permet d'ajouter une condition.
    /// </summary>
    /// <param name="initCmd">String retourné par une autre fonction par exemple un "select".</param>
    /// <param name="colName">Nom de la colonne souhaitée.</param>
    /// <param name="operat">Operateur de comparaison, par ex : " = ".</param>
    /// <param name="wanted">Valeur que doit respecter la condition.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string WhereSQL(string initCmd, string colName, string operat, string wanted)
    {
        string cmd = initCmd + " where " + colName+ " " + operat + " " + wanted;
        return cmd;
    }

    /// <summary>
    /// Permet d'ajouter deux condition.
    /// </summary>
    /// <param name="initCmd">String retourné par une autre fonction par exemple un "select".</param>
    /// <param name="tabColName">Tableau contenant le nom des colonnes souhaitées.</param>
    /// <param name="tabOperat">Tableau contenant les operateurs de comparaison souhaités.</param>
    /// <param name="tabWanted">Tableau contenant les valeurs que doivent respecter les conditions.</param>
    /// <param name="tabMoreCondition">Lien entre les deux conditions.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string WhereSQL(string initCmd, string[] tabColName, string[] tabOperat, string[] tabWanted, string tabMoreCondition)
    {
        string cmd = initCmd + " where ";
        for (int i = 0; i < tabColName.Length; i++)
        {
            cmd += tabColName[i] + " " + tabOperat[i] + " " + tabWanted[i];
            if (i <= 0)
            {
                cmd += " " + tabMoreCondition[i] + " ";
            }
        }
        return cmd;
    }

    /// <summary>
    /// Permet d'ajouter plusieurs conditions.
    /// </summary>
    /// <param name="initCmd">String retourné par une autre fonction par exemple un "select".</param>
    /// <param name="tabColName">Tableau contenant le nom des colonnes souhaitées.</param>
    /// <param name="tabOperat">Tableau contenant les operateurs de comparaison souhaités.</param>
    /// <param name="tabWanted">Tableau contenant les valeurs que doivent respecter les conditions.</param>
    /// <param name="tabMoreCondition">Tableau contenant les liens entre les différentes conditions.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string WhereSQL(string initCmd, string[] tabColName, string[] tabOperat, string[] tabWanted, string[] tabMoreCondition)
    {
        string cmd = initCmd + " where ";
        for(int i = 0; i < tabColName.Length; i++)
        {
            cmd += tabColName[i] + " " + tabOperat[i] + " " + tabWanted[i];
            if (i <= tabMoreCondition.Length-1)
            {
                cmd += " " + tabMoreCondition[i] + " ";
            }
        }
        return cmd;
    }

    /// <summary>
    /// Suppression de toutes les lignes d'une table et réinitialisation des incréments automatiques.
    /// </summary>
    /// <param name="tableName">Nom de la table souhaitée.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string TruncateSQL(string tableName)
    {
        string cmd = "truncate table " + tableName;
        return cmd;
    }

    /// <summary>
    /// Suppression de la table.
    /// </summary>
    /// <param name="tableName">Nom de la table que l'on soit supprimer.</param>
    /// <returns>Une chaine de caractère correspondant à la requête SQL entière.</returns>
    public string DropSQL(string tableName)
    {
        string cmd = "drop table " + tableName;
        return cmd;
    }

}
