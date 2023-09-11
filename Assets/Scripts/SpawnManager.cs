using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private int _countEnemy;

    private Spawn[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = new Spawn[transform.childCount];

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _spawnPoints[i] = transform.GetChild(i).GetComponent<Spawn>();
        }

        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        WaitForSecondsRealtime delay = new WaitForSecondsRealtime(_delay);

        for (int i = 0; i <= _countEnemy; i++)
        {
            _spawnPoints[Random.Range(0, _spawnPoints.Length)].CreatePrefab(); 

            yield return delay;
        }
    }
}
