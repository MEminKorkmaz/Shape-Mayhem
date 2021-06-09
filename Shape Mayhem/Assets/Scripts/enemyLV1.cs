using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLV1 : MonoBehaviour
{
    
    public Transform player;
    public GameObject blueEnemyParticlePrefab;

    public float speed;
    public float health;


    void Start()
    {
        player = GameObject.FindWithTag("player").transform;
    }



    void FixedUpdate()
    {
        move();
        healthChecker();
    }

    void move(){
        transform.position = Vector2.MoveTowards(transform.position , player.position , speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("bulletLV1")){
            health -= bulletLV1.damage;
        }
        if(col.gameObject.CompareTag("bulletLV2")){
            health -= bulletLV2.damage;
        }
        if(col.gameObject.CompareTag("bulletLV3")){
            health -= bulletLV3.damage;
        }
        if(col.gameObject.CompareTag("bulletLV4")){
            health -= bulletLV4.damage;
        }
        if(col.gameObject.CompareTag("bulletLV5")){
            health -= bulletLV5.damage;
        }
        if(col.gameObject.CompareTag("bulletLV6")){
            health -= bulletLV6.damage;
        }
        if(col.gameObject.CompareTag("bulletLV7")){
            health -= bulletLV7.damage;
        }
        if(col.gameObject.CompareTag("bulletLV8")){
            health -= bulletLV8.damage;
        }
        if(col.gameObject.CompareTag("bulletLV9")){
            health -= bulletLV8.damage;
        }
    }

    private int deathScore = 15;
    void healthChecker(){
        if(health <= 0){
            GameObject go = Instantiate(blueEnemyParticlePrefab , transform.position , transform.rotation);
            Destroy(go , 1.5f);
            Destroy(gameObject);
            scoreManager.score += deathScore;
        }
    }
    
}
