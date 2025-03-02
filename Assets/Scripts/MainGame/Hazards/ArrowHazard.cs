using System;
using UnityEngine;

public class ArrowHazard : MonoBehaviour
{
    public GameObject arrowPrefab;
    [SerializeField] float shootInterval;
    private float shootIntervalLeft;
    private GameObject instatiatedArrow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootIntervalLeft = shootInterval;
    }

    // Update is called once per frame
    void Update()
    {
        shootIntervalLeft -= Time.deltaTime;
        if (shootIntervalLeft <= 0)
        {
            instatiatedArrow = Instantiate(arrowPrefab,transform.position,Quaternion.identity);
            instatiatedArrow.transform.Rotate(0,180,0);
            shootIntervalLeft = shootInterval;
        }
    }
}
