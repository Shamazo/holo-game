using UnityEngine;
using System.Collections;

public class TargetMove : MonoBehaviour {
    //public GameObject TargetPrefab;
    public float speed; 
    public float height;
    private Vector3 pivot;
    // Use this for initialization
    void Start() {
        speed = UnityEngine.Random.Range(-40, 40);
        height = gameObject.transform.position.x;
        pivot = new Vector3(0, height, 0);
        //public float hieght = transform.position.y;


    }


// Update is called once per frame
void Update () {

        transform.RotateAround(pivot, Vector3.up, speed * Time.deltaTime);
    }


}
