using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGMaker.Codebase.Runtime.Common;
using RPGMaker.Codebase.Runtime.Common.Enum;
using UnityEngine.InputSystem;

public class InputDecide : MonoBehaviour
{

    InputSystemState _PlayerInputState;

    // Start is called before the first frame update
    void Start() {
        GameObject _PlayerInputObj = GameObject.Find("InputSystem");

        InputSystemState _PlayerInputState = _PlayerInputObj.GetComponent<InputSystemState>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown() {
        Debug.Log("HIT");
        InputAction.CallbackContext context = new InputAction.CallbackContext();
        /*
        _move = context.ReadValue<Vector2>();

        context.
        _PlayerInputState.OnMove(context);
        InputHandler.Handle(HandleType.Up);
        */
    }
}
