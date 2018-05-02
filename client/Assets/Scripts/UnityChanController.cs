using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class UnityChanController : MonoBehaviour {
    public Transform target;
    [SerializeField, HideInInspector] NavMeshAgent agent;
    [SerializeField, HideInInspector] Animator animator;

    void Start () {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update () {
        agent.SetDestination(target.position);
        animator.SetFloat("Speed", agent.velocity.sqrMagnitude);
    }
}
