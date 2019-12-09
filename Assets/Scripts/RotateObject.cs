using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    private Vector3 rotateVector;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
        
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(0)){
            rotateVector = new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed;
            rotateVector.y *= -1;

            transform.RotateAround(this.transform.position, rotateVector, 1 * speed);

            //this.transform.rotation = (this.transform.rotation * deltaRotation);
        }

        if(Input.GetMouseButton(1)){
            rotateVector = new Vector3(0, 0, Input.GetAxis("Mouse Y") - Input.GetAxis("Mouse X")) * Time.deltaTime * speed;
            rotateVector.y *= -1;

            transform.RotateAround(this.transform.position, rotateVector, 1 * speed);

            //this.transform.rotation = (this.transform.rotation * deltaRotation);
        }
    }
}
