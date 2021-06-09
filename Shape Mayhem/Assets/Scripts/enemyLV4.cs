using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLV4 : MonoBehaviour
{

    public GameObject redEnemyParticlePrefab;
    public GameObject enemyLV4Prefab;
    public float speed;
    public float health;
    public Transform player;
    private Vector3 target;

    void Start()
    {
        player = GameObject.FindWithTag("player").transform;
    }


    void FixedUpdate(){
        move();
        healthChecker();
    }

    void Update()
    {
        if(!goMove) return;
        goMove = false;

        target.x = player.position.x;
        target.y = player.position.y;
        target.z = player.position.z;

        Invoke(nameof(goMoveFunc) , goMoveRate);
    }


    void move(){
        transform.position = Vector2.MoveTowards(transform.position , target , speed * Time.fixedDeltaTime);
    }

    private bool goMove = true;
    public float minMoveRate;
    public float maxMoveRate;
    private float goMoveRate;

    void goMoveFunc(){
        goMove = true;
        goMoveRate = Random.Range(minMoveRate , maxMoveRate);
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


    private int deathScore = 85;
    void healthChecker(){
        if(health <= 0){
            GameObject go = Instantiate(redEnemyParticlePrefab , transform.position , transform.rotation);
            Destroy(go , 1.5f);
            Instantiate(enemyLV4Prefab , transform.position + new Vector3(3f , 3f , 0f) , transform.rotation);
            Instantiate(enemyLV4Prefab , transform.position + new Vector3(-3f , -3f , 0f) , transform.rotation);
            
            Destroy(gameObject);

            scoreManager.score += deathScore;
            }
        }


}
