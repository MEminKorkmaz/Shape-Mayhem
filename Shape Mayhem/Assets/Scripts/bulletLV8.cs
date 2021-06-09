using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletLV8 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    public static float damage = 3.5f;

    void Start(){
        Destroy(gameObject , 1.8f);
    }
    
    void FixedUpdate()
    {
        transform.position += transform.up * speed * Time.fixedDeltaTime;
        transform.Rotate(0f , 0f , speed * Time.fixedDeltaTime * 3);
    }
}
