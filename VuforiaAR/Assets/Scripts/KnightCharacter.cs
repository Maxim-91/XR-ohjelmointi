using UnityEngine;

public class KnightCharacter : MonoBehaviour
{
    [SerializeField] 
    private GameObject baloon;
    
    public void Throw()
    {
        GameObject newBaloon = GameObject.Instantiate(baloon, gameObject.transform.position, gameObject.transform.rotation);
        newBaloon.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 400f);
        Destroy(newBaloon, 10f);
    }
}