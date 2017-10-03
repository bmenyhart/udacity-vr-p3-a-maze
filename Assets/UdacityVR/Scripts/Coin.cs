using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour 
{

    //Create a reference to the CoinPoofPrefab
    public GameObject CoinPoofPrefab;
    public GameObject InventoryPanel;


    public void OnCoinClicked() {

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

       InventoryPanel.GetComponent<UpdateInventory>().Count();
       InventoryPanel.GetComponent<UpdateInventory>().EditCoinText();

        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        GameObject CoinPoof = Object.Instantiate(CoinPoofPrefab, transform.position, Quaternion.Euler(-90f, 0f, 0f));
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject, audio.clip.length);
    }

   
  
}
