using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour
{
    Text title, content, choice1, choice2;
    GameObject eventTab;
    Values value;
    UnityEngine.UI.Button button1, button2;
    // Start is called before the first frame update
    void Start()
    {
        eventTab = GameObject.Find("/Canvas/Buttons&Tabs/Event_Tab");
        title = GameObject.Find("/Canvas/Buttons&Tabs/Event_Tab/Title").GetComponent<Text>();
        content = GameObject.Find("/Canvas/Buttons&Tabs/Event_Tab/Content").GetComponent<Text>();
        choice1 = GameObject.Find("/Canvas/Buttons&Tabs/Event_Tab/Choice1/Text").GetComponent<Text>();
        choice2 = GameObject.Find("/Canvas/Buttons&Tabs/Event_Tab/Choice2/Text").GetComponent<Text>();
        value = GameObject.Find("ValueHolder").GetComponent<Values>();
        button1 = GameObject.Find("/Canvas/Buttons&Tabs/Event_Tab/Choice1").GetComponent<UnityEngine.UI.Button>();
        button2 = GameObject.Find("/Canvas/Buttons&Tabs/Event_Tab/Choice2").GetComponent<UnityEngine.UI.Button>();
    }

    public void event1()
    {
        eventTab.SetActive(true);
        title.text = "测试";
        content.text = "\t测试测试测试";
        choice1.text = "增加权威10";
        choice2.text = "减少权威10";
        button1.onClick.AddListener(delegate { changeValues("Authority", 10, 1); });
        button2.onClick.AddListener(delegate { changeValues("Authority", 10, -1); });
    }

    void changeValues(string key, int v, int sign) //1 for inc, 0 for set value, -1 for dec
    {
        if (sign == 1)
            value.val[key] += v;
        else if (sign == 0)
            value.val[key] = v;
        else if (sign == -1)
            value.val[key] -= v;
        eventTab.SetActive(false);
    }

}
