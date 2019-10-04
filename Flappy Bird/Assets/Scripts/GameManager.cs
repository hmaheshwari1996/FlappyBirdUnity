using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public bool isGameActive;
    [SerializeField] float xPos = 10.0f;
    [SerializeField] float yRange = 3.0f;
    [SerializeField] GameObject platformPrefab;
    [SerializeField] GameObject titleScreen;
    [SerializeField] GameObject player;
    [SerializeField] Text scoreText;
    int score = 0;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] GameObject flyButton;

    // Start is called before the first frame update
    void Start()
    {

    }
        
    void StartGame()
    {
        isGameActive = true;
        StartCoroutine(SpawnPlatforms());
        StartCoroutine(Score());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnPlatforms()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(2);
            Vector2 RandomPos = new Vector2(xPos, UnityEngine.Random.Range(-yRange, yRange)); ;
            Instantiate(platformPrefab, RandomPos, transform.rotation);
        }
    }

    IEnumerator Score()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(1);
            score = score + 1;
            scoreText.text = "Score : " + score;
        }
        
    }

    public void PlayGame()
    {
        titleScreen.SetActive(false);
        player.SetActive(true);
        flyButton.SetActive(true);
        StartGame();
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
