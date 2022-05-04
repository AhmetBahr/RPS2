using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorConttrol : MonoBehaviour
{
    [SerializeField]
    private Animator playerChoiceHandlerAnimation, choiceAnimation;
    public void ResetAnimations()
    {
        playerChoiceHandlerAnimation.Play("ShowHanlder");
        choiceAnimation.Play("RemoveChoices");
    }
    public void PlayerMadeChoice()
    {
        playerChoiceHandlerAnimation.Play("RemoveHandler");
        choiceAnimation.Play("ShowChoices");
    }
}
