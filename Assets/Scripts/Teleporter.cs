using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public float stayTime;
    public float teleportTime = 2f;
    public string nextScene;


    void OnTriggerStay2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;

        stayTime += Time.deltaTime;
        if (stayTime >= teleportTime)
        {
            GameManager.instance.Win();
	        SceneManager.LoadScene(nextScene);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        stayTime = 0;
    }
}