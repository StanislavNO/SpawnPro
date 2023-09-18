using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Persecutor _prefab;
    [SerializeField] private Target _target;

    public void CreatePrefab()
    {
        Persecutor enemy = Instantiate(
            _prefab, 
            transform.position, 
            Quaternion.identity);

        enemy.SetTarget(_target);
    }
}
