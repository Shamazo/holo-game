using UnityEngine;
using System.Collections;

public class TargetMove : MonoBehaviour {
    public float speed = 30;
    //public float height = gameObject.transform.y;
    private Vector3 pivot = new Vector3(0, .5F , 0);

    // Use this for initialization
    void Start() {

    //public float hieght = transform.position.y;


    }


// Update is called once per frame
void Update () {

        transform.RotateAround(pivot, Vector3.up, speed * Time.deltaTime);
    }


}
