using UnityEngine;

public class FlipTransformBehaviour : MonoBehaviour
{
    // assigns keys to movement
    public KeyCode key1 = KeyCode.RightArrow, key2 = KeyCode.LeftArrow;
    public float direction1 = 190, direction2 = 0;

    private void Update()
    {
        // tells character to move when key is pressed
        if (Input.GetKeyDown(key1))
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);
        }

        if (!Input.GetKeyDown(key2)) return;
        transform.rotation = Quaternion.Euler(0, direction2, 0);
    }
}
