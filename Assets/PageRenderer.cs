using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageRenderer : MonoBehaviour
{
    // Texture list
    // Visible in the inspector
    [SerializeField]
    public List<Texture> textures = new List<Texture>();
    // Renderer
    public Renderer rendererr;

    // Start is called before the first frame update
    void Start()
    {
        SetAnimationSpeed(130);
        // Wait for 5 seconds
        // And then change the animation speed to 60 bpm
        StartCoroutine(WaitAndDoSomething());
    }

    IEnumerator WaitAndDoSomething()
    {
        // Attendre pendant 5 secondes
        yield return new WaitForSeconds(5);

        // Faire quelque chose après l'attente
        SetAnimationSpeed(60);
    }

    // Set animation speed from bpm. 60 bpm = 1 page per second
    void SetAnimationSpeed(int bpm)
    {
        // Get animation component
        Animation animation = GetComponent<Animation>();

        // Set animation speed
        animation["PageFlip"].speed = bpm / 60f;
    }

    // Turn page by changing texture
    void OnTurnPage()
    {
        // Change texture
        // Get random texture from list
        int randomTextureIndex = Random.Range(0, textures.Count);
        Texture randomTexture = textures[randomTextureIndex];

        // Set texture
        rendererr.material.mainTexture = randomTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
