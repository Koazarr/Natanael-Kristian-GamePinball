using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class BumperController : MonoBehaviour
{
	// menyimpan variabel bola sebagai referensi untuk pengecekan
	public ScoreManager scoreManager;
    public float score;
    public Collider bola;
    public float multiplier;
    public Color color;

    private Renderer renderer;
    private Animator animator;
    public AudioManager audioManager;
    public VFXManager vfxManager;

    public void Start(){
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        renderer.material.color = color;
    }


	private void OnCollisionEnter(Collision collision)
        {
        // memastikan yang menabrak adalah bola
        if (collision.collider == bola)
        {
        Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
        bolaRig.velocity *= multiplier;

        animator.SetTrigger("Hit");
        
        audioManager.PlaySFX(collision.transform.position);

        vfxManager.PlayVFX(collision.transform.position);

        scoreManager.AddScore(score);

        }
    }
}
