using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombiePatrol : StateMachineBehaviour
{
    public float speed = 1.0f;
    public float spotDistance = 5.0f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       var agent = animator.GetComponent<NavMeshAgent>();

       if (Random.value < 0.01f) {
            var randomPosition = Random.insideUnitCircle * 10.0f;
            agent.destination = animator.transform.position + new Vector3(
                randomPosition.x,
                animator.transform.position.y,
                randomPosition.y);
       }

       var player = GameObject.FindWithTag("Player");
       var distToPlayer = (player.transform.position - animator.transform.position).magnitude;
       if (distToPlayer < this.spotDistance) {
            animator.SetTrigger("SpotPlayer");
       }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.ResetTrigger("SpotPlayer");
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
