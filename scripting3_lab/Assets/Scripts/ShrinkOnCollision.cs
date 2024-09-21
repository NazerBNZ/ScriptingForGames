using UnityEngine;

public class ShrinkOnCollision : MonoBehaviour
{
    public float shrinkFactor = 0.9f;
   
    void OnCollisionEnter(Collision collision)
    {
        // scale object down when it hits something
        transform.localScale *= shrinkFactor;
    }
}