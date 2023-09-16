using UnityEngine;

public class Persecutor : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Target _target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            _target.transform.position,
            _speed * Time.deltaTime);
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }
}
