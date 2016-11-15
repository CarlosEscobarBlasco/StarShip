﻿using System;
using UnityEngine;
using System.Collections;

public class Rewards : MonoBehaviour
{
    private GameObject player;
	// Use this for initialization
	void Start () {
	    player = gameObject.GetComponent<Controller>().getPlayer();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public int getReward(int collisions, float time)
    {
        double reward=150;
        double position = gameObject.GetComponent<Controller>().positionOf(player);
        int difficulty = gameObject.GetComponent<Controller>().getDifficulty();
        reward = Math.Round(reward*difficulty/position)-collisions;
        return (int)reward;
    }
}