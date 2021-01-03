using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayValues : MonoBehaviour
{
    Values value;
    Text authority;
    // Start is called before the first frame update
    void Start()
    {
        authority = GameObject.Find("/Canvas/Values/Authority").GetComponent<Text>();
        value = GameObject.Find("ValueHolder").GetComponent<Values>();
    }

    // Update is called once per frame
    void Update()
    {
        authority.text = "皇帝权威： " + value.val["Authority"].ToString();
    }
}
