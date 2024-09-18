using System.Collections;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform[] _aidPoints;

    private void Awake()
    {
        StartCoroutine(ChangePosition());
    }

    private IEnumerator ChangePosition()
    {
        bool isWork = true;
        WaitForSeconds delay = new WaitForSeconds(5);

        while (isWork)
        {
            Teleport();

            yield return delay;
        }
    }

    private void Teleport()
    {
        transform.position = _aidPoints[Random.Range(0, _aidPoints.Length)].position;
    }
}
