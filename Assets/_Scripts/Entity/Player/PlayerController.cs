using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController
{
    PlayerInputs _playerInput;
    readonly InputAction _movementAction, _runStart, _runEnd, _blockStart, _blockEnd;
    Vector2 _movement;

    #region Constructor

    Player _player;

    #endregion
    public PlayerController(Player player)
    {
        _player = player;

        _playerInput = new PlayerInputs();
        _movementAction = _playerInput.Player.Movement;
        _runStart = _playerInput.Player.RunStart;
        _runEnd = _playerInput.Player.RunEnd;
        _blockStart = _playerInput.Player.BlockStart;
        _blockEnd = _playerInput.Player.BlockEnd;

        _runStart.performed += x => RunAction(true);
        _runEnd.performed += x => RunAction(false);

        _blockStart.performed += x => BlockAction(true);
        _blockEnd.performed += x => BlockAction(false);

        _player.setSpeed(false);
    }

    public void OnEnable()
    {
        _playerInput.Enable();
    }

    public void OnDisable()
    {
        _runStart.performed -= x => RunAction(true);
        _runEnd.canceled -= x => RunAction(false);

        _blockStart.performed -= x => BlockAction(true);
        _blockEnd.performed -= x => BlockAction(false);

        _playerInput.Disable();
    }

    public void OnUpdate()
    {
        _movement = _movementAction.ReadValue<Vector2>();

        _player.OnUpdate(_movement.x, _movement.y);
    }

    public void OnFixedUpdate()
    {
        _player.OnFixedUpdate();
    }

    void BlockAction(bool isBlocking)
    {
        Debug.Log(isBlocking);
        _player.blocking(isBlocking);
    }

    void RunAction(bool isRunning)
    {
        _player.setSpeed(isRunning);
    }
}
