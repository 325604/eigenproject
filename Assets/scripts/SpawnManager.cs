using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private float zEnemySpawn = 12.0f;
    private float xSpawnRange = 16.0f;
    private float ySpawn = 0.75f;
    private float enemySpawnTime = 2.0f;
    private float startDelay = 3.0f;

    TextMeshProUGUI score_Text;
    public static int score;
    public TextMeshProUGUI gameOvertext;


    public bool isGameActive;
    public Button RestartButton;

    // Start is called before the first frame update

    void Start()
    {
        isGameActive = true;
        score = 0;
        
        score_Text = GameObject.Find("score Text").GetComponent<TextMeshProUGUI>();
        UpdateScore();
          
        
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

   
    
    
   // hier staat de random spawn van de enenmys
    void SpawnRandomEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
        score++;
        UpdateScore();
    }
    //hier wordt alle score bij gehouden 
    public void UpdateScore()
    {
        Debug.Log(score_Text);
        score_Text.text = "score: " + score.ToString();
    }

    public void GameOver()
    {
        gameOvertext.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
        isGameActive = false;
    }
    // zo wordt de game restart
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

   