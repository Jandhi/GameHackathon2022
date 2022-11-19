using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform AttackPoint;
    public float Speed;
    public Animator Animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position - AttackPoint.position).magnitude < 2)
        {
            Animator.ResetTrigger("Run");
            Animator.SetTrigger("Attack");
        }
        else
        {
            Animator.ResetTrigger("Attack");
            Animator.SetTrigger("Run");
            transform.position = Vector3.MoveTowards(transform.position, AttackPoint.position, Speed * Time.deltaTime);
        }
    }
}
