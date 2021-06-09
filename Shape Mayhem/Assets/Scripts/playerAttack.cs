using UnityEngine;
using UnityEngine.SceneManagement;

public class playerAttack : MonoBehaviour
{
    public Transform firePoint;
    
    public GameObject bulletLV1Prefab;
    public GameObject bulletLV2Prefab;
    public GameObject bulletLV3Prefab;
    public GameObject bulletLV4Prefab;
    public GameObject bulletLV5Prefab;
    public GameObject bulletLV6Prefab;
    public GameObject bulletLV7Prefab;
    public GameObject bulletLV8Prefab;
    public GameObject bulletLV9Prefab;

    public int level;

    public static bool isDead;

    void Start(){
        isDead = false;
        level = 1;
    }


    void Update()
    {
        levels();
        if(Input.GetMouseButton(0)){
            attack();
        }
    }

    void levels(){
        if(200 < scoreManager.score && scoreManager.score < 500)
        level = 2;

        else if(500 < scoreManager.score && scoreManager.score < 800)
        level = 3;

        else if(800 < scoreManager.score && scoreManager.score < 1200)
        level = 4;

        else if(1200 < scoreManager.score && scoreManager.score < 1800)
        level = 5;

        else if(1800 < scoreManager.score && scoreManager.score < 2300)
        level = 6;

        else if(2300 < scoreManager.score && scoreManager.score < 2800)
        level = 7;

        else if(2800 < scoreManager.score && scoreManager.score < 3500)
        level = 8;

        else if(3500 < scoreManager.score && scoreManager.score < 4800)
        level = 9;
    }

    void attack(){
        if(level == 1){
            level1();
        }

        else if(level == 2){
            level2();
        }

        else if(level == 3){
            level3();
        }

        else if(level == 4){
            level4();
        }

        else if(level == 5){
            level5();
        }

        else if(level == 6){
            level6();
        }

        else if(level == 7){
            level7();
        }

        else if(level == 8){
            level8();
        }

        else if(level == 9){
            level9();
        }
    }

    void level1(){
        if(!goFire) return;
        goFire = false;
        cameraShake.sharedInstance.shake();

        Instantiate(bulletLV1Prefab , firePoint.position , firePoint.rotation);

        Invoke(nameof(goFireFunc) , fireRateLV1);
    }

    void level2(){
        if(!goFire) return;
        goFire = false;
        cameraShake.sharedInstance.shake();

        Instantiate(bulletLV2Prefab , firePoint.position , firePoint.rotation);

        Invoke(nameof(goFireFunc) , fireRateLV2);
    }

    void level3(){
        if(!goFire) return;
        goFire = false;
        cameraShake.sharedInstance.shake();

        Instantiate(bulletLV3Prefab , firePoint.position , firePoint.rotation);

        Invoke(nameof(goFireFunc) , fireRateLV3);
    }
    
    void level4(){
        if(!goFire) return;
        goFire = false;
        cameraShake.sharedInstance.shake();

        Instantiate(bulletLV4Prefab , firePoint.position , firePoint.rotation);
        Instantiate(bulletLV4Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 10f));
        Instantiate(bulletLV4Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 10f));

        Invoke(nameof(goFireFunc) , fireRateLV4);
    }

    void level5(){
        if(!goFire) return;
        goFire = false;
        cameraShake.sharedInstance.shake();

        Instantiate(bulletLV5Prefab , firePoint.position , firePoint.rotation);
        Instantiate(bulletLV5Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 5));
        Instantiate(bulletLV5Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 5));
        Instantiate(bulletLV5Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 10));
        Instantiate(bulletLV5Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 10));

        Invoke(nameof(goFireFunc) , fireRateLV5);
    }

    void level6(){
        if(!goFire) return;
        goFire = false;
        cameraShake.sharedInstance.shake();

        Instantiate(bulletLV6Prefab , firePoint.position , firePoint.rotation);
        Instantiate(bulletLV6Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 6f));
        Instantiate(bulletLV6Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 90f));
        Instantiate(bulletLV6Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 96f));
        Instantiate(bulletLV6Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 90f));
        Instantiate(bulletLV6Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 96f));
        Instantiate(bulletLV6Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 15f));
        Instantiate(bulletLV6Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 15f));


        Invoke(nameof(goFireFunc) , fireRateLV6);

    }

    void level7(){
        if(!goFire) return;
        goFire = false;
        cameraShake.sharedInstance.shake();

        Instantiate(bulletLV7Prefab , firePoint.position , firePoint.rotation);
        Instantiate(bulletLV7Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 10));
        Instantiate(bulletLV7Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 10));


        Invoke(nameof(goFireFunc) , fireRateLV7);
    }

    void level8(){
        if(!goFire) return;
        goFire = false;
        cameraShake.sharedInstance.shake();

        Instantiate(bulletLV8Prefab , firePoint.position , firePoint.rotation);
        Instantiate(bulletLV8Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 35));
        Instantiate(bulletLV8Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 35));
        Instantiate(bulletLV8Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 215));
        Instantiate(bulletLV8Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 215));


        Invoke(nameof(goFireFunc) , fireRateLV8);
    }

    void level9(){
        if(!goFire) return;
        goFire = false;
        cameraShake.sharedInstance.shake();

        Instantiate(bulletLV9Prefab , firePoint.position , firePoint.rotation);
        Instantiate(bulletLV9Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 10));
        Instantiate(bulletLV9Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 10));
        Instantiate(bulletLV9Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z + 20));
        Instantiate(bulletLV9Prefab , firePoint.position , Quaternion.Euler(0f , 0f , firePoint.eulerAngles.z - 20));


        Invoke(nameof(goFireFunc) , fireRateLV9);
    }


    private bool goFire = true;
    public float fireRateLV1;
    public float fireRateLV2;
    public float fireRateLV3;
    public float fireRateLV4;
    public float fireRateLV5;
    public float fireRateLV6;
    public float fireRateLV7;
    public float fireRateLV8;
    public float fireRateLV9;

    void goFireFunc(){
        goFire = true;
    }


    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("enemy")){
            this.gameObject.SetActive(false);
            isDead = true;
            if(scoreManager.score > PlayerPrefs.GetInt("highScore" , 0)){
                PlayerPrefs.SetInt("highScore" , scoreManager.score);
            }
            Invoke(nameof(restart) , 1f);
        }
    }

    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
