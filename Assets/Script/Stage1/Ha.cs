using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ha : MonoBehaviour
{
    public int ha = 0;
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
        if (other.gameObject.CompareTag("Ha"))
        {
            // �G�ꂽobj�̐e���ړ����ɂ���
            other.transform.SetParent(transform);
            ha = 1;
            Debug.Log("�u�́v���������z�u���ꂽ��I�I");
        }
        if (other.gameObject.CompareTag("Chi"))
        {
            // �G�ꂽobj�̐e���ړ����ɂ���
            other.transform.SetParent(transform);
            Debug.Log("�s�����I");
        }
        if (other.gameObject.CompareTag("Ya"))
        {
            // �G�ꂽobj�̐e���ړ����ɂ���
            other.transform.SetParent(transform);
            Debug.Log("�s�����I");
        }
    }
}