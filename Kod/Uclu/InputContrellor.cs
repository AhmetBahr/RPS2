using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InputContrellor : MonoBehaviour
{
    private AnimatorConttrol animationController;
    private GamePlayContraller gameplayController;
    private string playersChoice;
    void Awake()
    {
        animationController = GetComponent<AnimatorConttrol>();
        gameplayController = GetComponent<GamePlayContraller>();


    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");

    }
    public void PalyAgain()
    {
        SceneManager.LoadScene("Uclu");

    }

    public void GetChoice()
    {
        string choiceName = UnityEngine.EventSystems.
            EventSystem.current.currentSelectedGameObject.name;

       

        GameChoi selectedChoice = GameChoi.NONE;

        switch (choiceName)
        {
            case "Rock":
                selectedChoice = GameChoi.ROCK;
                break;
            case "Paper":
                selectedChoice = GameChoi.PAPER;
                break;
            case "Scissors":
                selectedChoice = GameChoi.SCISSORS;
                break;
        }
        gameplayController.SetChoices(selectedChoice);
        animationController.PlayerMadeChoice();

    }
}
