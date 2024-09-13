using System.Collections;
using UnityEngine;

public class Invulner : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    private bool _isInvulnerability = false;

    public bool IsInvulnerability => _isInvulnerability;

    private IEnumerator Invulnerability()
    {
        int blinkTimes = 5;
        float oneBlink = 0.4f;

        _isInvulnerability = true;

        for (int i = 0; i < blinkTimes; i++)
        {
            _renderer.enabled = false;

            yield return new WaitForSeconds(oneBlink / 2);

            _renderer.enabled = true;

            yield return new WaitForSeconds(oneBlink / 2);
        }

        _isInvulnerability = false;
    }

    public void EnableInvulnerability()
    {
        StartCoroutine(Invulnerability());
    }
}
