using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {


    // Projectile prefab with a RigidBody component
    public GameObject Projectile;

    void Awake()
    {
        gameObject.tag = "projectilePrefab";
    }

    void OnSelect()
    {
        Vector3 projectilePosition = Camera.main.transform.position + Camera.main.transform.forward * 0.85f;

        Vector3 projectileDirection = Camera.main.transform.forward;

        ShootProjectile(projectilePosition, projectileDirection);
    }

    // need to clean up projectile, should dissapear after a set time
    void ShootProjectile(Vector3 start, Vector3 direction)
    {
        GameObject spawnedProjectile = (GameObject)Instantiate(Projectile);
        Destroy(gameObject, 4);
        // set the projectile's starting location to be slightly in front of user
        spawnedProjectile.transform.position = start;
        print("this should create a projectile");
        // get the RigidBody to apply force to projectile
        Rigidbody rigidBody = spawnedProjectile.GetComponent<Rigidbody>();

        // apply force to the projectile          
        rigidBody.velocity = 5 * direction;

        // make the projectile spin
        rigidBody.angularVelocity = Random.onUnitSphere * 20;
    }
}
