using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Target _target;

    public void CreatePrefab()
    {
        GameObject enemy = Instantiate(
            _prefab.gameObject, 
            transform.position, 
            Quaternion.identity);

        enemy.GetComponent<Persecutor>().SetTarget(_target);
    }
}
