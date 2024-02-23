using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   public void OnClick_Music()
    {
        MenuManager.OpenMenu(Menu.MUSIC, gameObject);
    }

    public void OnClick_Home()
    {
        MenuManager.OpenMenu(Menu.HOME, gameObject);
    }
}
