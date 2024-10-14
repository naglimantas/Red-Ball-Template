using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]TMP_Text timerText;
    [SerializeField] TMP_Text bestTimeText;
    public static GameManager instance;
    public float levelTime;
    float bestTime;

    void Awake()
    {
        instance = this;
        bestTime = PlayerPrefs.GetFloat("bestTime",float.MaxValue);
        bestTimeText.text = "Best:" + TimeSpan.FromSeconds(bestTime).ToString(@"mm\:ss");
    }

    void Update()
    {
        levelTime += Time.deltaTime;
        timerText.text = TimeSpan.FromSeconds(levelTime).ToString(@"mm\:ss");
    }

    public void Win()
    {
        if (levelTime < bestTime)
        {
            bestTime = levelTime;
            PlayerPrefs.SetFloat("bestTime",bestTime);
        }
    }

    public void Die()
    {
        var name = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(name);
    }
}