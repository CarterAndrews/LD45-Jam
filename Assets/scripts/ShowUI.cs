using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    public GameObject Main_Panel;
    public GameObject Build_Panel;
    public GameObject Room_Panel;
    public GameObject Recreation_Panel;
    public GameObject Food_Panel;
    public GameObject Stat_Panel;
    public GameObject Upgrade_Panel;
    public GameObject Upgrade_Room_Panel;

    private bool MP;
    private bool BP;
    private bool RP;
    private bool RecP;
    private bool FP;
    private bool SP;
    private bool UP;
    private bool URP;

    private void Awake()
    {
        Main_Panel = GameObject.Find("Starting Panel");
        Build_Panel = GameObject.Find("Build Panel");
        Room_Panel = GameObject.Find("Room Panel");
        Recreation_Panel = GameObject.Find("Recreation Panel");
        Food_Panel = GameObject.Find("Food Panel");
        Stat_Panel = GameObject.Find("Stat Panel");
        Upgrade_Panel = GameObject.Find("Upgrade Panel");
        Upgrade_Room_Panel = GameObject.Find("Upgrade Room Panel");

        Main_Panel.SetActive(true);
        MP = true;
        Build_Panel.SetActive(false);
        BP = false;
        Room_Panel.SetActive(false);
        RP = false;
        Food_Panel.SetActive(false);
        FP = false;
        Recreation_Panel.SetActive(false);
        RecP = false;
        Stat_Panel.SetActive(false);
        SP = false;
        Upgrade_Panel.SetActive(false);
        UP = false;
        Upgrade_Room_Panel.SetActive(false);
        URP = false;
    }

    public void ShowBuildPanel() {

        if(BP == false  )
        {
            Build_Panel.SetActive(true);
            BP = true;
        }
        else
        {
            Build_Panel.SetActive(false);
            BP = false;
        }

    }
    public void ShowRoomPanel()
    {
        if(RP == false)
        {
            Room_Panel.SetActive(true);
            RP = true;
        }
        else
        {
            Room_Panel.SetActive(false);
            RP = false;

        }
    }
    public void ShowRecreationPanel()
    {
        if (RecP == false)
        {
            Recreation_Panel.SetActive(true);
            RecP = true;
        }
        else
        {
            Recreation_Panel.SetActive(false);
            RecP = false;

        }
    }
    public void ShowFoodPanel()
    {
        if (FP == false)
        {
            Food_Panel.SetActive(true);
            FP = true;
        }
        else
        {
            Food_Panel.SetActive(false);
            FP = false;

        }
    }

    public void ShowStatPanel()
    {
        if(SP == false)
        {
            Stat_Panel.SetActive(true);
            SP = true;
        }
        else
        {
            Stat_Panel.SetActive(false);
            SP = false;
        }
    }

    public void ShowUpgradePanel()
    {
        if (UP == false)
        {
            Upgrade_Panel.SetActive(true);
            UP = true;
        }
        else
        {
            Upgrade_Panel.SetActive(false);
            UP = false;

        }
    }

    public void ShowUpgradeRoomPanel()
    {
        if (URP == false)
        {
            Upgrade_Room_Panel.SetActive(true);
            URP = true;
        }
        else
        {
            Upgrade_Room_Panel.SetActive(false);
            URP = false;

        }
    }


}
