using UnityEngine;
using System.Collections;

public class HandlerSample3 : MonoBehaviour {

    public DelegateSample3 delegateSample3;

    // Use this for initialization
    //
    void Start () {
        /*
         * クリックすると両方呼ばれます
         * '='は使わず'+='または'-='を使う
         */
        delegateSample3.tapHandlerA += (string message) => { Debug.Log("----- lambda"); Debug.Log(message); };
        delegateSample3.tapHandlerA += ButtonHandler;
    }

    void ButtonHandler (string message) {
        Debug.Log("----- method");
        Debug.Log(message);

        /*
         * 一度クリックした後は、ラムダ式の方のみ呼ばれます
         */
        delegateSample3.tapHandlerA -= ButtonHandler;
    }
}
