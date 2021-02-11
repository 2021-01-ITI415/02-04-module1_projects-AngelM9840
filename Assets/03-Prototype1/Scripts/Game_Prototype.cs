using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Prototype : MonoBehaviour {
    static private Game_Prototype S; 

    [Header("Set in Inspector")]
    public Text uitLevel; 
    public Text uitShots; 
    public Text uitButton; 
    public Vector3 castlePos; 
    public GameObject[] castles; 

    [Header("Set Dynamically")]
    public int level;
    public int levelMax; 
    public int shotsTaken;
    public GameObject castle; 
    public GameMode mode = GameMode.idle;
    public string showing = "Show Slingshot"; 

    void Start()
    {
        S = this;

        level = 0;
        levelMax = castles.Length;
        StartLevel();
    }

    void StartLevel()
    {

    }

    void UpdateGUI() {
        uitLevel.text = "Level: " + (level + 1) + " of " + levelMax;
        uitShots.text = "Shots Taken: " + shotsTaken;
    }

    void Update()
    {

    }

    void NextLevel()
    {
        level++;
        if (level == levelMax)
        {
            level = 0;
        }
        StartLevel();
    }

    public void SwitchView(string eView = "")
    {
        if (eView == "")
        {
            eView = uitButton.text;
        }
        showing = eView;
        switch (showing)
        {
            case "Show Slingshot":
                FollowCam.POI = null;
                uitButton.text = "Show Castle";
                break;

            case "Show Castle":
                FollowCam.POI = S.castle;
                uitButton.text = "Show Both";
                break;

            case "Show Both":
                FollowCam.POI = GameObject.Find("ViewBoth");
                uitButton.text = "Show Slingshot";
                break;
        }
    }

    public static void ShotFired() {
        S.shotsTaken++;
    }
}