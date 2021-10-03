using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text instructionsText;
    public ScoreTracker scoreTracker;

    public string GAME_OVER_TEXT = "Score: ";
    public string RESTART_INSTRUCTIONS_TEXT = "Press R to restart";

    float timeScale = 0f;
    bool isGameEnded = false;

    public void Start()
    {
        Invoke("HideInstructions", 3f);
    }

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

        scoreTracker.enabled = false;
        scoreText.text = GAME_OVER_TEXT + scoreText.text;
        instructionsText.text = RESTART_INSTRUCTIONS_TEXT;
        isGameEnded = true;
    }

    private void Restart()
    {
        scoreTracker.enabled = true;
        Time.timeScale = timeScale;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameEnded = false;
    }

    private void HideInstructions()
    {
        instructionsText.text = "";
    }
}
