using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2cDialogue : MonoBehaviour {
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
       //public GameObject ArtChar1b;
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
             ArtChar1a.SetActive(true);
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Mummy";
                Char2speech.text = "You're just letting me eat this bountiful arm?";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "I mean yeah, if that makes you happy. Like you said maybe I need to expand my horizons.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Mummy";
                Char2speech.text = "Jeez, I guess we have more in common than either of us though.";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "I think you're right. Y'know, the more we speak the more I'm beginning to like you.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Mummy";
                Char2speech.text = "OH MY! You're making me blush.";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "You're making ME blush!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Mummy";
                Char2speech.text = "I might just start kicking my feet stop that.";
       }
        else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "So what is to be done about such a budding romance?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Mummy";
                Char2speech.text = "Shall we be wed in holy matrimony then?";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "I'm sorry Mummy...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Mummy";
                Char2speech.text = "Truly unfortunate. Then we shall be wed in death.";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Mummy";
                Char2speech.text = "Exquisite, I've been waiting to give this ring to my one true love all this time. ";
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
                Char1speech.text = "No, this is all too sudden...";
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
                Char1speech.text = "I thought you would never ask!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("SceneLoseMummyMarriage");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("SceneWinMummy");
        }
}