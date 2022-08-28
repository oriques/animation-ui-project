using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartGame : MonoBehaviour
{
    public ParticleSystem particleSystems;
    public void Onclick()
    {
        particleSystems.Play();
    }
}
