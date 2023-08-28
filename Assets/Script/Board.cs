using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Board : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���W���擾
        Transform myTransform = this.transform;

        //���W�̕ύX
        if (Input.GetKeyUp(KeyCode.A))
        {
            Vector3 pos = myTransform.position;
            pos.x -= 2f;
            myTransform.position = pos;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Vector3 pos = myTransform.position;
            pos.x += 2f;
            myTransform.position = pos;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Chi"))
        {
            // �G�ꂽobj�̐e���ړ����ɂ���
            other.transform.SetParent(transform);
        }
        if (other.gameObject.CompareTag("Ha"))
        {
            // �G�ꂽobj�̐e���ړ����ɂ���
            other.transform.SetParent(transform);
        }
        if (other.gameObject.CompareTag("Ya"))
        {
            // �G�ꂽobj�̐e���ړ����ɂ���
            other.transform.SetParent(transform);
        }
    }
}