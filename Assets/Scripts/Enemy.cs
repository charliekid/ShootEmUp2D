using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject particleSystem;
    // Start is called before the first frame update

    void Start()
    {
        particleSystem = GameObject.Find("ParticleSystem");
        //StartCoroutine("ParticleShow");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      Debug.Log("Ouch!");
      GameObject particle = Instantiate(particleSystem, transform.position, Quaternion.identity);
      Destroy(particle, 2f);
      Destroy(gameObject);
      Destroy(collision.gameObject);
    }

    void Update()
    {
        
    }

    // IEnumerable ParticleShow()
    // {
    //     particle.SetActive(true);
    //     yield return new WaitForSeconds(2);
    //     particle.SetActive(false);
    // }
}
