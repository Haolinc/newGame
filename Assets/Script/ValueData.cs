using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ValueData
{
    public Dictionary<string, int> val = new Dictionary<string, int>();

    public ValueData(Values value)
    {
        this.val = value.val;
    }
}
