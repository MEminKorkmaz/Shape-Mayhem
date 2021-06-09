using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public float rotatingSpeed;
    void FixedUpdate()
    {
        transform.Rotate(0f , 0f , rotatingSpeed * Time.fixedDeltaTime);
    }
}
