using UnityEngine;

public class TargetMotion : MonoBehaviour
{
    [SerializeField] private float _speed;

    private SpriteRenderer _targetSpriteRenderer;

    private void Start()
    {
        _targetSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
            transform.Translate(Time.deltaTime * _speed, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _speed *= -1;

        if (collision.gameObject.TryGetComponent(out StartPoint startPoint))
        {
            _targetSpriteRenderer.flipX = false;
        }
        else if (collision.gameObject.TryGetComponent(out EndPoint endPoint))
        {
            _targetSpriteRenderer.flipX = true;
        }
    }
}

