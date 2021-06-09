using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    public static cameraShake sharedInstance;
    public Animator anim;
    
    void Awake(){
        sharedInstance = this;
    }
    public void shake(){
        anim.SetTrigger("shake");
    }
}
