using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController
{
    PlayerInputs _playerInput;
    readonly InputAction _movementAction, _runStart, _runEnd, _blockStart, _blockEnd, _swordStart, _swordEnd;
    Vector2 _movement;

    public float X => _movement.x;
    public float Z => _movement.y;

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
        _swordStart = _playerInput.Player.SwordStart;
        _swordEnd = _playerInput.Player.SwordEnd;

        _runStart.performed += x => _player.SetPlayerState(PlayerStates.Running);
        _runEnd.performed += x => _player.SetPlayerState(PlayerStates.Walking);

        _blockStart.performed += x => _player.SetPlayerState(PlayerStates.Blocking);
        _blockEnd.performed += x => _player.SetPlayerState(PlayerStates.Walking);
    }

    public void OnEnable()
    {
        _playerInput.Enable();
    }

    public void OnDisable()
    {
        _runStart.performed -= x => _player.SetPlayerState(PlayerStates.Running);
        _runEnd.performed -= x => _player.SetPlayerState(PlayerStates.Walking);

        _blockStart.performed -= x => _player.SetPlayerState(PlayerStates.Blocking);
        _blockEnd.performed -= x => _player.SetPlayerState(PlayerStates.Walking);

        _playerInput.Disable();
    }

    public void OnUpdate()
    {
        _movement = _movementAction.ReadValue<Vector2>();
    }
}
