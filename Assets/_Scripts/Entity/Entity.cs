using UnityEngine;
public abstract class Entity : MonoBehaviour, IDamageable
{
    [SerializeField] protected float _currentHP, _maxHP;
    protected virtual void Start()
    {
        _currentHP = _maxHP;
    }
    public void TakeDamage(float damage)
    {
        _currentHP -= damage;

        if (_currentHP <= 0) Die();
    }

    public void Die()
    {
        Debug.Log("Die");
    }
}
