using UnityEngine;

class ScoreCounter: MonoBehaviour
{
    public IScoreObserver scoreObserver;

    private void OnDestroy()
    {
        scoreObserver.notifyAddScore();
    }
}
