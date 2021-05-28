using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 direction; //Player Direction
    public float playerSpeed;
    public TileManager tile;
    
    // Start is called before the first frame update
    void Start()
    {
        tile = GameObject.Find("TileManager").GetComponent<TileManager>();
    }

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            if (direction == Vector3.forward)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
        }
        
        transform.Translate(direction * playerSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tile"))
        {
            tile.SpawnTile();
        }
    }
}
