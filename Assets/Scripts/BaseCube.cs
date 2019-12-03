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
            float x = Input.GetAxit("Mouse X") * RotationSpeed;
            float y = Input.GetAxit("Mouse Y") * RotationSpeed;
            
            this.transform.Rotate(x, y, 0);
        }
    }
}
