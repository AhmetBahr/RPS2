using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeLose : MonoBehaviour
{

    public GameObject LosePanel;
    
    void Start()
    {
        LosePanel.SetActive(false);
    }

    void Update()
    {

    }

    public void toggleEndMenuLose()
    {
        LosePanel.SetActive(true);
    }
}
