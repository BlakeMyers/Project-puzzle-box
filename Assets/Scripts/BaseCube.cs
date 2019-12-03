using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCube : MonoBehaviour
{

    public float RotationSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(1)){
            float x = Input.GetAxis("Mouse X") * RotationSpeed;
            float y = Input.GetAxis("Mouse Y") * RotationSpeed;
            
            this.transform.Rotate(y, -x, 0);
        }
    }
}
