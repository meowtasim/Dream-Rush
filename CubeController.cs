using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Rigidbody cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.AddForce(10000, 0, 0);
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        transform.GetComponent<Movement>().enable = false;
    }*/
}
