﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WorldMenuSlidersController : MonoBehaviour, MenuSliderController{

    public Text name;
    private int actualWorld;
    private MenuController menuController;

    void Start()
    {
        menuController = GameObject.FindGameObjectWithTag("MenuController").GetComponent<MenuController>();
        refreshValues(1);
    }

    void Update()
    {

    }

    public void refreshValues(int actualWorld)
    {
        name.text=transform.GetChild(0).GetChild(actualWorld - 1).name;
        this.actualWorld = actualWorld;
    }

    public void setPlanetToController(int difficulty)
    {
        menuController.selectWorld(name.text, difficulty);
    }
}
