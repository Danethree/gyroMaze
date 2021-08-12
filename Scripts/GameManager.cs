using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int times = 3;
    [SerializeField]private GameObject GameOverPanel;
    public static GameManager _gameManager;
    public GameObject player;
    private void Awake()
    {
        if (_gameManager == null)
        {
            _gameManager = this;
        }
        
    }

    void Start()
    {
        times = PlayerPrefs.GetInt("TIMES");
      GameOverPanel = GameObject.Find("GameOver");
      GameOverPanel.SetActive(false);
      
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("TIMES") <= 0)
        {
            Destroy(player);
            GameOverPanel.SetActive(true);   
            
        }
    }

   public void ReloadScene()
    {
        times -= 1;
        PlayerPrefs.SetInt("TIMES",times);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        

    }
}
