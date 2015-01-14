using UnityEngine;
using System.Collections;
using System;

public class LambdaSample : MonoBehaviour {

    // Use this for initialization
    void Start () {

        // string型の引数1つ、戻り値voidのラムダ式  
        Action<string> lambda1 = (string message) => /* 括弧の中に型を明示しても良い */
        {
            Debug.Log(message);
        };

        lambda1("Test");

         // string型の引数1つを受け取り、int型の戻り値を返すラムダ式
        Func<string, int> lambda2 = (string message) =>
        {
            Debug.Log(message);
            // int型を返す
            return 0;
        };
        lambda2("Test2");

        // string型の引数1つを受け取り、bool型の戻り値を返すラムダ式
        Predicate<string> lambda3 = (string message) =>
        {
            Debug.Log(message);
            // bool型を返す
            return true;
        };
        lambda3("Test3");

    }

    // Update is called once per frame
    void Update () {
    }
}
