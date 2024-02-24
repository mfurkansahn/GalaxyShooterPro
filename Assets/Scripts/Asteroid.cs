using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    private float _rotateSpeed = 3.0f;
    [SerializeField]
    private GameObject _explosionPrefab;
    [SerializeField]
    private SpawnManager _spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        _spawnManager = GameObject.Find("Spawn_Manager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //rotate object on the zed axis!
        transform.Rotate(Vector3.forward * _rotateSpeed * Time.deltaTime);
    }

    //check for LASER clollison (Trigger)
    //instantiate explosion at the position of the astroid (us)
    //destroy the explosion after 3 seconds.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Laser")
        {
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            _spawnManager.StartSpawning();
            Destroy(other.gameObject, 0.25f);
        }
    }
}
