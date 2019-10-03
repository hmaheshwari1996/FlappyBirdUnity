using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] public bool isGameActive;
    [SerializeField] float xPos = 10.0f;
    [SerializeField] float yRange = 3.0f;
    [SerializeField] GameObject platformPrefab;
    [SerializeField] GameObject titleScreen;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void StartGame()
    {
        isGameActive = true;
        StartCoroutine(SpawnPlatforms());
        
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

    public void PlayGame()
    {
        titleScreen.SetActive(false);
        player.SetActive(true);
        StartGame();
    }
}
