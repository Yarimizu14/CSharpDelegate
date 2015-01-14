using UnityEngine;
using System.Collections;

public class HandlerSample2 : MonoBehaviour {

    public DelegateSample2 delegateSample2;

    /*
     * TapEventHandlerがprivateなので定義不可
     */
    //private DelegateSample2.TapEventHandler2 handler2;

    // Use this for initialization
    //
    void Start () {
        /*
         * TapEventHandler2がprivateなので以下、コンパイルエラー
         */
        //delegateSample2.SetTapHandlerA((string message) => { Debug.Log(message); });
        //delegateSample2.tapHandlerA = (string message) => { Debug.Log(message); };
    }

    void ButtonHandler (string message) {
        Debug.Log(message);
    }
}
