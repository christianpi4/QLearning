using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

    public static void SaveQTable(float[,] qTable)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.dataPath + "/qTableLearning.ZeroEngine";
        FileStream stream = new FileStream(path, FileMode.Create);

        QTableData data = new QTableData(qTable);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static QTableData LoadQtable()
    {
        string path = Application.dataPath + "/qTableLearning.ZeroEngine";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            QTableData data = formatter.Deserialize(stream) as QTableData;

            stream.Close();

            return data;

        }
        else {
            Debug.LogError("Save File not Found in" + path);
            return null;
        }
    }
}
   
