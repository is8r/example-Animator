using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lama : MonoBehaviour
{

    //アニメーターのコンポーネントを入れる変数を宣言する
    Animator animator;

    void Start()
    {
        //アニメーターのコンポーネントを取得する
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        //ボタンの操作を検知したら
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            //アニメーターのトリガーに引数を渡す
            animator.SetTrigger("Up");
        }

        //その他の方向も同様に設定する
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetTrigger("Right");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetTrigger("Down");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetTrigger("Left");
        }
    }
}
