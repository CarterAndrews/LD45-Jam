using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    public GameObject Main_Panel;
    public GameObject Build_Panel;
    public GameObject Room_Panel;

    private bool MP;
    private bool BP;
    private bool RP;


    private void Awake()
    {
        Main_Panel = GameObject.Find("Starting Panel");
        Build_Panel = GameObject.Find("Build Panel");
        Room_Panel = GameObject.Find("Room Panel");

        Main_Panel.SetActive(true);
        MP = true;
        Build_Panel.SetActive(false);
        BP = false;
        Room_Panel.SetActive(false);
        RP = false;
    }

    public void ShowBuildPanel() {

        if(MP == true)
        {
            Main_Panel.SetActive(false);
            MP = false;
            Build_Panel.SetActive(true);
            BP = true;
        }
        else
        {
            Build_Panel.SetActive(false);
            BP = false;
            Main_Panel.SetActive(true);
            MP = true;
        }

    }
    public void ShowRoomPanel()
    {
        if(RP == false)
        {
            //Build_Panel.SetActive(false);
            //BP = false;
            Room_Panel.SetActive(true);
            RP = true;
        }
        else
        {
            //Build_Panel.SetActive(true);
            //BP = true;
            Room_Panel.SetActive(false);
            RP = false;

        }
    }



}
