using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;





public enum GameChoi
{ 
        NONE,
        ROCK,
        PAPER,
        SCISSORS
}

public class GamePlayContraller : MonoBehaviour
{
    [SerializeField]
    private Sprite rock_Sprite, Paper_Sprite, scissor_Sprite;
    [SerializeField]
    private Image playerChocie_Ing, oppenentChoci_Img;
    [SerializeField]
    private TMP_Text infoText;

    private GameChoi player_Choice = GameChoi.NONE, opponent_Choice = GameChoi.NONE;

    private AnimatorConttrol animationControll;

    void Awake()
    {
        animationControll = GetComponent<AnimatorConttrol>();
    }
    public void SetChoices(GameChoi gamechoi) {
        switch (gamechoi)
        {
            case GameChoi.ROCK:
                playerChocie_Ing.sprite = rock_Sprite;
                player_Choice = GameChoi.ROCK;
                break;

            case GameChoi.PAPER:
                playerChocie_Ing.sprite = Paper_Sprite;
                player_Choice = GameChoi.PAPER;
                break;

            case GameChoi.SCISSORS:
                playerChocie_Ing.sprite = scissor_Sprite;
                player_Choice = GameChoi.SCISSORS;
                break;
        }
        SetOpponentChoice();
        Determinewinner();
    }


    public void SetOpponentChoice()
    {
        int rnd = Random.Range(0, 3);
        switch (rnd)
        {
            case 0:
                opponent_Choice = GameChoi.ROCK;
                oppenentChoci_Img.sprite = rock_Sprite;
                break;
            case 1:
                opponent_Choice = GameChoi.PAPER;
                oppenentChoci_Img.sprite = Paper_Sprite;
                break;
            case 2:
                opponent_Choice = GameChoi.SCISSORS;
                oppenentChoci_Img.sprite = scissor_Sprite;
                break;
        }
    }

    public void Determinewinner()
    {
       //Draw
       if(player_Choice == opponent_Choice)
        {
            infoText.text = "Draw";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

       //Lose
       if(player_Choice == GameChoi.ROCK && opponent_Choice == GameChoi.PAPER)
        {
            infoText.text = "Lose";
            StartCoroutine(DisplayWinnerAndRestart());
            return;

        }
       if(player_Choice == GameChoi.PAPER && opponent_Choice == GameChoi.SCISSORS)
        {
            infoText.text = "Lose";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
       if(player_Choice == GameChoi.SCISSORS && opponent_Choice == GameChoi.ROCK)
        {
            infoText.text = "Lose";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        //Win
        if (player_Choice == GameChoi.ROCK && opponent_Choice == GameChoi.SCISSORS)
        {
            infoText.text = "Win";
            StartCoroutine(DisplayWinnerAndRestart());
            return;

        }
        if (player_Choice == GameChoi.PAPER && opponent_Choice == GameChoi.ROCK)
        {
            infoText.text = "Win";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi.SCISSORS && opponent_Choice == GameChoi.PAPER)
        {
            infoText.text = "Win";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }


    }   
            
    IEnumerator DisplayWinnerAndRestart()
    {
        yield return new WaitForSeconds(1.0f);
        infoText.gameObject.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        infoText.gameObject.SetActive(false);

        animationControll.ResetAnimations();

    }
}
