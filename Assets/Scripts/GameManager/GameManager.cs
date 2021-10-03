using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float timeScale = 0f;
    bool isGameEnded = false;

    public void Update()
    {
        if (Input.GetKey(KeyCode.R) && isGameEnded)
        {
            Restart();
        }
    }

    public void TriggerRestart()
    {
        timeScale = Time.timeScale;
        Time.timeScale = 0f;
        isGameEnded = true;
    }

    private void Restart()
    {
        Time.timeScale = timeScale;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameEnded = false;
    }
}
