using System.Collections;
using UnityEngine;
using TMPro;
public class DialogoMayor: MonoBehaviour
{

    private bool isPlayerInRange;
    public PersonajeMovimiento move;
    public GameObject habla;
    [SerializeField, TextArea(6,10)] private string[] LineasDialogo;
    [SerializeField, TextArea(6, 10)] private string[] nuevoarreglodialogo;
    [SerializeField] private TMP_Text dialogue;
    [SerializeField] private GameObject dialoguePanel;
    public SpriteRenderer CambioSprite;
    public SpriteRenderer SpriteOriginal;
    public DetectarObjetosFinal final;

    private float tiemporespuesta = 0.05f;

    public bool didDialogueStart;
    private int lineIndex;

    private void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
       
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!didDialogueStart)
            {
                    StartDialogue();
                
            }else if(dialogue.text == LineasDialogo[lineIndex])
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
        
        if (final.cambio == true)
        {
            LineasDialogo = nuevoarreglodialogo; 
        }
            

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
            move.GetComponent<PersonajeMovimiento>().enabled = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            habla.SetActive(true);
            SpriteOriginal.enabled = false;
            CambioSprite.enabled = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            habla.SetActive(false);
            SpriteOriginal.enabled = true;
            CambioSprite.enabled = false;
        }
    }
}
