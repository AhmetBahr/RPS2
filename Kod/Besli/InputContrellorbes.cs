using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputContrellorbes : MonoBehaviour
{

    private Animatorcontbes animationController;
    private GamePlayControllerBes gameplayController;
    private string playersChoice;
    void Awake()
    {
        animationController = GetComponent<Animatorcontbes>();
        gameplayController = GetComponent<GamePlayControllerBes>();


    }

    public void GetChoice()
    {
        string choiceName = UnityEngine.EventSystems.
            EventSystem.current.currentSelectedGameObject.name;



        GameChoi2 selectedChoice = GameChoi2.NONE;

        switch (choiceName)
        {
            case "Rock":
                selectedChoice = GameChoi2.ROCK;
                break;
            case "Paper":
                selectedChoice = GameChoi2.PAPER;
                break;
            case "Scissors":
                selectedChoice = GameChoi2.SCISSORS;
                break;
            case "Lizard":
                selectedChoice = GameChoi2.LIZARD;
                break;
            case "Spock":
                selectedChoice = GameChoi2.SPOCK;
                break;
        }
        gameplayController.SetChoices(selectedChoice);
        animationController.PlayerMadeChoice();

    }
}
