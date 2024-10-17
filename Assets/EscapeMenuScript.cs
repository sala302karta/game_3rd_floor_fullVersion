using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenuScript : MonoBehaviour
{
    public bool isDisplayedOnDefault = false;
    public GameObject canvasGameObject = null;

    private bool isDisplayed;

    private void Start()
    {
        isDisplayed = isDisplayedOnDefault;
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
        canvasGameObject.SetActive(isDisplayed);
        Time.timeScale = isDisplayed ? 0 : 1;
        Cursor.visible = isDisplayed;
        Cursor.lockState = isDisplayed ? CursorLockMode.None : CursorLockMode.Locked;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
