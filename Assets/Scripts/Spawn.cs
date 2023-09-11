using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform _prefab;
    [SerializeField] private Transform _target;

    public void CreatePrefab()
    {
        GameObject enemy = Instantiate(_prefab.gameObject, transform.position, Quaternion.identity);
        enemy.GetComponent<TargetMovement>().SetTarget(_target);
    }
}
