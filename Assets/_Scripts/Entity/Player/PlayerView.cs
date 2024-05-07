using UnityEngine;
public class PlayerView
{
    Animator _animator;
    public PlayerView(Animator animator)
    {
        _animator = animator;
    }

    public void OnUpdate(float x, float z)
    {
        _animator.SetFloat("x", x, .1f, Time.deltaTime);
        _animator.SetFloat("z", z, .1f, Time.deltaTime);
    }

    public void SetSpeed(int speed)
    {
        _animator.SetInteger("speed", speed);
    }

    public void Blocking(bool isBlocking)
    {
        _animator.SetBool("defense", isBlocking);
    }

    public void Sword()
    {
        _animator.SetTrigger("Sword");
    }
}
