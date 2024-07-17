using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    //AudioSourceコンポーネント (追加)
    private AudioSource audioSource;

    //Start is called before the first frame update
    void Start()
    {
        //既存のAudioSourceコンポーネントを取得 (追加)
        audioSource = GetComponent<AudioSource>();
    }

    //Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //キューブが他のオブジェクトと衝突したときの処理 (追加)
    void OnCollisionEnter2D(Collision2D collision)
    {
        //効果音を再生 (追加)
        audioSource.Play();
    }
}
