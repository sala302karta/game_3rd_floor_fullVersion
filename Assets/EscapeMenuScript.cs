using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenuScript : MonoBehaviour
{
    private bool isDisplayed = false;

    private void Start()
    {
        UpdateFromIsDisplayed();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    public void ToggleMenu()
    {
        isDisplayed = !isDisplayed;
        UpdateFromIsDisplayed();
    }

    private void UpdateFromIsDisplayed()
    {
        GetComponent<Canvas>().enabled = isDisplayed;
        Time.timeScale = isDisplayed ? 0 : 1;
        Cursor.visible = isDisplayed;
        Cursor.lockState = isDisplayed ? CursorLockMode.None : CursorLockMode.Locked;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
