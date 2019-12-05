﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingObject : MonoBehaviour
{
    public Rigidbody rigidBody;
    GameObject UI_Manager;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        UI_Manager = GameObject.Find("UI_Manager");
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
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
    }
}
