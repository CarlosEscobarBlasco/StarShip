﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(FollowShip))]
public class SpawnerController : MonoBehaviour {
    public GameObject[] objectsToSpawn;
    private GameObject objectToSpawn;

	// Use this for initialization
	void Start () {
        foreach(GameObject objectToSpawn in objectsToSpawn)
        {
            ObjectData data = objectToSpawn.GetComponent<ObjectData>();
            StartCoroutine(spawnController(objectToSpawn, data.getSpawnTimer(), data.getTimeToSpawn()));
        }
	}
	
	// Update is called once per frame
	void Update () {

	}

    IEnumerator spawnController(GameObject objectToSpawn, float spawnTimer, float timeToSpawn)
    {
        yield return new WaitForSeconds(timeToSpawn);
        while (true)
        {
            spawn(objectToSpawn);
            yield return new WaitForSeconds(Random.Range(spawnTimer/3,spawnTimer));
        }
    }

    void spawn(GameObject objectToSpawn)
    {
        Instantiate(objectToSpawn, randomPosition(objectToSpawn), objectToSpawn.transform.rotation);
    }

    Vector3 randomPosition(GameObject objectToSpawn)
    {
        return new Vector3(Random.Range(-2.4f, 2.4f), gameObject.transform.position.y, objectToSpawn.transform.position.z);
    }

}
