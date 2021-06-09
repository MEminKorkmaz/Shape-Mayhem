using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    public Text highScoreTxt;



    public void play(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        scoreManager.score = 0;
    }

    void Start(){
        highScoreTxt.text = "HighScore" + " : " + PlayerPrefs.GetInt("highScore" , 0).ToString();
    }
}
