using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{

    public Vector3 movement;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube.transform.localScale = movement;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
