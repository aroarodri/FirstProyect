using UnityEngine;

[CreateAssetMenu(fileName = "New SerializeObject", menuName = "SerializeObject")]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public GameObject prefabToSpawn;

    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;
}
