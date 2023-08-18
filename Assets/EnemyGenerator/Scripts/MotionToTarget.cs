using UnityEngine;

public class MotionToTarget : MonoBehaviour
{
    public Player target;

    private SpriteRenderer _enemyRenderer;

    private float _distanceToTarget;

    private void Start()
    {
        _enemyRenderer = GetComponent<SpriteRenderer>();
        _distanceToTarget = target.transform.position.x - transform.position.x;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Time.time * 0.001f);

        if (_distanceToTarget > 0)
        {
            _enemyRenderer.flipX = false;
        }
    }
}
