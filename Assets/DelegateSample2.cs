using UnityEngine;
using System.Collections;

public class DelegateSample2 : MonoBehaviour {

    // イベント処理用のデリゲート
    /*
     * デフォルトでprivate
     */
    delegate void TapEventHandler2(string message);

    // EventなしのTapEventHandler
    /*
     * TapEventHandler2がprivateなので(？)、publicにするとエラー
     */
    TapEventHandler2 tapHandlerA;
    TapEventHandler2 tapHandlerB;

    public void OnTapA () {
        tapHandlerA("DelegateSample2.OnTapA");
    }

    public void OnTapB () {
        tapHandlerB("DelegateSample2.OnTapB");
    }

    /*
     * TapEventHandler2がprivateなので定義できない
     */
    /*
    public void SetTapHandlerA (TapEventHandler2 h) {
        tapHandlerA = h;
    }
    */
}

