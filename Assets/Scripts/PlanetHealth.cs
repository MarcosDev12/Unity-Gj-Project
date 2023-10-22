using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Linq;

public class PlanetHealth : MonoBehaviour
{
    public int _currentHealth = 10;

    // Game Object of landmasses, used to change color as planet loses health
    public GameObject landMasses;

    public Material materialHealth100;
    public Material materialHealth75;
    public Material materialHealth50;
    public Material materialHealth25;
    public Material materialHealth0;

    public GameObject heartsUI;
    public GameObject heartPrefab;

    public int Health {
        get {
            return _currentHealth;
        }

        set {
            if(value >= 0)
                _currentHealth = value;

            Debug.Log("New Health: " + _currentHealth);

            // Change Land Masses Color according to planet health
            switch(Health){
                case <= 0: landMasses.GetComponent<MeshRenderer>().sharedMaterial = materialHealth0; break;
                case < 3: landMasses.GetComponent<MeshRenderer>().sharedMaterial = materialHealth25; break;
                case < 6: landMasses.GetComponent<MeshRenderer>().sharedMaterial = materialHealth50; break;
                case < 8: landMasses.GetComponent<MeshRenderer>().sharedMaterial = materialHealth75; break;
                default: landMasses.GetComponent<MeshRenderer>().sharedMaterial = materialHealth100; break;
            }
            
            // Get all current hearts
            GameObject[] hearts = GameObject.FindGameObjectsWithTag("Heart");

            // Destroys all hearts
            foreach(GameObject heart in hearts){
                Destroy(heart);
            }

            // Add new hearts equal to current health points

            for(int i = 0; i < Health; i++){
                GameObject newHeart = Instantiate(heartPrefab, heartsUI.transform);
                newHeart.transform.position = new Vector3(40 + ((i * 20)), newHeart.transform.position.y, newHeart.transform.position.z);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            this.Health--;
        }
    }
}
