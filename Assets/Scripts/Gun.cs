using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bulletPrefabs;

    [SerializeField]
    private Transform spawnPoint;

    [SerializeField]
    private float gunSpeed;

    [SerializeField]
    private AudioSource gunSoundPlayer;

    [SerializeField]
    private AudioClip gunSound;

    GameObject tempBullet;
    int randomBulletIndex;

    public void Shoot()
    {
        // Get random index
        randomBulletIndex = Random.Range(0, bulletPrefabs.Length);

        // Pick a random bullet and instantiate
        tempBullet = Instantiate(bulletPrefabs[randomBulletIndex], spawnPoint.position, spawnPoint.rotation);

        tempBullet.GetComponent<Rigidbody>().AddForce(gunSpeed * spawnPoint.forward);

        gunSoundPlayer.pitch = Random.Range(1f, 1.5f);
        gunSoundPlayer.PlayOneShot(gunSound);
    }
}
