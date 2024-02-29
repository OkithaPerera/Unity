using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FloorsBackButton : MonoBehaviour
{
    public Button backToWelcome;
    public Button groundFloor;
    public Button firstFloor;
    public Button secondFloor;

    void Start()
    {
        backToWelcome.onClick.AddListener(OnBackButtonClick);
        groundFloor.onClick.AddListener(OnGroundFloorButtonClick);
        firstFloor.onClick.AddListener(OnFirstFloorButtonClick);
        secondFloor.onClick.AddListener(OnSecondFloorButtonClick);
    }

    public void OnBackButtonClick()
    {
        SceneManager.LoadScene("WelcomeScreen");
    }

    public void OnGroundFloorButtonClick()
    {
        SceneManager.LoadScene("GroundFloorAR");
    }

    public void OnFirstFloorButtonClick()
    {
        SceneManager.LoadScene("FirstFloorAR");
    }

    public void OnSecondFloorButtonClick()
    {
        SceneManager.LoadScene("SecondFloorAR");
    }
}
