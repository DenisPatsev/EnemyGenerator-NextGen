using UnityEngine;

[RequireComponent (typeof (SpriteRenderer))]

public class TargetFollower : MonoBehaviour
{
    private Player _enemyTarget;

    private SpriteRenderer _enemyRenderer;

    private float _distanceToTarget;

    private void Start()
    {
        _enemyRenderer = GetComponent<SpriteRenderer>();
        _distanceToTarget = _enemyTarget.transform.position.x - transform.position.x;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _enemyTarget.transform.position, Time.deltaTime);

        if (_distanceToTarget > 0)
        {
            _enemyRenderer.flipX = false;
        }
    }

    public void SetTarget(Player target)
    {
        _enemyTarget = target;
    }
}
