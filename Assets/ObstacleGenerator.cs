using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float initialPlayerDistance = 10f;
    public float obstacleDistance = 5f;

    private const float OBSTACLE_Y_POS = 1f;
    private const int INITIAL_NUMBER_OF_OBJECTS = 5;
    private float previousTime = 0f;

    void Start()
    {
        for (int i = 0; i < INITIAL_NUMBER_OF_OBJECTS; ++i)
        {
            CreateObstacle(initialPlayerDistance + i * obstacleDistance);
        }
    }

    void Update()
    {
        float currentTime = Time.time;
        if (((currentTime - previousTime) < 0.5f && previousTime != 0f) || currentTime == 0f) return;

        CreateObstacle(initialPlayerDistance + INITIAL_NUMBER_OF_OBJECTS * obstacleDistance);
        previousTime = currentTime;
    }

    private void CreateObstacle(float obstacleZPosition)
    {
        int selectedPrefabIndex = Random.Range(0, obstaclePrefabs.Length);
        Instantiate(obstaclePrefabs[selectedPrefabIndex],
            new Vector3(0, OBSTACLE_Y_POS, obstacleZPosition), Quaternion.identity);
    }
}
