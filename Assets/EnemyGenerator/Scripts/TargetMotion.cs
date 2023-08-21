using UnityEngine;

public class TargetMotion : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _startPointPosition;

    private SpriteRenderer _spriteRenderer;
    private float _distance;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _distance = _startPointPosition.position.x + 5;
    }

    private void Update()
    {
        transform.Translate(Time.deltaTime * _speed, 0, 0);

        if (transform.position.x >= _distance)
        {
            _spriteRenderer.flipX = true;
            _speed *= -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _speed *= -1;

        if (collision.gameObject.TryGetComponent(out StartPoint startPoint))
        {
            _spriteRenderer.flipX = false;
        }
    }
}

