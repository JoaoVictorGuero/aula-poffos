using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) Atirar();
        if (tempoCooldownAtual > 0) tempoCooldownAtual -= Time.deltaTime;
    }


    [SerializeField] private float tempoCooldown =3;
    [SerializeField] private float tempoCooldownAtual;
    private void Atirar()
    {
        if (tempoCooldownAtual > 0) return;
        
        Instantiate(projectilePrefab);
        tempoCooldownAtual = tempoCooldown;
    }
}
