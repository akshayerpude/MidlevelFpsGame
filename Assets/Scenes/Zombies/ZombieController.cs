using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    Animator anim;
    public GameObject targetPlayer;
    NavMeshAgent enemyAgent;


    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        enemyAgent = GetComponent<NavMeshAgent>();
        anim.SetBool("isWalking", true);
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(targetPlayer.transform.position);
        if (enemyAgent.remainingDistance > enemyAgent.stoppingDistance) 
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isAttacking", false);

        }
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", true);
        }
        //if (Input.GetKey(KeyCode.W))
        //{
        //    anim.SetBool("isWalking", true);
        //}
        //else
        //    anim.SetBool("isWalking", false);

        //if (Input.GetKey(KeyCode.R))
        //{
        //    anim.SetBool("isRunning", true);
        //}
        //else
        //    anim.SetBool("isRunning", false);

        //if (Input.GetKey(KeyCode.A))
        //{
        //    anim.SetBool("isAttacking", true);
        //}
        //else
        //    anim.SetBool("isAttacking", false);

        //if (Input.GetKey(KeyCode.D))
        //{
        //    anim.SetBool("isDead", true);
        //}

    }
}
