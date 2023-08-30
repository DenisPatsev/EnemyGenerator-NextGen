using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Player _target;

    private void Start()
    {
        SpawnEnemy(transform);
    }

    private void SpawnEnemy(Transform position)
    {
        var enemy = Instantiate(_prefab, position.position, Quaternion.identity);
        enemy.gameObject.AddComponent<TargetFollower>().SetTarget(_target);
    }
}
