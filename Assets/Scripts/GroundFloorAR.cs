using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GroundFloorAR : MonoBehaviour
{
    public Button backToFloorButtons;
   

    void Start()
    {
        backToFloorButtons.onClick.AddListener(OnBackClick);
        
    }

    public void OnBackClick()
    {
        SceneManager.LoadScene("FloorButtons");
    }

   
}
