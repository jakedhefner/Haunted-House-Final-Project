using Unity.VisualScripting;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    public bool shieldActive;

    public GameObject shieldGet;

    public GameObject shieldLose;

    public GameObject shield;
    public AudioClip shieldPickup;

    public ParticleSystem pickupEffect;

    public ParticleSystem loseEffect;

   



    

    public AudioClip shieldDown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shieldActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider whatDidIHit)
    {
        if (whatDidIHit.tag == "Shield" && shieldActive == false)
        {
            Destroy (whatDidIHit.gameObject);
            shieldGet.GetComponent<AudioSource>().PlayOneShot(shieldPickup);
            pickupEffect.GetComponent<ParticleSystem>().Play(pickupEffect);
            shieldActive = true;
            shield.SetActive(true);
        }

        else if (whatDidIHit.tag == "Ghost" && shieldActive == true)
        {
        
            Destroy (whatDidIHit.gameObject);
            shieldLose.GetComponent<AudioSource>().PlayOneShot(shieldDown);
            loseEffect.GetComponent<ParticleSystem>().Play(loseEffect);
            shieldActive = false;
            shield.SetActive(false);
        }
    }

    
    
}

