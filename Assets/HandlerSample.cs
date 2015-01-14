using UnityEngine;
using System.Collections;

public class HandlerSample : MonoBehaviour {

    public DelegateSample delegateSample;

    /*
     * TapEventHandlerがpublicなので定義可能
     */
    private DelegateSample.TapEventHandler handler;

    // Use this for initialization
    //
    void Start () {
        /*
         * ラムダ式で設定可能
         */
        delegateSample.tapHandlerA = (string message) => { Debug.Log(message); };

        /*
         * 関数でも大丈夫
         */
        delegateSample.tapHandlerB = ButtonHandler;
    }

    // Update is called once per frame
    void Update () {
    }

    void ButtonHandler (string message) {
        Debug.Log(message);
    }
}
