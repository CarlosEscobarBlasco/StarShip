﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(FollowShip))]
public class DestroyerController : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	}

    void Reset()
    {
        gameObject.GetComponent<Collider2D>().isTrigger = true;
        gameObject.GetComponent<Collider2D>().transform.localScale = new Vector3(10, 1, 0);
    }

	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag=="Meteor"|| collider.gameObject.tag == "BlackHole"|| collider.gameObject.tag == "TurboSpeed") Destroy(collider.gameObject);
    }
}
