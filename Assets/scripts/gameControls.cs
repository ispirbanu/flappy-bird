using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControls : MonoBehaviour
{

    public float ucusgucu;
    private Rigidbody2D rigibody;

    //oyun baþlama 
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
        // Týklama iþlemi
        if (Input.GetMouseButtonDown(0) ) {
            //oyun zaten baþlamýþsa ayný iþlem tekrarlanmamasý için bu if þartý eklendi
            rigibody.gravityScale = 1;
            Fly();

            //? kodlar varken kuþ oyun baþladýktan sonra zýplamýyor. 
            /**if (!gameStart)
            {
                // oyun baþlayacaðý için yer çekimi ve oyun baþlama deðiþkenlerinin deðerleri atandý
                rigibody.gravityScale = 1;
                gameStart = true;
                // tuþa basarak hareket saðlama fonksiyonu çaðýrýlýr.
                Fly();
            }
            **/

        }
    }

    void Fly()
    {
        //Objenin hýz deðiþkeni
        rigibody.velocity = Vector2.zero;

        //0 deðeri x i temsil ediyor çünkü ileri geri gitmemeli
        //yukarý aþaðý hareket etmesi için y deðiþkeni verildi buda yukarýda 
        //tanýmlanan uçuþ gücü (flyst)
        rigibody.AddForce(new Vector2(0, ucusgucu));

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // ölüm alaný olarak belirlenen kýsýmlara girildiðinde oyun bitecek
        if (other.tag == "deadArea");
        gameOver = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ölüm alaný olarak belirlenen kýsýmlara girildiðinde oyun bitecek
        if (collision.transform.tag == "deadArea") ;
        gameOver = true;
    }
}
