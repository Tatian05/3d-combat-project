using System;
using UnityEngine;

public enum PlayerStates { Walking, Running, Blocking, SwordAttack }
public class Player : Entity
{
    [SerializeField] int _walkSpeed, _runSpeed, _blockingSpeed;
    [SerializeField] float _acceleration;

    PlayerController _controller;
    EventFSM<PlayerStates> _playerFSM;
    protected override void Start()
    {
        base.Start();

        PlayerView playerView = new(GetComponent<Animator>());
        PlayerModel playerModel = new(transform, GetComponent<Rigidbody>(), _acceleration);
        _controller = new PlayerController(this);

        #region FSM Configuration

        var walkingState = new State<PlayerStates>("Walking");
        var runningState = new State<PlayerStates>("Running");
        var blockingState = new State<PlayerStates>("Blocking");
        var swordAttackingState = new State<PlayerStates>("SwordAttack");

        StateConfigurer.Create(walkingState).
                        SetTransition(PlayerStates.Running, runningState).
                        SetTransition(PlayerStates.Blocking, blockingState).
                        SetTransition(PlayerStates.SwordAttack, swordAttackingState).
                        Done();

        StateConfigurer.Create(runningState).
                        SetTransition(PlayerStates.Walking, walkingState).
                        SetTransition(PlayerStates.Blocking, blockingState).
                        SetTransition(PlayerStates.SwordAttack, swordAttackingState).
                        Done();

        StateConfigurer.Create(blockingState).
                        SetTransition(PlayerStates.Walking, walkingState).
                        SetTransition(PlayerStates.Running, runningState).
                        SetTransition(PlayerStates.SwordAttack, swordAttackingState).
                        Done();

        StateConfigurer.Create(swordAttackingState).
                        SetTransition(PlayerStates.Walking, walkingState).
                        SetTransition(PlayerStates.Running, runningState).
                        SetTransition(PlayerStates.SwordAttack, swordAttackingState).
                        Done();

        #endregion

        #region Walking

        walkingState.OnEnter += x =>
        {
            playerModel.SetCurrentSpeed(_walkSpeed);
            playerView.SetSpeed(_walkSpeed);
        };

        walkingState.OnUpdate += () => {
            playerModel.MovementUpdate(_controller.X, _controller.Z);
            playerView.OnUpdate(_controller.X, _controller.Z);
        };

        walkingState.OnFixedUpdate += playerModel.MovementFixedUpdate;

        #endregion

        #region Running

        runningState.OnEnter += x =>
        {
            playerModel.SetCurrentSpeed(_runSpeed);
            playerView.SetSpeed(_runSpeed);
        };

        runningState.OnUpdate += () => {
            playerModel.MovementUpdate(_controller.X, _controller.Z);
            playerView.OnUpdate(_controller.X, _controller.Z);
        };

        runningState.OnFixedUpdate += playerModel.MovementFixedUpdate;

        #endregion

        #region Blocking

        blockingState.OnEnter += x =>
        {
            playerModel.SetCurrentSpeed(_blockingSpeed);
            playerModel.Blocking(true);
            playerView.SetSpeed(_blockingSpeed);
            playerView.Blocking(true);
        };

        blockingState.OnUpdate += () => {
            playerModel.MovementUpdate(_controller.X, _controller.Z);
            playerView.OnUpdate(_controller.X, _controller.Z);
        };

        blockingState.OnFixedUpdate += playerModel.MovementFixedUpdate;

        blockingState.OnExit += x =>
        {
            playerModel.Blocking(false);
            playerView.Blocking(false);
        };

        #endregion

        _controller.OnEnable();

        _currentHP = _maxHP;
        _playerFSM = new EventFSM<PlayerStates>(walkingState);
    }
    private void OnDisable()
    {
        _controller.OnDisable();
    }
    void Update()
    {
        _controller?.OnUpdate();
        _playerFSM?.Update();
    }

    private void FixedUpdate()
    {
        _playerFSM?.FixedUpdate();
    }

    public int GetCurrentSpeed(PlayerStates state) => state switch
    {
        PlayerStates.Walking => _walkSpeed,
        PlayerStates.Running => _runSpeed,
        PlayerStates.Blocking => _blockingSpeed,
        _ => throw new NotImplementedException()
    };

    public void SetPlayerState(PlayerStates state)
    {
        _playerFSM.SendInput(state);
    }
}
