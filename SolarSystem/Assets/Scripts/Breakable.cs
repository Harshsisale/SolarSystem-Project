using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
public GameObject explosion; // drag your explosion prefab here

void OnCollisionEnter(){
    Destroy(gameObject); // destroy the grenade
}
}
