using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeWin : MonoBehaviour
{
    public GameObject WinPanel;

    void Start()
    {
        WinPanel.SetActive(false);
    }

    void Update()
    {
        
    }

    public void toggleEndMenuWin()
    {
        WinPanel.SetActive(true);
    }

}
