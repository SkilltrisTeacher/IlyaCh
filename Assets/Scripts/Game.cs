using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private int startLives = 3;
    [SerializeField] private string mainMenuName;
    [SerializeField] private GameObject restartMenu;
    [SerializeField] private TMP_Text finalCoinsCount;
    private int coinCount;
    private int livesCount;

    private void Awake()
    {
        Game[] anotherGame = FindObjectsOfType<Game>();
        if (anotherGame.Length > 1) Destroy(gameObject);
        else DontDestroyOnLoad(gameObject);

    }

    private void Start()
    {
        livesCount = startLives;
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        restartMenu.SetActive(true);
    }

    private void LoseLife()
    {
        livesCount--;
        PlayerUI.ui.SetLives(livesCount);
        if (livesCount <= 0) GameOver();
    }

    public void AddCoins(int amount)
    {
        coinCount += amount;
        PlayerUI.ui.ShoCoinCount(coinCount);
    }






}
