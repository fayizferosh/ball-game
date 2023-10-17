using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    Rigidbody baller;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        baller = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        baller.AddForce(new Vector3(-yInput, 0f, xInput) * speed);
    }
}