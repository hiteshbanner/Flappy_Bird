using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int scr;
    public Text scrt;
    public GameObject gameOverScreen;
    [ContextMenu("incr")]
    public void addscore(){
        scr+=1;
        scrt.text=scr.ToString();
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
}
