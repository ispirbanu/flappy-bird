using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControls : MonoBehaviour
{

    public float ucusgucu;
    private Rigidbody2D rigibody;

    //oyun ba�lama 
    public bool gameStart=false;
    // Oyun bitme
    public bool gameOver=false;

    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // T�klama i�lemi
        if (Input.GetMouseButtonDown(0) ) {
            //oyun zaten ba�lam��sa ayn� i�lem tekrarlanmamas� i�in bu if �art� eklendi
            rigibody.gravityScale = 1;
            Fly();

            //? kodlar varken ku� oyun ba�lad�ktan sonra z�plam�yor. 
            /**if (!gameStart)
            {
                // oyun ba�layaca�� i�in yer �ekimi ve oyun ba�lama de�i�kenlerinin de�erleri atand�
                rigibody.gravityScale = 1;
                gameStart = true;
                // tu�a basarak hareket sa�lama fonksiyonu �a��r�l�r.
                Fly();
            }
            **/

        }
    }

    void Fly()
    {
        //Objenin h�z de�i�keni
        rigibody.velocity = Vector2.zero;

        //0 de�eri x i temsil ediyor ��nk� ileri geri gitmemeli
        //yukar� a�a�� hareket etmesi i�in y de�i�keni verildi buda yukar�da 
        //tan�mlanan u�u� g�c� (flyst)
        rigibody.AddForce(new Vector2(0, ucusgucu));

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // �l�m alan� olarak belirlenen k�s�mlara girildi�inde oyun bitecek
        if (other.tag == "deadArea");
        gameOver = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �l�m alan� olarak belirlenen k�s�mlara girildi�inde oyun bitecek
        if (collision.transform.tag == "deadArea") ;
        gameOver = true;
    }
}
