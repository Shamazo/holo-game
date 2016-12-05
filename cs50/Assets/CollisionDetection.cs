using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {
    //need to make sure balls pass through each other. and only collide with projectiles 
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with trigger object " + other.name);
        gameObject.transform.position.Set(0,0,0) ;

        if (other.gameObject.name == "Projectile")
            {
            Destroy(gameObject);
           }
    }
    void OnTriggerStay(Collider other)
    {
        print("Still colliding with trigger object " + other.name);
    }
}
