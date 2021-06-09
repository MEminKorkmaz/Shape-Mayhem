using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public static int score;
    public Text scoreTxt;
    
    void Update()
    {
        scoreTxt.text = score.ToString();
    }
}
