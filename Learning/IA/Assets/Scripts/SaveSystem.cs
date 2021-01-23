using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

    public static void SaveQTable(float[,] qTable, float epsilon)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.dataPath + "/qTableLearning.ZeroEngine";
        FileStream stream = new FileStream(path, FileMode.Create);

        Debug.Log("Saving into path" + path);
        QTableData data = new QTableData(qTable, epsilon);

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
            Debug.Log("Loading from path" + path);
            stream.Close();

            return data;

        }
        else {
            Debug.LogError("Save File not Found in" + path);
            return null;
        }
    }
}
   
