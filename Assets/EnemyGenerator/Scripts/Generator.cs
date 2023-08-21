using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private Enemy _generatedObject;
    [SerializeField] private Player _target;

    private void Start()
    {
        CreateEnemy(gameObject);
    }

    private void CreateEnemy(GameObject gameObject)
    {
        var enemy = Instantiate(_generatedObject, gameObject.transform.position, Quaternion.identity);
        enemy.gameObject.AddComponent<TargetFollower>().SetTarget(_target);
    }
}
