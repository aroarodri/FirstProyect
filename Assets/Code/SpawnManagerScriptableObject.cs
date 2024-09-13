using UnityEngine;

[CreateAssetMenu(fileName = "New SerializeObject", menuName = "SerializeObject")]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public GameObject prefabToSpawn;

    public string prefabName;
    public int numberOfPrefabsToCreate;

    public Vector3[] spawnPoints;
}
