using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    Transform t;
    public float rotAmount=30f;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        t.localEulerAngles += new Vector3(0f, rotAmount * Time.deltaTime, 0f);
    }
}