//using statements
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//menu manager, uses enums to control what menu is shown on screen
public static class MenuManager{


    //bool that shows whether or not the menu game objects are initilized
    public static bool isReady {get; set;}

    //game object that hold all the ui objects for their respective menu
    public static GameObject Main, LevelSelect, Easy, Medium, Hard;


    //gets all menu gameobjects
    public static void getMenus(){
        GameObject canvas = GameObject.Find("Canvas");
        Main = canvas.transform.Find("MainMenu").gameObject;
        LevelSelect = canvas.transform.Find("LevelSelect").gameObject;
        Easy = canvas.transform.Find("Easy").gameObject;
        Medium = canvas.transform.Find("Medium").gameObject;
        Hard = canvas.transform.Find("Hard").gameObject;

        isReady = true;
    } 


    public static void changeMenu (string toMenu, GameObject fromMenu){

        if(!isReady){ MenuManager.getMenus();}

                Debug.Log(MenuManager.isReady);

        switch (toMenu){

            case "MainMenu":
                Main.SetActive(true);
                break;
            case "LevelSelect":
                LevelSelect.SetActive(true);
                break;
            case "Easy":
                Easy.SetActive(true);
                break;
            case "Medium":
                Medium.SetActive(true);
                break;
            case "Hard":
                Hard.SetActive(true);
                break;

        }

    
        fromMenu.SetActive(false);


    }

 static void OnDestroy()
    {
        Debug.Log("OnDestroy1");
    }


}