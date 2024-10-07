using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    private void Awake()
    {
        instance = this;
    }

    public void Die()
    {
        var name = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(name);
    }
}
