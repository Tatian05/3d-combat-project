using System;
using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] int _walkSpeed, _runSpeed;

    PlayerController _controller;
    void Start()
    {
        PlayerView playerView = new (GetComponent<Animator>(), _walkSpeed, _runSpeed);
        PlayerModel playerModel = new (transform, GetComponent<Rigidbody>(), _walkSpeed, _runSpeed);
        _controller = new PlayerController(playerView, playerModel);
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
