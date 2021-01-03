using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Values : MonoBehaviour
{
    public Dictionary<string, int> val = new Dictionary<string, int>();

    void Start()
    {
        val.Add("Authority", 10);
    }
    
    void Update()
    {
        val["Authority"] += 1;
    }

    public void SaveValues()
    {
        print("Current Save Value "+ val["Authority"]);
        SaveScript.Save(this);
    }

    public void LoadValues()
    {
        
        ValueData valdata = SaveScript.Load();
        this.val = valdata.val;
        print("Current Load Value " + val["Authority"]);
    }

}
