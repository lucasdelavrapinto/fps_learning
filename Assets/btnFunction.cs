using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public AudioSource mySounds;
    public AudioClip hoverSound;
    public AudioClip clickSound;
    
    public void HoverSound()
    {
    	mySounds.PlayOneShot(hoverSound);
    }
    
    public void ClickSound()
    {
    	mySounds.PlayOneShot(clickSound);
    }
}
