using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
    bool opening = false;
    public AudioSource[] sounds;
    public AudioSource lockedSound;
    public AudioSource openedSound;

    private void Start()
    {
         sounds = GetComponents<AudioSource>();
         lockedSound = sounds[0];
         openedSound = sounds[1];
    }
    void Update() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (opening == true && transform.position.y<7.45f)
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        if (this.locked==false)
        {
            opening = true;
            openedSound.Play();
        }
        else
        {
             //(optionally) Else
            // Play a sound to indicate the door is locked
            lockedSound.Play();
            
        }

    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}

    

