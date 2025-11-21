using UnityEngine;
using UnityEngine.InputSystem;

public class AnimMove : MonoBehaviour
{
    public InputActionAsset heMovin;
    public Animator StillMoving;


    
    // Update is called once per frame
    void Update()
    {
        if (heMovin.FindAction("movemen").IsPressed())
        {
            StillMoving.SetBool("Run", true);
        }
        else
            StillMoving.SetBool("Run", false);
 
    }
}