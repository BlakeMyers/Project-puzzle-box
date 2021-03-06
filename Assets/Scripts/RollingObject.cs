﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingObject : MonoBehaviour
{
    [SerializeField]
    AudioSource goalSound;

    public Rigidbody rigidBody;
    GameObject UI_Manager;
    MeshRenderer meshRenderer1;
    MeshRenderer meshRenderer2;
    MeshRenderer meshRenderer3;
    MeshRenderer meshRenderer4;
    MeshRenderer meshRenderer5;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        UI_Manager = GameObject.Find("UI_Manager");
        meshRenderer1 = GameObject.Find("Cube1").GetComponent<MeshRenderer>();
        meshRenderer1.material = meshRenderer1.materials[0];
        meshRenderer2 = GameObject.Find("Cube2").GetComponent<MeshRenderer>();
        meshRenderer2.material = meshRenderer2.materials[0];
        meshRenderer3 = GameObject.Find("Cube3").GetComponent<MeshRenderer>();
        meshRenderer3.material = meshRenderer3.materials[0];
        meshRenderer4 = GameObject.Find("Cube4").GetComponent<MeshRenderer>();
        meshRenderer4.material = meshRenderer4.materials[0];
        meshRenderer5 = GameObject.Find("Cube5").GetComponent<MeshRenderer>();
        meshRenderer5.material = meshRenderer5.materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Goal")
        {
            goalSound.Play();
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
        if (col.gameObject.tag == "Goal1")
        {
            goalSound.Play();
            Debug.Log("Cube1");
            meshRenderer1.material = meshRenderer1.materials[1];
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
        if (col.gameObject.tag == "Goal2")
        {
            goalSound.Play();
            Debug.Log("Cube2");
            meshRenderer2.material = meshRenderer2.materials[1];
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
        if (col.gameObject.tag == "Goal3")
        {
            goalSound.Play();
            Debug.Log("Cube2");
            GameObject puzzle = GameObject.Find("Cube3");
            MeshRenderer meshRenderer = puzzle.GetComponent<MeshRenderer>();
            meshRenderer.material = meshRenderer.materials[1];
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
        if (col.gameObject.tag == "Goal4")
        {
            goalSound.Play();
            Debug.Log("Cube4");
            meshRenderer4.material = meshRenderer4.materials[1];
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
        if (col.gameObject.tag == "Goal5")
        {
            goalSound.Play();
            Debug.Log("Cube5");
            meshRenderer5.material = meshRenderer5.materials[1];
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
    }
}
