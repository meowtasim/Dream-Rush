using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrain : MonoBehaviour
{
    public Rigidbody train;
    // Start is called before the first frame update
    void Start()
    {
        train = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        train.MovePosition(train.position + new Vector3(0, 0, -20) * Time.deltaTime);
    }
}
