using System.Collections;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] private UserInput _userInput;
    [SerializeField] private GroundDetector _groundDetector;
    [SerializeField] private Damager _damager;

    private WaitForSeconds _duration = new WaitForSeconds(1);

    private bool _isAttack = false;

    private void Update()
    {
        if (_userInput.IsAttack && _groundDetector.IsGround)
            _isAttack = true;
    }

    private void FixedUpdate()
    {
        if (_isAttack)
        {
            EnableAttack();

            _isAttack = false;
        }
    }

    private IEnumerator Attack()
    {
        _damager.gameObject.SetActive(false);
        _damager.gameObject.SetActive(true);

        yield return _duration;

        _damager.gameObject.SetActive(false);
    }

    public void EnableAttack()
    {
        StartCoroutine(Attack());
    }
}
