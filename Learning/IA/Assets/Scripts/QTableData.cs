using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class QTableData
{
    public float[,] qTable;
    public float epsilon;

    public QTableData (float[,] _qTable, float _epsilon)
    {
        qTable = _qTable;
        epsilon = _epsilon;

    }

}
