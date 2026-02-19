using UnityEngine;

public class ScreenTracking : MonoBehaviour
{
    [SerializeField] 
    private KnightCharacter character;

     void Start()
    {
        //InvokeRepeating("CallThrow", 0f, 3f);        
    }
    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                character.Throw();
            }   
            
        }
    }   

    //void CallThrow()
    //{
        //character.Throw();
    //}
}
