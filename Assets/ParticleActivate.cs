using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class ParticleActivate : MonoBehaviour
{
   public GameObject particleGameObject;
    bool isActive;
    ParticleSystem ps;

    private void Start()
    {
        ps = particleGameObject.GetComponent<ParticleSystem>();
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        //Debug.Log("OnFire.");
        //isActive = isActive;


        ps.startColor = GetRandomColor();
        particleGameObject.SetActive(!isActive);
    }


    public Color GetRandomColor()
    {
        return new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
    }
}
