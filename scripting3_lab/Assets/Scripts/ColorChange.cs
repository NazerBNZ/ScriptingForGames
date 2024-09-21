using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color newColor = Color.blue;
   
    void OnCollisionEnter(Collision collision)
    {
        // changes color after collision
        GetComponent<Renderer>().material.color = newColor;
    }
}