using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CamerSwitcher : MonoBehaviour
{
    [SerializeField] private CinemachineFreeLook thridCam;
    [SerializeField] private CinemachineVirtualCamera firstperson;
    private bool _isfirstperson = false;
    
    // void Start()
    // {
    //     // Устанавливаем приоритет начальной камеры
    //     thridCam.Priority = 10;
    //     firstperson.Priority = 5;
    // }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _isfirstperson = !_isfirstperson;
            firstperson.gameObject.SetActive(_isfirstperson);
            thridCam.gameObject.SetActive(!_isfirstperson);
        }
    }
    
}
