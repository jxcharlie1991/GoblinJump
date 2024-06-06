using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> platforms = new List<GameObject>();

    public float spawnTime;
    private float countTime;
    private Vector3 spawnPosition;

    // Update is called once per frame
    void Update()
    {
        SpawnPlatform();
    }

    public void SpawnPlatform()
    {
        countTime += Random.Range(Time.deltaTime, Time.deltaTime * 1.6f);
        spawnPosition = transform.position;
        spawnPosition.x = Random.Range(-3.5f, 3.5f);

        if (countTime >= spawnTime)
        {
            CreatePlatform();
            countTime = 0;
        }
    }

    public void CreatePlatform()
    {
        int index = Random.Range(0, platforms.Count);

        GameObject newPlatform = Instantiate(platforms[index], spawnPosition, Quaternion.identity);

        newPlatform.transform.SetParent(this.gameObject.transform);
    }
}
