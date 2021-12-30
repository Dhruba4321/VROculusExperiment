using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnBullet : MonoBehaviour
{
    public float speed = 30;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public void Fire()
    {
        GameObject spawnBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        spawnBullet.GetComponent<Rigidbody>().velocity = speed * barrel.right;
        audioSource.PlayOneShot(audioClip);
        Destroy(spawnBullet, 2);
    }
}
