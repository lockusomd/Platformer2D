using System.Collections;
using UnityEngine;

public class Blinker : MonoBehaviour
{
    [SerializeField] private Invulner _invulner;
    [SerializeField] private Renderer _renderer;
    [SerializeField] private float _oneBlinkDuration = 0.4f;

    private bool _isBlink = false;

    private void Update()
    {
        if (_invulner.IsInvulnerability && _isBlink == false)
        {
            _isBlink = true;

            StartCoroutine(Blink(_invulner.Duration));
        }
    }

    private IEnumerator Blink(float wholeTime)
    {
        for(int i = 0; i < wholeTime/_oneBlinkDuration; i++)
        {
            _renderer.enabled = false;

            yield return new WaitForSeconds(_oneBlinkDuration / 2);

            _renderer.enabled = true;

            yield return new WaitForSeconds(_oneBlinkDuration / 2);
        }

        _isBlink = false;
    }
}
