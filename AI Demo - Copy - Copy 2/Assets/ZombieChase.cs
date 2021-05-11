using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieChase : StateMachineBehaviour
{
    public float speed = 5.0f;
    public float losePlayerDistance = 25.0f;
    public float attackDistance = 5.0f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var player = GameObject.FindWithTag("Player");
        var agent = animator.GetComponent<NavMeshAgent>();

        agent.destination = player.transform.position;

        var distToPlayer = (player.transform.position - animator.transform.position).magnitude;
        if (distToPlayer > this.losePlayerDistance) {
            animator.SetTrigger("LosePlayer");
        } else if (distToPlayer < this.attackDistance) {
            animator.SetTrigger("NearPlayer");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.ResetTrigger("LosePlayer");
       animator.ResetTrigger("NearPlayer");
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
