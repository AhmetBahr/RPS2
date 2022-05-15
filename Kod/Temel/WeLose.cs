using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WeLose : MonoBehaviour
{

    public GameObject LosePanel;
    public Image backgroundImg;

    private bool isShow = false;
    private float transition = 0.0f;

    void Start()
    {
        LosePanel.SetActive(false);
    }

    void Update()
    {
        if (!isShow)
            return;

        transition += (Time.deltaTime)/5;
        backgroundImg.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, transition);

    }

    public void toggleEndMenuLose()
    {
        LosePanel.SetActive(true);
        isShow = true;

    }
}
