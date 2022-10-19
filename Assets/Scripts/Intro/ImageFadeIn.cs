using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFadeIn : MonoBehaviour
{
    public List<RawImage> image = new List<RawImage>();
    public float speed = 1;

    IEnumerator FadeIn()
    {
        float alpha = image[0].color.a;
        while(alpha < 1)
        {
            alpha += Time.deltaTime * speed;
            for(int i = 0; i < image.Count; i++)
            {
                image[i].color = new Color(image[i].color.r, image[i].color.g, image[i].color.b, alpha);
                
            }
            yield return null;
        }
    }

    private void Start()
    {
        StartCoroutine(FadeIn());
    }
}
