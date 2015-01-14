using UnityEngine;
using System.Collections;

public class DelegateSample3 : MonoBehaviour {

    /*
     * デフォルトでprivate
     */
    // イベント処理用のデリゲート
    public delegate void TapEventHandler3(string message);

    // EventなしのTapEventHandler
    public event TapEventHandler3 tapHandlerA;
    public event TapEventHandler3 tapHandlerB;

    public void OnTapA () {
        tapHandlerA("DelegateSample3.OnTapA");
    }

    public void OnTapB () {
        tapHandlerB("DelegateSample3.OnTapB");
    }
}

