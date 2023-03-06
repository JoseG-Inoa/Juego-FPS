using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2 : MonoBehaviour
{
    public int health = 50;
    private Animator _ac;

    private void Awake()
    {
        _ac = transform.GetChild(0).GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Damage(int dmg)
    {
        if (health > 0)
        {
            health -= dmg;

            if (health <= 0)
            {
                // _ac.Play("Death");
                Destroy(gameObject);
                SceneManager.LoadScene("Final");
            }
        }
    }

}
