using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    //Instead of using Transform use Rigidbody.MoveRotation()
    //That way we get collisions, and can inset objects

    [SerializeField]
    private float speed = 100.0f;
    private Vector3 rotateVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag()
    {
        rotateVector = new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed;
        rotateVector.y *= -1;
        transform.Rotate(rotateVector);
    }
}
