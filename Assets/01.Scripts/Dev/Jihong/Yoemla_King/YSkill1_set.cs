using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSkill1_set : MonoBehaviour
{
    float speed = 6;
    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.right) * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}