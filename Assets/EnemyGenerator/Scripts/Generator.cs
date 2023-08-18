using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private Enemy _generatedObject;
    [SerializeField] private Player _target;

    private void Start()
    {
        GenerateEnemy(gameObject);
    }

    private void GenerateEnemy(GameObject gameObject)
    {
        var enemy = Instantiate(_generatedObject, gameObject.transform.position, Quaternion.identity);
        enemy.gameObject.AddComponent<MotionToTarget>();
        enemy.GetComponent<MotionToTarget>().target = _target;
    }
}
