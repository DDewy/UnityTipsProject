using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomEditor : MonoBehaviour {
    [SerializeField] private float PlayerHealth;
	
	public void LogPlayerHealth()
    {
        Debug.Log("Player's Health is: " + PlayerHealth);
    }
}
