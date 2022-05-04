using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatorcontbes : MonoBehaviour
{
    [SerializeField]
    private Animator playerChoiceHandlerAnimation2, choiceAnimation2;
    public void ResetAnimations()
    {
        playerChoiceHandlerAnimation2.Play("ShowHanlder");
        choiceAnimation2.Play("RemoveChoices");
    }
    public void PlayerMadeChoice()
    {
        playerChoiceHandlerAnimation2.Play("RemoveHandler");
        choiceAnimation2.Play("ShowChoices");
    }
}
    