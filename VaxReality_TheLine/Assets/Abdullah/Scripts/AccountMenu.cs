using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountMenu : MonoBehaviour
{
    public void OnClick_Back()
    {
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }
}
