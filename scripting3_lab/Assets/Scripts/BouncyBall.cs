using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    // declares how high to bounce
    public float bounceForce = 3f;
   
    private void OnCollisionEnter(Collision collision)
    {
        // detects and then bounces off object
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
    }
}