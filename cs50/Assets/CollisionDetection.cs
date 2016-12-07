using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {

    public GameObject TargetSpawner;
    //called when the projectile and target collide
    void OnTriggerEnter(Collider other)
    {
        TargetSpawner = GameObject.FindGameObjectWithTag("Respawn");
        TargetSpawner.gameObject.SendMessage("delete");
        Debug.Log("Collision detected with trigger object " + other.name);
            //we want both the target and the projectile to be destroyed when they collide
            Destroy(gameObject);
            Destroy(other.gameObject);
            
    }
}
