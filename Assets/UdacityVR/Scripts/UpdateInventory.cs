using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInventory : MonoBehaviour {
    public Text CoinText;
    public Text KeyText;
    private int count;
    // Use this for initialization
    void Start () {
        count = 0;
        EditCoinText();
        EditKeyText("missing");
    }

    public void EditCoinText()
    {
       CoinText.text = "Collected Coin(s): 16/ " + count.ToString();
    }
    public void EditKeyText(string text)
    {
        KeyText.text = "Key: "+text;
    }
    public void Count()
    {
       count++;
    }
}
