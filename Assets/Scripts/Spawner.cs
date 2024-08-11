using System.Collections;
using UnityEngine;
using UnityEngine.Pool;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Rocket _prefab;

    private ObjectPool<Rocket> _pool;

    private int _rocketsQuantity = 0;
    private int _defaultCapacity = 5;
    private int _maxSize = 10;
    private int _repeatRate = 5;

    private void Awake()
    {
        _pool = new ObjectPool<Rocket>(
        createFunc: () => Instantiate(_prefab),
        actionOnGet: (rocket) => SetParameters(rocket),
        actionOnRelease: (rocket) => rocket.gameObject.SetActive(false),
        actionOnDestroy: (rocket) => Delete(rocket),
        collectionCheck: true,
        defaultCapacity: _defaultCapacity,
        maxSize: _maxSize);
    }

    private void Start()
    {
        _pool.Get();

        _rocketsQuantity++;
    }

    private void Update()
    {
        if (_rocketsQuantity == 0)
        {
            StartCoroutine(GetRocket());
            _rocketsQuantity++;
        }
    }

    private IEnumerator GetRocket()
    {
        var wait = new WaitForSeconds(_repeatRate);

        yield return wait;

        _pool.Get();
    }

    private void SetParameters(Rocket rocket)
    {
        rocket.Died += SendToPool;

        rocket.transform.position = transform.position;

        rocket.gameObject.SetActive(true);
    }

    private void SendToPool(Rocket rocket)
    {
        _pool.Release(rocket);

        _rocketsQuantity--;
    }

    private void Delete(Rocket rocket)
    {
        rocket.Died -= SendToPool;

        Destroy(rocket);
    }
}
