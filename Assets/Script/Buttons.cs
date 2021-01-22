using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Buttons : MonoBehaviour
{
    public void closeAll()
    {
        GameObject law = GameObject.Find("/Canvas/Buttons&Tabs/Law_Tab");
        GameObject min = GameObject.Find("/Canvas/Buttons&Tabs/Minister_Tab");
        GameObject dip = GameObject.Find("/Canvas/Buttons&Tabs/Diplomacy_Tab");
        GameObject stat = GameObject.Find("/Canvas/Buttons&Tabs/Statistic_Tab");
        GameObject menu = GameObject.Find("/Canvas/Buttons&Tabs/Menu_Tab");
        GameObject pstatus = GameObject.Find("/Canvas/Buttons&Tabs/PlayerStatus_Tab");
        law.SetActive(false);
        min.SetActive(false);
        dip.SetActive(false);
        stat.SetActive(false);
        menu.SetActive(false);
        pstatus.SetActive(false);
        Time.timeScale = 1;
    }

    public void closeDecisionTab()
    {
        GameObject decisiontab = GameObject.Find("/Canvas/Buttons&Tabs/Decision_Tab");
        decisiontab.SetActive(false);
    }

    public void lawOpen()
    {
        GameObject law = GameObject.Find("/Canvas/Buttons&Tabs/Law_Tab");
        closeAll();
        law.SetActive(true);
    }
    public void minOpen()
    {
        GameObject min = GameObject.Find("/Canvas/Buttons&Tabs/Minister_Tab");
        closeAll();
        min.SetActive(true);
    }
    public void dipOpen()
    {
        GameObject dip = GameObject.Find("/Canvas/Buttons&Tabs/Diplomacy_Tab");
        closeAll();
        dip.SetActive(true);
    }
    public void statOpen()
    {
        GameObject stat = GameObject.Find("/Canvas/Buttons&Tabs/Statistic_Tab");
        closeAll();
        stat.SetActive(true);
    }
    public void menuOpen()
    {
        GameObject menu = GameObject.Find("/Canvas/Buttons&Tabs/Menu_Tab");
        closeAll();
        menu.SetActive(true);
        Time.timeScale = 0;
    }
    public void pstatusOpen()
    {
        GameObject pstatus = GameObject.Find("/Canvas/Buttons&Tabs/PlayerStatus_Tab");
        closeAll();
        pstatus.SetActive(true);
    }

    
}
