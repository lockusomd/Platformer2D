using System.Collections;
using UnityEngine;

public class Invulner : MonoBehaviour
{
    [SerializeField] private Blinker _blinker;
    [SerializeField] private float _duration = 5f;

    private WaitForSeconds _wait;

    public bool IsInvulnerability { get; private set; }

    private void Start()
    {
        _wait = new WaitForSeconds(_duration);
    }

    private IEnumerator Invulnerability()
    {
        IsInvulnerability = true;

        _blinker.StartBlink(_duration);

        yield return _wait;

        IsInvulnerability = false;
    }

    public void EnableInvulnerability()
    {
        StartCoroutine(Invulnerability());
    }
}