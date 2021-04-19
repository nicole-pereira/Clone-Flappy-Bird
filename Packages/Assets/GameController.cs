using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int Score;
    public Text scoreText;

    //chamado toda vez que inicializa o jogo
    void Start(){
        Time.timeScale = 1;
    }   
    
    public void RestartGame(){
        SceneManager.LoadScene(0);
    }
}
