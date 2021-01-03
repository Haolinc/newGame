using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveScript
{
    public static void Save(Values val)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string savingPath = Application.persistentDataPath + "/save.txt";
        FileStream stream = new FileStream(savingPath, FileMode.Create);

        ValueData valdata = new ValueData(val);

        formatter.Serialize(stream, valdata);
        stream.Close();
    }
    public static ValueData Load()
    {
        string path = Application.persistentDataPath + "/save.txt";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        ValueData valdata = formatter.Deserialize(stream) as ValueData;

        stream.Close();
        return valdata;
    }
}
