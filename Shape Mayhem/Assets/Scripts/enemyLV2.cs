using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLV2 : MonoBehaviour
{

    public GameObject greenEnemyParticlePrefab;

    public float speed;
    public float health;

    Vector3 target;

    void Start()
    {
        target.x = Random.Range(-25f , 25f);
        target.y = Random.Range(-11f , 11f);
        target.z = 0f;
    }



    void FixedUpdate()
    {
        move();
        healthChecker();
    }

    void Update(){
        location();
    }



    void move(){
        transform.position = Vector2.MoveTowards(transform.position , target , speed * Time.fixedDeltaTime);
    }

    private float timer;
    private float changeTime;
    void location(){
        timer += Time.deltaTime;
        if(timer >= changeTime){
            target.x = Random.Range(-25f , 25f);
            target.y = Random.Range(-11f , 11f);
            timer = 0f;
            changeTime = Random.Range(1f , 4f);
        }
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

    private int deathScore = 35;
    void healthChecker(){
        if(health <= 0){
            GameObject go = Instantiate(greenEnemyParticlePrefab , transform.position , transform.rotation);
            Destroy(go , 1.5f);
            Destroy(gameObject);
            scoreManager.score += deathScore;
        }
    }
    
}
