using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    int age = 22;
    float height = 169.9f;
    string myName = "������";
    bool canPlayGuitar = false;

    void Start()
    {
        Debug.Log("���� �̸��� " + myName + "�Դϴ�.");
        Debug.Log("���� ���̴� " + age + "�Դϴ�.");
        Debug.Log("���� Ű�� " + height + "�Դϴ�.");
        Debug.Log("���� ��Ÿ ���� ���δ�  " + canPlayGuitar + "�Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
