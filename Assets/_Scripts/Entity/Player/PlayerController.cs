using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController
{
    PlayerInputs _playerInput;
    InputAction _movementAction, _runAction;
    Vector2 _movement;
    Action<float, float> _move;
    Action<float, float> _walk;
    Action<float, float> _run;

    #region Constructor

    PlayerModel _playerModel;
    PlayerView _playerView;

    #endregion
    public PlayerController(PlayerModel playerModel, PlayerView playerView)
    {
        _playerInput = new PlayerInputs();
        _movementAction = _playerInput.Player.Movement;
        _runAction = _playerInput.Player.Run;
        _runAction.started += SetRun;
        _runAction.canceled += SetWalk;

        _playerModel = playerModel;
        _playerView = playerView;

        _walk += _playerModel.Walk;
        _walk += _playerView.MovementAnimation;

        _run += _playerModel.Run;
        _run += _playerView.MovementAnimation;

        _move = _walk;
    }

    public void OnEnable()
    {
        _playerInput.Enable();
    }

    public void OnDisable()
    {
        _runAction.performed -= SetRun;
        _runAction.canceled -= SetWalk;
        _playerInput.Disable();
    }

    public void OnUpdate()
    {
        _movement = _movementAction.ReadValue<Vector2>();
    }

    public void OnFixedUpdate()
    {
        _move(_movement.x, _movement.y);
    }

    void SetRun(InputAction.CallbackContext callbackContext)
    {
        Debug.Log("Run");
        _playerView.SetSpeed(_playerModel.CurrentSpeed);
        _move = _run;
    }

    void SetWalk(InputAction.CallbackContext callbackContext)
    {
        Debug.Log("Walk");
        _playerView.SetSpeed(_playerModel.CurrentSpeed);
        _move = _walk;
    }
}
