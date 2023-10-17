using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    private void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameController.instance.hit++;
    }
}