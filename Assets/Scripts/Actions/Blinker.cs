using System.Collections;
using UnityEngine;

public class Blinker : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private float _oneBlinkDuration = 0.4f;

    public void StartBlink(float seconds)
    {
        StartCoroutine(Blink(seconds));
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
    }
}
