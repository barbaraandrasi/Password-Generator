using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class GeneratorForm : Form
    {
        private List<char> letterList;
        private List<char> numberList;
        private List<char> specialList;

        private Random random;
  

        public GeneratorForm()
        {
            InitializeComponent();
            lettersButton.Checked = true;
            lowerCaseButton.Checked = true;

            letterList = new List<char>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' });
            numberList = new List<char>(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            specialList = new List<char>(new char[] { '.', ',', '_', '-', '?', '!', ';', ':', '$' });
            random = new Random();
        }



        private void generateButton_Click(object sender, EventArgs e)
        {
            int length = (int) lengthField.Value;
            RadioButton contentTypeRadioButton = contentRadioButtonGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton letterTypeRadioButton = letterTypeButtonGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
             if (isValidSettings(length, contentTypeRadioButton, letterTypeRadioButton))
            {
                List<char> characterList = getAppropriateCharacters(contentTypeRadioButton, letterTypeRadioButton);
                string generatedPassword = "";
                do
                {
                    generatedPassword = "";
                    for (int i = 0; i < length; i++)
                    {
                        generatedPassword += characterList.ElementAt(random.Next(characterList.Count));
                    }

                } while (!isConditionsMeet(generatedPassword, contentTypeRadioButton, letterTypeRadioButton));

                MessageBox.Show(generatedPassword);
            }
            else
            {          
                MessageBox.Show("Settings are not valid!");
            }
        }

        private bool isValidSettings(int length, RadioButton contentTypeRadioButton, RadioButton letterTypeRadioButton)
        {
            bool numericCharacter = contentTypeRadioButton != lettersButton;
            bool specialCharacter = contentTypeRadioButton == specialCharButton;

            bool loweCase = letterTypeRadioButton != upperCaseButton;
            bool upperCase = letterTypeRadioButton != lowerCaseButton;

            if (length < 1)
            {
                return false;
            }

            if (length < 2 && (numericCharacter || specialCharacter || (loweCase && upperCase)))
            {
                return false;
            }

            if (length <3 && (specialCharacter || (loweCase && upperCase && numericCharacter)))
            {
                return false;
            }

            if (length < 4 && ((loweCase && upperCase && specialCharacter)))
            {
                return false;
            }

            return true;
        }

        private bool isConditionsMeet(string value, RadioButton contentTypeRadioButton, RadioButton letterTypeRadioButton)
        {
            bool numericCharacter = contentTypeRadioButton != lettersButton;
            bool specialCharacter = contentTypeRadioButton == specialCharButton;

            bool loweCase = letterTypeRadioButton != upperCaseButton;
            bool upperCase = letterTypeRadioButton != lowerCaseButton;

            bool rightSolutionNumeric = false;
            bool rightSolutionSpecial = false;
            bool rightSolutionLower = false;
            bool rightSolutionUpper = false;


            if (numericCharacter)
            {
                foreach (var v in value)
                {
                    if (numberList.Contains(v))
                    {
                        rightSolutionNumeric = true;
                    }
                }
            }

            if (specialCharacter)
            {
                foreach (var v in value)
                {                
                    if (specialList.Contains(v))
                    {
                        rightSolutionSpecial = true;
                    }
                }
            }

            if (loweCase)
            {
                foreach (var v in value)
                {
                    if (letterList.Contains(v))
                    {
                        rightSolutionLower = true;
                    }
                }
            }

            if (upperCase)
            {
                foreach (var v in value)
                {
                    if (letterList.Select(x => Char.ToUpper(x)).Contains(v))
                    {
                        rightSolutionUpper = true;
                    }
                }
            }

            return (numericCharacter ? rightSolutionNumeric :
                true) && (specialCharacter ? rightSolutionSpecial :
                true) && (loweCase ? rightSolutionLower :
                true) && (upperCase ? rightSolutionUpper : true);
        }

        private List<char> getAppropriateCharacters(RadioButton contentTypeRadioButton, RadioButton letterTypeRadioButton)
        {
            List<char> characterList = new List<char>();

            characterList.AddRange(getCharactersByLetterType(letterTypeRadioButton));

            if (contentTypeRadioButton == alphanumericButton)
            {
                characterList.AddRange(numberList);
            }
            else if (contentTypeRadioButton == specialCharButton)
            {
                characterList.AddRange(numberList);
                characterList.AddRange(specialList);         
            }
      
            return characterList;
        }

        private List<char> getCharactersByLetterType(RadioButton letterTypeRadioButton)
        {
            List<char> characterList = new List<char>();

            if (letterTypeRadioButton == lowerCaseButton)
            {
                characterList.AddRange(letterList);
            }
            else if (letterTypeRadioButton == upperCaseButton)
            {
                characterList.AddRange(letterList.Select(x => Char.ToUpper(x)));
            }
            else
            {
                characterList.AddRange(letterList);
                characterList.AddRange(letterList.Select(x => Char.ToUpper(x)));
            }
            return characterList;
        }
    }
}
