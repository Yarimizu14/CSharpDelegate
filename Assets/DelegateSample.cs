using UnityEngine;
using System.Collections;

public class DelegateSample : MonoBehaviour {

    // イベント処理用のデリゲート
    public delegate void TapEventHandler(string message);

    // EventなしのTapEventHandler
    /*
     * TapEventHandlerがprivateではないのでエラーにならない
     */
    public TapEventHandler tapHandlerA;
    public TapEventHandler tapHandlerB;

    public void OnTapA () {
        tapHandlerA("DelegateSample.OnTapA");
    }

    public void OnTapB () {
        tapHandlerB("DelegateSample.OnTapB");
    }
}
