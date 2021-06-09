using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject lv1EnemyPrefab;
    public GameObject lv2EnemyPrefab;
    public GameObject lv3EnemyPrefab;
    public GameObject lv4EnemyPrefab;

    public float lv1EnemyOdds;
    public float lv2EnemyOdds;
    public float lv3EnemyOdds;
    public float lv4EnemyOdds;

    public Transform[] spawnPositions;


    void Update()
    {
        if(playerAttack.isDead) return;
        spawner();
        spawnDecrease();
    }

    void spawner(){
        if(!goSpawn) return;
        goSpawn = false;

        int x = Random.Range(0 , 100);
        int y = Random.Range(0 , 4);

        if(x < lv1EnemyOdds){
            Instantiate(lv1EnemyPrefab , spawnPositions[y].position , Quaternion.identity);
        }

        else if(lv1EnemyOdds <= x && x < lv1EnemyOdds + lv2EnemyOdds){
            Instantiate(lv2EnemyPrefab , spawnPositions[y].position , Quaternion.identity);
        }

        else if(lv1EnemyOdds + lv2EnemyOdds <= x && x < lv1EnemyOdds + lv2EnemyOdds + lv3EnemyOdds){
            Instantiate(lv3EnemyPrefab , spawnPositions[y].position , Quaternion.identity);
        }

        else if(lv1EnemyOdds + lv2EnemyOdds + lv3EnemyOdds <= x && x < lv1EnemyOdds + lv2EnemyOdds + lv3EnemyOdds + lv4EnemyOdds){
            Instantiate(lv4EnemyPrefab , spawnPositions[y].position , Quaternion.identity);
        }

        Invoke(nameof(goSpawnFunc) , spawnRate);
    }

    private bool goSpawn = true;
    public float minSpawnRate;
    public float maxSpawnRate;
    private float spawnRate;
    void goSpawnFunc(){
        goSpawn = true;
        spawnRate = Random.Range(minSpawnRate , maxSpawnRate);
    }


    private float timer;
    public float maxTimer;
    void spawnDecrease(){
        timer -= Time.deltaTime;
        if(timer <= 0){
        if(minSpawnRate >= 0.4f && maxSpawnRate >= 0.9f){
            minSpawnRate -= 0.05f;
            maxSpawnRate -= 0.05f;
            timer = maxTimer;
            }
        }
    }

}
