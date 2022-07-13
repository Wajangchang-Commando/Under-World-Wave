using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour //�÷��̾ �� HP ��ũ��Ʈ�Դϴ�. 
{
    [SerializeField] private int _maxHP = 10;

    public int nowHP; //public���� �ص����� HP�� 0�϶� ����Ǵ°� ���ֽø� �����ϰڽ��ϴ�. 

    public float MaxHP
    {
        get
        {
            return _maxHP;
        }
    }
    public float CurrentHP
    {
        get
        {
            return nowHP;
        }
    }

    private void Start()
    {
        nowHP = _maxHP;
    }

    public void TalkDamage(int damage)
    {
        nowHP -= damage;
    }
}