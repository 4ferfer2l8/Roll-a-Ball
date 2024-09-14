using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CamaraController : MonoBehaviour
{
    public GameObject playerCode;
    private Vector3 deslocamento;
    void Start()
    {
        deslocamento = transform.position;
    }
    void Update()
    {
        transform.position = playerCode.transform.position + deslocamento;
    }
}  