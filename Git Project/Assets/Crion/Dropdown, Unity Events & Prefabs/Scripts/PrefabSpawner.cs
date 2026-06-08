using UnityEngine;
using TMPro;
using System.Collections;

public class PrefabSpawner : MonoBehaviour
{
    [Header("UI")]
    public TMP_Dropdown prefabDropdown;

    [Header("Prefabs")]
    public GameObject cubePrefab;
    public GameObject cylinderPrefab;

    [Header("Spawn Settings")]
    public Transform spawnPoint;
    public float spawnInterval = 1f;

    private Coroutine spawnCoroutine;

    public void StartSpawning()
    {
        if (spawnCoroutine == null)
        {
            spawnCoroutine = StartCoroutine(SpawnRoutine());
        }
    }

    public void StopSpawning()
    {
        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine);
            spawnCoroutine = null;
        }
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            GameObject prefabToSpawn = null;

            switch (prefabDropdown.value)
            {
                case 1:
                    prefabToSpawn = cubePrefab;
                    break;

                case 2:
                    prefabToSpawn = cylinderPrefab;
                    break;
            }

            if (prefabToSpawn != null)
            {
                Instantiate(
                    prefabToSpawn,
                    spawnPoint.position,
                    Quaternion.identity
                );
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}