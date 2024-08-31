using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Quaternion _right = Quaternion.Euler(0, 0, 0);
    private Quaternion _left = Quaternion.Euler(0, 180, 0);

    public void Rotate(float direction)
    {
        if (direction > 0)
            transform.localRotation = _right;
        else if (direction < 0)
            transform.localRotation = _left;
    }
}
