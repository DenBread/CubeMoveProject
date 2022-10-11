using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _timeSpawn;
    [SerializeField] private Transform _prefabCube;

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    
    private IEnumerator Spawn()
    {
        while (true)
        {
            Transform gm = Instantiate(_prefabCube, transform.parent);
            yield return new WaitForSeconds(_timeSpawn);
        }
    }
}

