using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator menuAnimation;
    public void ResetAnimations()
    {
        menuAnimation.Play("Gel");
    }
    public void PlayerMadeChoice()
    {
        menuAnimation.Play("Git");
    }
}
