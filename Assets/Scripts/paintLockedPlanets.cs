﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class paintLockedPlanets : MonoBehaviour {
    public FileController fileController;
    // Use this for initialization
    void Start () {
        paint();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void paint()
    {
        for (int i = 1; i <= fileController.getNWorld(); i++)
        {
            transform.GetChild(i).GetComponentInChildren<Image>().color = Color.white;
        }
    }
}
