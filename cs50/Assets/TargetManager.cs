using UnityEngine;
using System.Collections;
using System;

public class TargetManager : MonoBehaviour {

    public GameObject TargetPrefab;

    public GameObject[] targets;
    public Vector3 spawnValues;
    public Vector3 minSpawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    public int maxNumTargets;
    public int numTargets;


    int randTarget;

    // Use this for initialization
    void Start () {
        StartCoroutine(waitSpawner());
    }



    // Update is called once per frame
    void Update () {
        spawnWait = UnityEngine.Random.Range(spawnLeastWait, spawnMostWait);
        // check if has been hit by projectile 
       // if hit by projectile reduce number of targets 


    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        // do something to control maximum number of targets. 
        while (!stop)
        {
            if (numTargets < maxNumTargets)
            {
                print(numTargets);
                randTarget = UnityEngine.Random.Range(0, 1);
                Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(minSpawnValues.x, spawnValues.x), UnityEngine.Random.Range(minSpawnValues.y, spawnValues.y), UnityEngine.Random.Range(minSpawnValues.z, spawnValues.z));

                Instantiate(targets[randTarget], (spawnPosition + transform.TransformPoint(0, 0, 0)), gameObject.transform.rotation);
                numTargets += 1;
            }
            yield return new WaitForSeconds(spawnWait);
        }
    }

}
