using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour, IScoreObserver
{
    public Text scoreText;
    private int score = 0;

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    void IScoreObserver.notifyAddScore()
    {
        ++score;
    }
}
