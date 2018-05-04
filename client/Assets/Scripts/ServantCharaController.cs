using UnityEngine;
using UnityEngine.AI;

public class ServantCharaController : MonoBehaviour
{
    public Transform Target;
    private  NavMeshAgent _agent;
    private Animator _animator;
    private PhotonView _photonView;

    private void Start ()
    {
        _agent = GetComponent<NavMeshAgent> ();
        _animator = GetComponent<Animator> ();
        _photonView = GetComponent<PhotonView> ();
    }

    private void Update ()
    {
        // 自身の移動
        Move ();
    }
		
    // 自身の移動処理
    private void Move ()
    {
        // 自分のオブジェクトではない場合には移動制御をしない
        if (_photonView && !_photonView.isMine) {
            return;
        }

        // 目的地に移動する
        _agent.SetDestination (Target.position);
        _animator.SetFloat ("Speed", _agent.velocity.sqrMagnitude);
    }
}
