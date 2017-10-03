using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    //Create a reference to the KeyPoofPrefab and Door

    public GameObject KeyPoofPrefab;
    public GameObject Door;
    public GameObject InventoryPanel;
    bool collected = false;
    public float hoverForce = 15;

    void Update()
    {
        //Not required, but for fun why not try adding a Key Floating Animation here :)

       // Key Floating Solution1:
       //transform.position = new Vector3(transform.position.x, 5 + Mathf.Sin(Time.time * 5.0f), transform.position.z);
    }

    private void OnTriggerStay(Collider other)
    {
        // Key Floating Solution2:
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }
    public void OnKeyClicked()
    {

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        GameObject KeyPoof = Object.Instantiate(KeyPoofPrefab, transform.position,Quaternion.Euler(-90f,0f,0f));
        // Call the Unlock() method on the Door
        Door door = Door.GetComponent<Door>();
        door.Unlock();
        // Set the Key Collected Variable to true
        collected = true;
        InventoryPanel.GetComponent<UpdateInventory>().EditKeyText("collected");
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject,audio.clip.length);
    }

}

