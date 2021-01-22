using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class QTableData
{
    public float[,] qTable;

    public QTableData (float[,] _qTable)
    {
        qTable = _qTable;
    }

}
