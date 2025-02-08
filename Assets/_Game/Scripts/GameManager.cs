using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public ImageTimer HarvestTimer;
    public ImageTimer EatingTimer;
    public Image raidTimerImg;
    public Image slaveTimerImg;
    public Image warriorTimerImg;
    public Button slaveButton;
    public Button warriorButton;
    public TextMeshPro resourcesText;
    public int slaveCount;
    public int warriorCount;
    public int wheatCount;
    public int wheatPerSlave;
    public int wheatToWarrior;
    public int slaveCost;
    public int warriorCost;
    public int raidIncrease;
    public int NextRaid;
    public float slaveCreateTime;
    public float warriorCreateTime;
    public float raidMaxTime;
    private float slaveTimer;
    private float warriorTimer;
    private float raidTimer;

    void Start()
    {
        UpdateText();
    }

    void Update()
    {
        
    }

    private void UpdateText()
    {
        resourcesText.text = slaveCount + " " + warriorCount + " " + wheatCount;
    }
}

   