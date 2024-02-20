using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MenuManager
{
    public static bool IsInitalised { get; private set; }
    public static GameObject mainMenu, musicMenu, homeMenu;
    public static void Init()
    {
        GameObject canvas = GameObject.Find("HandMenuCanvas");
        mainMenu = canvas.transform.Find("MainMenu").gameObject;
        musicMenu = canvas.transform.Find("AcountMenu").gameObject;
        homeMenu = canvas.transform.Find("WeatherMenu").gameObject;

        IsInitalised = true;
    }

    public static void OpenMenu(Menu menu, GameObject callingMenu)
    {

        if (!IsInitalised)
            Init();

        switch (menu)
        {
            case Menu.MAIN_MENU:
                mainMenu.SetActive(true);
                break;
            case Menu.MUSIC:
                musicMenu.SetActive(true);
                break;
                case Menu.HOME:
                homeMenu.SetActive(true);
                break;

        }

        callingMenu.SetActive(false);
    }
}
