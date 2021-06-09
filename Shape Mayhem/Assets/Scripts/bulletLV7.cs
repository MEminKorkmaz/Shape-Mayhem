using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletLV7 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    public static float damage = 2.4f;

    private int counter = 0;
    private int enemyCounter = 2;

    void Start(){
        Destroy(gameObject , 10f);
    }
    
    void FixedUpdate()
    {
        transform.position += transform.up * speed * Time.fixedDeltaTime;
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("enemy")){
            counter++;
            if(counter >= enemyCounter){
            Destroy(gameObject);
            }
        }
    }
}
