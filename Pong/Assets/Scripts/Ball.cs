using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 5f;
    private Rigidbody2D rb;
    public Vector2 startPosition;
    [SerializeField]private GameObject particlesPrefab;
    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    void Update()
    {
        
    }
    private void Launch()
    {
        float x = Random.Range(0, 2) == 0? -1:1;
        float y = Random.Range(0, 2) == 0? -1:1;
        rb.velocity = new Vector2(x * speed, y * speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(particlesPrefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}
