using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingObject : MonoBehaviour
{
    [SerializeField]
    AudioSource goalSound;

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
            goalSound.Play();
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
        if (col.gameObject.tag == "Goal1")
        {
            goalSound.Play();
            Debug.Log("Cube1");
            GameObject puzzle = GameObject.Find("Cube1");
            MeshRenderer meshRenderer = puzzle.GetComponent<MeshRenderer>();
            meshRenderer.material = meshRenderer.materials[1];
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
        if (col.gameObject.tag == "Goal2")
        {
            goalSound.Play();
            Debug.Log("Cube2");
            GameObject puzzle = GameObject.Find("puzzle2");
            MeshRenderer meshRenderer = puzzle.GetComponent<MeshRenderer>();
            meshRenderer.material = meshRenderer.materials[1];
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
            GameObject puzzle = GameObject.Find("Cube4");
            MeshRenderer meshRenderer = puzzle.GetComponent<MeshRenderer>();
            meshRenderer.material = meshRenderer.materials[1];
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
        if (col.gameObject.tag == "Goal5")
        {
            goalSound.Play();
            Debug.Log("Cube5");
            GameObject puzzle = GameObject.Find("Cube5");
            MeshRenderer meshRenderer = puzzle.GetComponent<MeshRenderer>();
            meshRenderer.material = meshRenderer.materials[1];
            transform.position = new Vector3(0, 0, 0);
            rigidBody.isKinematic = true;
            UI_Manager.GetComponent<UI_Controller>().puzzles_solved += 0.5f;
        }
    }
}
