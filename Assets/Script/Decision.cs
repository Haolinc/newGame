using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decision : MonoBehaviour
{
    Text title, content, choice1;
    GameObject decisionTab;
    Values value;
    Sprite iconGreen, iconGrey;
    bool cheat = false;
    void Start()
    {
        value = GameObject.Find("ValueHolder").GetComponent<Values>();
        decisionTab = GameObject.Find("/Canvas/Buttons&Tabs/Decision_Tab");
        title = GameObject.Find("/Canvas/Buttons&Tabs/Decision_Tab/Title").GetComponent<Text>();
        content = GameObject.Find("/Canvas/Buttons&Tabs/Decision_Tab/Content").GetComponent<Text>();
        choice1 = GameObject.Find("/Canvas/Buttons&Tabs/Decision_Tab/OK/Text").GetComponent<Text>();
        iconGreen = Resources.Load<Sprite>("ScriptIcons/green");
        iconGrey = Resources.Load<Sprite>("ScriptIcons/grey");
    }

    public void CheatOpen()
    {
        Image c, c1, c2;
        c = GameObject.Find("/Canvas/Buttons&Tabs/Law_Tab/Cheat Decision/Script Icon").GetComponent<Image>();
        c1 = GameObject.Find("/Canvas/Buttons&Tabs/Law_Tab/DecisionButton/Script Icon").GetComponent<Image>();
        c2 = GameObject.Find("/Canvas/Buttons&Tabs/Law_Tab/DecisionButton (2)/Script Icon").GetComponent<Image>();
        c.sprite = iconGrey;
        c1.sprite = iconGreen;
        c2.sprite = iconGreen;
        cheat = true;

    }
    public void DecisionTest1()
    {
        if (cheat)
        {
            value.val["Authority"] += 10;

            decisionTab.SetActive(true);
            title.text = "增加皇帝权威";
            content.text = "\t皇帝权威增加了10";
            choice1.text = "好的";
        }
    }
    public void DecisionTest2()
    {
        if (cheat)
        {
            value.val["Authority"] -= 10;

            decisionTab.SetActive(true);
            title.text = "减少皇帝权威";
            content.text = "\t皇帝权威减少了10";
            choice1.text = "好的";
        }
    }

    void SetUpDecisionText()
    {

    }
}
