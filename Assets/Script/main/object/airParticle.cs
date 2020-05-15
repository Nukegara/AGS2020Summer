using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airParticle : MonoBehaviour
{
    ParticleSystem particle;
    bool airFlag;

    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        particle.startSpeed = 12;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        airFlag = JumpBlock.airFlag;
        if(airFlag)
        {
            particle.startSpeed = 36;
        }
        if(!airFlag)
        {
            particle.startSpeed = 12;
        }
    }
}
