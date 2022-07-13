using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] SpriteRenderer SPR;
    [SerializeField]Vector3 point;
    [SerializeField] private float angle;
    [SerializeField] private Transform firepos;
    void Update()
    {
        Gunturn();
        Shooting();
    }
    
    void Shooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Poolable obj = PoolManager.Instance.Summon("Bullet");
            obj.GetComponent<Bullet>().dir = (point - transform.position).normalized;
            obj.transform.rotation = transform.rotation;
            obj.transform.position = firepos.position;
        }
    }

    void Gunturn()
    {
        point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z +10));
        
        Vector3 Rot = point - transform.position;

        if (Rot.x < 0)
        {
            SPR.flipY = true;
        }
        else
        {
            SPR.flipY = false;
        }
        Rot.Normalize();
         angle = Mathf.Atan2(Rot.y, Rot.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}