using System;
using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] int _walkSpeed, _runSpeed;

    PlayerController _controller;

    public Action<bool> setSpeed, blocking;
    public Action<float, float> OnUpdate;
    public Action OnFixedUpdate;
    void Start()
    {
        PlayerView playerView = new (GetComponent<Animator>(), _walkSpeed, _runSpeed);
        PlayerModel playerModel = new (transform, GetComponent<Rigidbody>(), _walkSpeed, _runSpeed);

        setSpeed = playerView.SetSpeed;
        setSpeed += playerModel.SetCurrentSpeed;

        blocking += playerView.Block;
        blocking += playerModel.Block;

        OnUpdate = playerModel.OnUpdate;
        OnUpdate += playerView.OnUpdate;

        OnFixedUpdate += playerModel.OnFixedUpdate;

        _controller = new PlayerController(this);
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
