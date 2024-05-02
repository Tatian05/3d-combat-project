using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController
{
    PlayerInputs _playerInput;
    InputAction _movementAction, _runStartAction, _runEndAction;
    Vector2 _movement;
    Action<bool> _setSpeed;

    #region Constructor

    PlayerModel _playerModel;
    PlayerView _playerView;

    #endregion
    public PlayerController(PlayerView playerView, PlayerModel playerModel)
    {
        _playerModel = playerModel;
        _playerView = playerView;

        _playerInput = new PlayerInputs();
        _movementAction = _playerInput.Player.Movement;
        _runStartAction = _playerInput.Player.RunStart;
        _runEndAction = _playerInput.Player.RunEnd;
        _runStartAction.performed += RunStart;
        _runEndAction.performed += RunEnd;

        _setSpeed += _playerView.SetSpeed;
        _setSpeed += _playerModel.SetCurrentSpeed;

        _setSpeed(false);
    }

    public void OnEnable()
    {
        _playerInput.Enable();
    }

    public void OnDisable()
    {
        _runStartAction.performed -= RunStart;
        _runEndAction.canceled -= RunEnd;
        _playerInput.Disable();
    }

    public void OnUpdate()
    {
        _movement = _movementAction.ReadValue<Vector2>();

        _playerModel.OnUpdate(_movement.x, _movement.y);
        _playerView.OnUpdate(_movement.x, _movement.y);
    }

    public void OnFixedUpdate()
    {
        _playerModel.OnFixedUpdate();
    }

    void RunStart(InputAction.CallbackContext callbackContext)
    {
        _setSpeed(true);
    }

    void RunEnd(InputAction.CallbackContext callbackContext)
    {
        _setSpeed(false);
    }
}
