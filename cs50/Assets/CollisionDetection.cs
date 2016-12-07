using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {
    //need to make sure balls pass through each other. and only collide with projectiles 
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with trigger object " + other.name);
            Destroy(gameObject);
            Destroy(other.gameObject);
    }
    void OnTriggerStay(Collider other)
    {
        print("Still colliding with trigger object " + other.name);
    }
}
