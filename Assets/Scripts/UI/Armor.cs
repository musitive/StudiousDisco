﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Armor : MonoBehaviour
{
    public Image[] numbers;
    private int level = 1;
    public int maxLevel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        testNumberInputKeys();
        retrievePlayerArmorLevel();
        levelBounds();
        displayNumber();
    }

    //dependent on player
    //updates UI armor level to match player armor level
    void retrievePlayerArmorLevel()
    {
        //TODO
    }

    //enforces lower and upper limits of level
    void levelBounds()
    {
        if(level < 1)
            level = 1;
        if(level > maxLevel)
            level = maxLevel;
    }

    //displays image for only current level
    void displayNumber()
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            if(level - 1 == i)
                numbers[i].enabled = true;
            else
                numbers[i].enabled = false;
        }
    }

    //testing
    //changes level with -/+ on keypad if pressing right ctrl
    void testNumberInputKeys()
    {
        if(Input.GetKey("right ctrl"))
        {
            if(Input.GetKeyDown("[-]"))
                level--;
            if(Input.GetKeyDown("[+]"))
                level++;
        }
    }
}