using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //�L���[�u�̈ړ����x
    private float speed = -12;

    //���ňʒu
    private float deadLine = -10;

    //AudioSource�R���|�[�l���g (�ǉ�)
    private AudioSource audioSource;

    //Start is called before the first frame update
    void Start()
    {
        //������AudioSource�R���|�[�l���g���擾 (�ǉ�)
        audioSource = GetComponent<AudioSource>();
    }

    //Update is called once per frame
    void Update()
    {
        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //�L���[�u�����̃I�u�W�F�N�g�ƏՓ˂����Ƃ��̏��� (�ǉ�)
    void OnCollisionEnter2D(Collision2D collision)
    {
        //���ʉ����Đ� (�ǉ�)
        audioSource.Play();
    }
}
