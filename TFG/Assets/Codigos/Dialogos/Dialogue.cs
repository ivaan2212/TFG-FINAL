using System.Collections;
using UnityEngine;
using TMPro;
public class Dialogue : MonoBehaviour
{

    private bool isPlayerInRange;
    public PickUpFlor flor; 
    public PersonajeMovimiento move;
    public GameObject habla;
    [SerializeField, TextArea(6,10)] private string[] LineasDialogo;
    [SerializeField, TextArea(6, 10)] private string[] nuevoarreglodialogo;
    [SerializeField] private TMP_Text dialogue;
    [SerializeField] private GameObject dialoguePanel;
    public GameObject gema;

    private float tiemporespuesta = 0.05f;

    private bool didDialogueStart;
    private int lineIndex;

    private Animator animator;
   // public Sprite normalSprite;
    //public Sprite spritecerca;
   // public SpriteRenderer spriteRenderer;


    private void Start()
    {
        animator = GetComponent<Animator>();
        //spriteRenderer.sprite = normalSprite;
        
    }


    // Update is called once per frame
    void Update()
    {
       
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!didDialogueStart)
            {

                    StartDialogue();
                
                
            }
            else if(dialogue.text == LineasDialogo[lineIndex])
            {
                NextDialogueLine();
            }
            else
            {
                StopAllCoroutines();
                dialogue.text = LineasDialogo[lineIndex];
            }            
        }
    }

    private void StartDialogue()
    {
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        habla.SetActive(false);
        lineIndex = 0;
        Debug.Log(flor.Cflor);

        if (flor.Cflor)
        {
            LineasDialogo = nuevoarreglodialogo;
            gema.SetActive(true);
        }


        //Time.timeScale = 0f;
        //move.GetComponent<Animator>().enabled = false;
        move.GetComponent<PersonajeMovimiento>().enabled = false;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        dialogue.text = string.Empty;

        foreach (char ch in LineasDialogo[lineIndex])
        {
            dialogue.text += ch;
            yield return new WaitForSecondsRealtime(tiemporespuesta);
        }
    } 

    private void NextDialogueLine()
    {
        lineIndex++;
        if(lineIndex < LineasDialogo.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
            habla.SetActive(true);
            Time.timeScale = 1f;
            //move.GetComponent<Animator>().enabled = true;
            move.GetComponent<PersonajeMovimiento>().enabled = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Mirando", true);
            isPlayerInRange = true;
            habla.SetActive(true);
            //spriteRenderer.sprite = spritecerca;
            
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Mirando", false);
            isPlayerInRange = false;
            habla.SetActive(false);
            
            //spriteRenderer.sprite = normalSprite;
        }
    }
}
