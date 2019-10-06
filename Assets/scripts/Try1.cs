using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Try1 : MonoBehaviour
{
    public int moneycount = 0;
    public int buyingprice = 10;
    public Text nothingText;
    public Text moneyNowText;
    public Text Displaymoney;
    // Start is called before the first frame update
    void Start()
    {
        DisplayMoney();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayMoney(){
        Displaymoney.text = moneycount.ToString();
    }
    public void addMoney(int amount)
    {
        moneycount += amount;
        moneyNowText.text = "You now have" + moneycount.ToString();
        DisplayMoney();
    }
     public void OnMouseDown()
    {
        if (moneycount < buyingprice){

            nothingText.text = "You have NOTHING";

        }
        if(moneycount > buyingprice){
            moneycount = -buyingprice;
            moneyNowText.text = "You now have" + moneycount.ToString();
            DisplayMoney();
        }
    }
}
