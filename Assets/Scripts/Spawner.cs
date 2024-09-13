using System.Collections;
using UnityEngine;
using UnityEngine.Pool;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Appearer _prefab;

    private ObjectPool<Appearer> _pool;

    private int _defaultCapacity = 5;
    private int _maxSize = 10;
    private WaitForSeconds _waitForSeconds = new WaitForSeconds(5);

    private void Awake()
    {
        _pool = new ObjectPool<Appearer>(
            createFunc: () => Instantiate(_prefab),
            actionOnGet: (appearer) => SetParameters(appearer),
            actionOnRelease: (appearer) => appearer.gameObject.SetActive(false),
            actionOnDestroy: (appearer) => Delete(appearer),
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

    private void SetParameters(Appearer appearer)
    {
        appearer.Died += SendToPool;

        appearer.transform.position = transform.position;

        appearer.gameObject.SetActive(true);
    }

    private void SendToPool(Appearer appearer)
    {
        appearer.Died -= SendToPool;

        _pool.Release(appearer);

        StartCoroutine(GetAppearer());
    }

    private void Delete(Appearer rocket)
    {
        rocket.Died -= SendToPool;

        Destroy(rocket);
    }
}
