using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public GameObject Cube;
    public int rotationSpeed;
    void Start()
    {
        
    }
    void Update()
    {
        Cube.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        Cube.transform.Rotate(Vector3.forward * rotationSpeed/2 * Time.deltaTime);
    }
}