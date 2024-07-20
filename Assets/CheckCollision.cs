using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D other)
    {
        ObjectPlayer otherObjectPlayer = other.gameObject.GetComponent<ObjectPlayer>();
        if (otherObjectPlayer == null) { return; }

        if (otherObjectPlayer.id == GetComponent<ObjectPlayer>().id)
        {
            SpawnGame();
            if (otherObjectPlayer.id < 3)
            {
                Destroy(other.gameObject);
            }
        }
    }

    public void SpawnGame()
    {
        GetComponent<ObjectPlayer>().id += 1;
        Debug.Log("Spawn");
    }

}
