using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }

    public void Die()
    {
        var name = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(name);
    }
}