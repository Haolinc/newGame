using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Values : MonoBehaviour
{
    public Dictionary<string, int> val = new Dictionary<string, int>();

    void Start()
    {
        val.Add("Authority", 10);
        val.Add("Health", 100);
        val.Add("TimeElapse", 0);
        val.Add("ActualTime", 1234);
    }

    void Update()
    {
        limitCondition();
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

    private void limitCondition()
    {
        if (val["Authority"] > 100)
        {
            val["Authority"] = 100;
        }
        if (val["Authority"] < 0)
        {
            val["Authority"] = 0;
        }
    }

}
