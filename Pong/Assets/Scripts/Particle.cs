using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DesroyParticle());
    }
    IEnumerator DesroyParticle()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
