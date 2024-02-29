using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public Button getStarted;

    void Start()
    {
        getStarted.onClick.AddListener(OnGetStartedButtonClick);
    }

    public void OnGetStartedButtonClick()
    {
        SceneManager.LoadScene("FloorButtons");
    }
}
