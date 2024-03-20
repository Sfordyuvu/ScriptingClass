using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    [SerializeField] private Cooldown cooldown;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (cooldown.IsCoolingDown) return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown.StartCooldown();
        }
    }
}
