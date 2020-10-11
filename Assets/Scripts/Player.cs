using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;

    public Transform shottingOffset;

    public Transform player;

    private float amplitude = 1;

    private float velocityPlayer = 0;

    public float maxBoundary, minBoundary;
  
    // Start is called before the first frame update
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
      velocityPlayer = Input.GetAxis("Horizontal");

      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 3f);
      }

      if (player.position.x < minBoundary && velocityPlayer < 0)
      {
        velocityPlayer = 0;
      }
      else if (player.position.x > maxBoundary && velocityPlayer > 0)
      {
        velocityPlayer = 0;
      }

      player.position += Vector3.right * velocityPlayer * amplitude; 
    }

    // private void FixedUpdate()
    // {
    //
    //   if(player.position.x <= 11.5 || player.position.x >= -11.5)
    //   {
    //     MovePlayer(new Vector3(velocityPlayer, 0, 0), player); 
    //   }
    //   else
    //   {
    //     Debug.Log("We are getting outside the boundries");
    //   }
    //   
    // }
    //
    // void MovePlayer(Vector3 direction, Transform player)
    // {
    //   player.Translate(direction * amplitude);
    // }
}
