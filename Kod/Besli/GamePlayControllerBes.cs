using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public enum GameChoi2
{
    NONE,
    ROCK,
    PAPER,
    SCISSORS,
    LIZARD,
    SPOCK,
}


public class GamePlayControllerBes : MonoBehaviour
{
    [SerializeField]
    private Sprite rock_Sprite, Paper_Sprite, scissor_Sprite, Lizard_Sprite, Spock_Sprite;
    [SerializeField]
    private Image playerChocie_Ing, oppenentChoci_Img;
    [SerializeField]
    private TMP_Text infotest2;
    public TMP_Text WeText;
    public TMP_Text EnamyText;
    public int WeScore;
    public int EnemyScore;
    public bool gameOn = true;
    public WeWin winMenu;
    public WeLose loseMenu;


    private GameChoi2 player_Choice = GameChoi2.NONE, opponent_Choice = GameChoi2.NONE;

    private Animatorcontbes animationControl;

    void Awake()
    {
        animationControl = GetComponent<Animatorcontbes>();
        winMenu = Object.FindObjectOfType<WeWin>();
        loseMenu = Object.FindObjectOfType<WeLose>();
    }
    public void SetChoices(GameChoi2 gamechoi2)
    {
        switch (gamechoi2)
        {
            case GameChoi2.ROCK:
                playerChocie_Ing.sprite = rock_Sprite;
                player_Choice = GameChoi2.ROCK;
                break;

            case GameChoi2.PAPER:
                playerChocie_Ing.sprite = Paper_Sprite;
                player_Choice = GameChoi2.PAPER;
                break;

            case GameChoi2.SCISSORS:
                playerChocie_Ing.sprite = scissor_Sprite;
                player_Choice = GameChoi2.SCISSORS;
                break;
            case GameChoi2.LIZARD:
                playerChocie_Ing.sprite = Lizard_Sprite;
                player_Choice = GameChoi2.LIZARD;
                break;
            case GameChoi2.SPOCK:
                playerChocie_Ing.sprite = Spock_Sprite;
                player_Choice = GameChoi2.SPOCK;
                break;
        }
        SetOpponentChoice();
        Determinewinner();
    }


    public void SetOpponentChoice()
    {
        int rnd = Random.Range(0, 5);
        switch (rnd)
        {
            case 0:
                opponent_Choice = GameChoi2.ROCK;
                oppenentChoci_Img.sprite = rock_Sprite;
                break;
            case 1:
                opponent_Choice = GameChoi2.PAPER;
                oppenentChoci_Img.sprite = Paper_Sprite;
                break;
            case 2:
                opponent_Choice = GameChoi2.SCISSORS;
                oppenentChoci_Img.sprite = scissor_Sprite;
                break;
            case 3:
                opponent_Choice = GameChoi2.LIZARD;
                oppenentChoci_Img.sprite = Lizard_Sprite;
                break;
            case 4:
                opponent_Choice = GameChoi2.SPOCK;
                oppenentChoci_Img.sprite = Spock_Sprite;
                break;
        }
    }

    public void Determinewinner()
    {
        //Draw
        if (player_Choice == opponent_Choice)
        {
            infotest2.text = "Draw";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        //Lose
        if(player_Choice == GameChoi2.ROCK && opponent_Choice == GameChoi2.PAPER)
        {
            infotest2.text = "Lose";
            EnemyScore++;
            EnamyText.text = EnemyScore.ToString();
            if (EnemyScore == 5)
            {
                WeLose();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.ROCK && opponent_Choice == GameChoi2.SPOCK)
        {
            infotest2.text = "Lose";
            EnemyScore++;
            EnamyText.text = EnemyScore.ToString();
            if (EnemyScore == 5)
            {
                WeLose();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.PAPER && opponent_Choice == GameChoi2.SCISSORS)
        {
            infotest2.text = "Lose";
            EnemyScore++;
            EnamyText.text = EnemyScore.ToString();
            if (EnemyScore == 5)
            {
                WeLose();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.PAPER && opponent_Choice == GameChoi2.LIZARD)
        {
            infotest2.text = "Lose";
            EnemyScore++;
            EnamyText.text = EnemyScore.ToString();
            if (EnemyScore == 5)
            {
                WeLose();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.SCISSORS && opponent_Choice == GameChoi2.ROCK)
        {
            infotest2.text = "Lose";
            EnemyScore++;
            EnamyText.text = EnemyScore.ToString();
            if (EnemyScore == 5)
            {
                WeLose();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.SCISSORS && opponent_Choice == GameChoi2.SPOCK)
        {
            infotest2.text = "Lose";
            EnemyScore++;
            EnamyText.text = EnemyScore.ToString();
            if (EnemyScore == 5)
            {
                WeLose();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.LIZARD && opponent_Choice == GameChoi2.ROCK)
        {
            infotest2.text = "Lose";
            EnemyScore++;
            EnamyText.text = EnemyScore.ToString();
            if (EnemyScore == 5)
            {
                WeLose();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.LIZARD && opponent_Choice == GameChoi2.SCISSORS)
        {
            infotest2.text = "Lose";
            EnemyScore++;
            EnamyText.text = EnemyScore.ToString();
            if (EnemyScore == 5)
            {
                WeLose();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.SPOCK && opponent_Choice == GameChoi2.PAPER)
        {
            infotest2.text = "Lose";
            EnemyScore++;
            EnamyText.text = EnemyScore.ToString();
            if (EnemyScore == 5)
            {
                WeLose();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.SPOCK && opponent_Choice == GameChoi2.LIZARD)
        {
            infotest2.text = "Lose";
            EnemyScore++;
            EnamyText.text = EnemyScore.ToString();
            if (EnemyScore == 5)
            {
                WeLose();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        //Win
        if (player_Choice == GameChoi2.ROCK && opponent_Choice == GameChoi2.SCISSORS)
        {
            infotest2.text = "Win";
            WeScore++;
            WeText.text = WeScore.ToString();
            if (WeScore == 5)
            {
                WeWin();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.ROCK && opponent_Choice == GameChoi2.LIZARD)
        {
            infotest2.text = "Win";
            WeScore++;
            WeText.text = WeScore.ToString();
            if (WeScore == 5)
            {
                WeWin();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.PAPER && opponent_Choice == GameChoi2.ROCK)
        {
            infotest2.text = "Win";
            WeScore++;
            WeText.text = WeScore.ToString();
            if (WeScore == 5)
            {
                WeWin();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.PAPER && opponent_Choice == GameChoi2.SPOCK)
        {
            infotest2.text = "Win";
            WeScore++;
            WeText.text = WeScore.ToString();
            if (WeScore == 5)
            {
                WeWin();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.SCISSORS && opponent_Choice == GameChoi2.PAPER)
        {
            infotest2.text = "Win";
            WeScore++;
            WeText.text = WeScore.ToString();
            if (WeScore == 5)
            {
                WeWin();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.SCISSORS && opponent_Choice == GameChoi2.LIZARD)
        {
            infotest2.text = "Win";
            WeScore++;
            WeText.text = WeScore.ToString();
            if (WeScore == 5)
            {
                WeWin();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.LIZARD && opponent_Choice == GameChoi2.PAPER)
        {
            infotest2.text = "Win";
            WeScore++;
            WeText.text = WeScore.ToString();
            if (WeScore == 5)
            {
                WeWin();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.LIZARD && opponent_Choice == GameChoi2.SPOCK)
        {
            infotest2.text = "Win";
            WeScore++;
            WeText.text = WeScore.ToString();
            if (WeScore == 5)
            {
                WeWin();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.SPOCK && opponent_Choice == GameChoi2.ROCK)
        {
            infotest2.text = "Win";
            WeScore++;
            WeText.text = WeScore.ToString();
            if (WeScore == 5)
            {
                WeWin();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if (player_Choice == GameChoi2.SPOCK && opponent_Choice == GameChoi2.SCISSORS)
        {
            infotest2.text = "Win";
            WeScore++;
            WeText.text = WeScore.ToString();
            if (WeScore == 5)
            {
                WeWin();
            }
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

    }

    IEnumerator DisplayWinnerAndRestart()
    {
        yield return new WaitForSeconds(1.0f);
        infotest2.gameObject.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        infotest2.gameObject.SetActive(false);

        animationControl.ResetAnimations();

    }

    private void WeWin()
    {
        winMenu.toggleEndMenuWin();
    }

    private void WeLose()
    {
        loseMenu.toggleEndMenuLose();


    }

}
