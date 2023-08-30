using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class TargetMotion : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _path;

    private SpriteRenderer _spriteRenderer;
    private int _collisionCount;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _collisionCount = 0;
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PathPoint>(out PathPoint pathPoint))
        {
            _spriteRenderer.flipX = true;
            _collisionCount++;
            _speed *= -1;

            if (_collisionCount % 2 == 0)
            {
                _spriteRenderer.flipX = false;
            }
        }
    }
}

