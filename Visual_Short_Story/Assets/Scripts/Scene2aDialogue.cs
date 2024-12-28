using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2aDialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
       //public TMP_Text Char3name;
       //public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar1a.SetActive(false);
             ArtChar1b.SetActive(false);
             ArtChar1c.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             nextButton.SetActive(true);
        }

// Use the spacebar as a faster "Next" button:
        void Update(){        
             if (allowSpace == true){
                 if (Input.GetKeyDown("space")){
                      Next();
                 }

				  // secret debug code: go back 1 Story Unit, if NEXT is visible
                 if (Input.GetKeyDown("p")) {
                      primeInt -= 2;
                      Next();
                 } 
             }
        }

//Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt += 1;
        if (primeInt == 1){
                // audioSource1.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Oh God, how far did I fall?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                GameHandler.GotTreasure1=false;
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().DisplayTreasure();
			ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Raider";
                Char2speech.text = "Hmmm, it doesn't really matter when something this nice falls right into my hands.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "Dammit I really thought that would go differently. You’re seriously gonna take MY pendant? I fell so many stories for that..";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Raider";
                Char2speech.text = "I don't recall asking you about your feelings.";
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "Give the pendant back!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
        ArtChar1c.SetActive(true);
        ArtChar1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Raider";
                Char2speech.text = "What pendant?";
        }
         else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "Don't make me upset now asshole.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
        ArtChar1b.SetActive(true);
        ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Raider";
                Char2speech.text = "Right. What could you possibly do? You're in no shape for a scuffle.";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                ArtChar1c.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Raider";
                Char2speech.text = "You're pretty loud for someone in such a vulnerable state, watch your mouth.";
        }
       else if (primeInt == 21){
                Char1name.text = "YOU";
                Char1speech.text = "I mean it, don't mess with me.";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
        ArtChar1b.SetActive(true);
        ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Raider";
                Char2speech.text = "HUH? All that yapping just to switch your tune so quickly? Lose your spine on the way down or something?";
        }
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "Real funny, just letting the young pups have a cut.";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah I'm sure, this opportunity is too good to pass up.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Maybe you're right.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3a");
        }
}