using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
     Animator player_animation;
    void Start()
    {
        player_animation = GetComponent<Animator>();
    }
    public void BallAnimationState(int state)
    {
        player_animation.SetInteger("State",state);
    }
  
}
