using System.Collections;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the object will move
    public GameObject objSpawn;
    public GameObject pool;
    void Update()
    {
        // Get input from the keyboard
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Create a new vector for movement
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        // Apply movement to the object's position
        transform.Translate(movement * moveSpeed * Time.deltaTime);
        
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            SpawnObjOnCol();
            StartCoroutine(TimeShow());
        }
    }
    
    
    void SpawnObjOnCol()
    {
        // Instantiate the object at the current position and with default rotation
        Instantiate(objSpawn, transform.position, Quaternion.identity);
    }

    IEnumerator TimeShow()
    {
        pool.SetActive(false);
        yield return new WaitForSeconds(1f);
        pool.SetActive(true);
    }
    
}