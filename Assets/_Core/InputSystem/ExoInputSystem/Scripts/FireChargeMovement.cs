using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireChargeMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _destroyTime;

    private void Start()
    {
        StartCoroutine(DestroyObjectInTime(_destroyTime));
    }

    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * _speed;
    }

    IEnumerator DestroyObjectInTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
