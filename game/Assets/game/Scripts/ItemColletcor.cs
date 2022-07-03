using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemColletcor : MonoBehaviour
{
    private int melons = 0;

    [SerializeField] private Text melonsText;

    [SerializeField] private AudioSource CollectingSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
  {
       if   (collision.gameObject.CompareTag("Melon"))
        {
            CollectingSoundEffect.Play();
            Destroy(collision.gameObject);
            melons++;
            melonsText.text = "Melons: " + melons;
        }
    }

}

