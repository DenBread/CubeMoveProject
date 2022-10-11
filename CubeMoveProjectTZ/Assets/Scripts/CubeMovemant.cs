using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeMovemant : MonoBehaviour
{
    [SerializeField] private float _speedCube;
    [SerializeField] private Vector3 _moveToPosition;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.DOMove(_moveToPosition, _speedCube).SetDelay(1f).SetEase(Ease.InCubic).OnStepComplete(()=>
        {
            transform.DOScale(Vector3.zero, 1f).SetEase(Ease.InBounce).OnStepComplete(()=> Destroy(gameObject));
        });
    }
}
