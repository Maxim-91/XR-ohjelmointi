using UnityEngine;

public class ResetGrab : MonoBehaviour
{
    public void ResetPosition()
    {
        GetComponent<Transform>().transform.localPosition = Vector3.zero;
        GetComponent<Transform>().transform.localRotation = Quaternion.identity;
        GetComponent<Transform>().transform.localScale = Vector3.one;
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
    }
}
