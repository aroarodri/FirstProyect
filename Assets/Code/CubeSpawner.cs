using UnityEngine;

public class Spawner : MonoBehaviour
{

    public SpawnManagerScriptableObject spawnManagerValues;
    private int numberOfSpawnPoints = 0;
    private Vector3 spawnAreaSize = new Vector3(10, 10, 10);

    void Start()
    {
        GenerateSpawnPoints();
        CubeSpawn();
    }

    private void GenerateSpawnPoints()
    {
        numberOfSpawnPoints = spawnManagerValues.numberOfPrefabsToCreate;

        spawnManagerValues.spawnPoints = new Vector3[numberOfSpawnPoints];
        for (int i = 0; i < numberOfSpawnPoints; i++)
        {
            float x = Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2);
            float y = Random.Range(-spawnAreaSize.y / 2, spawnAreaSize.y / 2);
            float z = Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2);
            spawnManagerValues.spawnPoints[i] = new Vector3(x, y, z);
        }
    }

    private void CubeSpawn()
    {
        int currentSpawnPointIndex = 0;

        for (int i = 0; i < spawnManagerValues.numberOfPrefabsToCreate; i++)
        {
            GameObject cube = Instantiate(spawnManagerValues.prefabToSpawn, spawnManagerValues.spawnPoints[currentSpawnPointIndex], Quaternion.identity);

            currentSpawnPointIndex = (currentSpawnPointIndex + 1) % spawnManagerValues.spawnPoints.Length;
        }
    }

    void Update()
    {

    }
}
