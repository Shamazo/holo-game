using UnityEngine;
using System.Collections;
using System;

public class TargetManager : MonoBehaviour {

    public GameObject TargetPrefab;

    public GameObject[] targets;
    public Vector3 spawnValues;
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
                randTarget = UnityEngine.Random.Range(0, 2);
                Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-spawnValues.x, spawnValues.x), UnityEngine.Random.Range(0, spawnValues.y), UnityEngine.Random.Range(-spawnValues.z, spawnValues.z));

                Instantiate(targets[randTarget], (spawnPosition + transform.TransformPoint(0, 0, 0)), gameObject.transform.rotation);
                numTargets += 1;
            }
            yield return new WaitForSeconds(spawnWait);
        }
    }

}
