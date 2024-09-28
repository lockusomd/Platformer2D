using System.Collections;
using UnityEngine;

public class Invulner : MonoBehaviour
{
    [SerializeField] private float _duration = 5f;

    public float Duration => _duration;

    private WaitForSeconds _wait;

    public bool IsInvulnerability { get; private set; }

    private void Start()
    {
        _wait = new WaitForSeconds(_duration);
    }

    private IEnumerator Invulnerability()
    {
        IsInvulnerability = true;

        yield return _wait;

        IsInvulnerability = false;
    }

    public void EnableInvulnerability()
    {
        StartCoroutine(Invulnerability());
    }
}