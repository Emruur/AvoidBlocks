using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreem;
    public Text blocksSurvived;
    bool gameOver;
    void Start()
    {
        FindObjectOfType<PlayerScript> ().OnPlayerDeath += onGameOver;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver && Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(0);
        }
        
    }

    void onGameOver(){
        gameOverScreem.SetActive(true);
        blocksSurvived.text = Difficulty.getScore().ToString();
        gameOver= true;
        Difficulty.resetDifficulty();
    }
}
