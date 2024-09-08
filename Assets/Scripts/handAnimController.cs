using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class handAnimController : MonoBehaviour
{

    public InputActionProperty pinchAnim;
    public InputActionProperty fistAnim;

    public Animator handAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pinchValue = pinchAnim.action.ReadValue<float>();
    }
}
