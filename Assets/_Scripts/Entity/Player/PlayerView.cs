using UnityEngine;
public class PlayerView
{
    Animator _animator;
    int _walkSpeed, _runSpeed;
    public PlayerView(Animator animator, int walkSpeed, int runSpeed)
    {
        _animator = animator;
        _walkSpeed = walkSpeed;
        _runSpeed = runSpeed;
    }

    public void OnUpdate(float x, float z)
    {
        _animator.SetFloat("x", x, .1f, Time.deltaTime);
        _animator.SetFloat("z", z, .1f, Time.deltaTime);
    }

    public void SetSpeed(bool isRunning)
    {
        _animator.SetInteger("speed", isRunning ? _runSpeed : _walkSpeed);
    }
}
