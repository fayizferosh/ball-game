using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void Start()
    {
        GameController.instance.pickupCount++;
    }
    private void OnCollisionEnter(Collision collision)
    {
	GameController.instance.score++;
	GameController.instance.pickupCount--;
	Destroy(gameObject);
    }
    void Update()
    {
	if(GameController.instance.hit != 0)
    	{
		Destroy(gameObject);
    	}
        if(GameController.instance.hit1 != 0)
    	{
		Destroy(gameObject);
    	}
    }
}