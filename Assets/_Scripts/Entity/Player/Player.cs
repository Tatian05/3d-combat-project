using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] int _walkSpeed, _runSpeed;

    PlayerController _controller;
    void Start()
    {
        _controller = new PlayerController(new PlayerModel(GetComponent<Rigidbody>(), _walkSpeed, _runSpeed), new PlayerView(GetComponent<Animator>()));
        _controller.OnEnable();
    }
    private void OnDisable()
    {
        _controller.OnDisable();
    }
    void Update()
    {
        _controller?.OnUpdate();
    }

    private void FixedUpdate()
    {
        _controller?.OnFixedUpdate();
    }
}
