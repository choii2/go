using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class UnityChanController : MonoBehaviour
{
    public Transform target;
    [SerializeField, HideInInspector] NavMeshAgent agent;
    [SerializeField, HideInInspector] Animator animator;
    [SerializeField, HideInInspector] PhotonView photonView;

    void Start ()
    {
        agent = GetComponent<NavMeshAgent> ();
        animator = GetComponent<Animator> ();
        photonView = GetComponent<PhotonView> ();
    }

    void Update ()
    {
        // 自身の移動
        Move ();
    }
		
    // 自身の移動処理
    void Move ()
    {
        // 自分のオブジェクトではない場合には移動制御をしない
        if (!photonView.isMine) {
            return;
        }

        // 目的地に移動する
        agent.SetDestination (target.position);
        animator.SetFloat ("Speed", agent.velocity.sqrMagnitude);
    }
}
