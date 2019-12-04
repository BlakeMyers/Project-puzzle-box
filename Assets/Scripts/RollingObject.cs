using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingObject : MonoBehaviour
{
    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Goal")
        {
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
        }
    }
}
