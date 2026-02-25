using UnityEngine;

public class HandlerFollow : MonoBehaviour
{
    [SerializeField]
    private Transform grabTransform;

    private Rigidbody rb;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (grabTransform != null)
        {
            rb.MovePosition(grabTransform.transform.position);
            //rb.MoveRotation(grabTransform.rotation);
        }
    }
}
