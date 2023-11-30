using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 1000;

    public GameObject bulletPrefab;
    public float fireRate = 1;
    public Transform firepoint;

    Rigidbody2D rb;
    
    void Start()
    {
        InvokeRepeating(nameof(Shoot), fireRate, fireRate);
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(x * speed * Time.deltaTime, y * speed * Time.deltaTime);
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, transform.rotation);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid")) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
