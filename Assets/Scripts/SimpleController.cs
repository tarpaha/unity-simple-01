using UnityEngine;

public class SimpleController : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.anyKey)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-2.0f * Physics.gravity);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnCollisionStay(Collision other)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    
    private void OnCollisionExit(Collision other)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}