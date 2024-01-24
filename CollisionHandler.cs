using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ParticleSystem gemParticles;

    

    // Set the materials in the inspector
    public Material[] myMaterials;


    private void OnCollisionEnter(Collision collision)
    {

        switch (collision.gameObject.tag)
        {
            case "Gem":
                Debug.Log("You won a gem!");
                Destroy(collision.gameObject);
                WinGem();
                break;
            case "Enemy":
                Debug.Log("You hit an opponent");
                break;
            default:
                break;
        }
    }

    private void Start()
    {
        //gameObject.GetComponent<Renderer>().material =
        //myMaterials[Random.Range(0, myMaterials.Length)];
        StartCoroutine(loopDelay());
    }

    IEnumerator loopDelay()
    {
        for (int i = 0; i < myMaterials.Length; i++)
        {
            meshRenderer.material = myMaterials[i];
            yield return new WaitForSeconds(2.00f);
        }
        StartCoroutine(loopDelay());
    }

    private void WinGem()
    {
        gemParticles.Play();
    }
}

