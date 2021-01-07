using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decision : MonoBehaviour
{
    Values value;
    void Start()
    {
        value = GameObject.Find("ValueHolder").GetComponent<Values>();
    }
    public void DecisionTest1()
    {
        value.val["Authority"] += 10;
        print(value.val["Authority"]);
    }
    public void DecisionTest2()
    {
        value.val["Authority"] -= 10;
        print(value.val["Authority"]);
    }


}
