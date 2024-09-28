using System.Collections;
using UnityEngine;
using UnityEngine.Pool;

public class Spawner : MonoBehaviour
{
    [SerializeField] private PickupItem _prefab;
    [SerializeField] private Transform[] _spawnPoints;

    private ObjectPool<PickupItem> _pool;

    private int _defaultCapacity = 5;
    private int _maxSize = 10;
    private WaitForSeconds _waitForSeconds = new WaitForSeconds(5);

    private void Awake()
    {
        _pool = new ObjectPool<PickupItem>(
            createFunc: () => Instantiate(_prefab),
            actionOnGet: (item) => SetParameters(item),
            actionOnRelease: (item) => item.gameObject.SetActive(false),
            actionOnDestroy: (item) => Delete(item),
            collectionCheck: true,
            defaultCapacity: _defaultCapacity,
            maxSize: _maxSize);
    }

    private void Start()
    {
        _pool.Get();
    }

    private IEnumerator GetAppearer()
    {
        yield return _waitForSeconds;

        _pool.Get();
    }

    private void SetParameters(PickupItem item)
    {
        item.Died += SendToPool;

        item.transform.position = _spawnPoints[Random.Range(0,_spawnPoints.Length)].position;

        item.gameObject.SetActive(true);
    }

    private void SendToPool(PickupItem item)
    {
        item.Died -= SendToPool;

        _pool.Release(item);

        StartCoroutine(GetAppearer());
    }

    private void Delete(PickupItem item)
    {
        item.Died -= SendToPool;

        Destroy(item.gameObject);
    }
}
