using Unity.VisualScripting;
using UnityEngine;

public class CoolorChanging : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private void OnCollisionEnter(Collision collision)
{
    Debug.Log("Collision detected");
    GetComponent<MeshRenderer>().material.color = Color.red;
}
}
