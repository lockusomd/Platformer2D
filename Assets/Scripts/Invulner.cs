using System.Collections;
using UnityEngine;

public class Invulner : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    public bool IsInvulnerability { get; private set; }

    private IEnumerator Invulnerability()
    {
        int blinkTimes = 5;
        float oneBlink = 0.4f;

        IsInvulnerability = true;

        for (int i = 0; i < blinkTimes; i++)
        {
            _renderer.enabled = false;

            yield return new WaitForSeconds(oneBlink / 2);

            _renderer.enabled = true;

            yield return new WaitForSeconds(oneBlink / 2);
        }

        IsInvulnerability = false;
    }

    public void EnableInvulnerability()
    {
        StartCoroutine(Invulnerability());
    }
}
