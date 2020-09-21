using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRichTextFormatting
{
    public partial class FormQ : Form
    {
        public FormQ()
        {
            InitializeComponent();
        }

        private void ScriptRichTextBox_TextChanged(object sender, EventArgs e)
        {
            FindStringsInCurrentWord();
        }

        private void FindStringsInCurrentWord()
        {
            RichTextBox script = ScriptRichTextBox;
            String finalWord, forwards, backwards;
            int saveLastSelectionStart = script.SelectionStart;
            int index = script.SelectionStart;

            String[] coloredNames = { "Main", "ClickMouseDown", "ClickMouseUp", "PressKey", "StopMoving", "Delay", "GoRight", "GoLeft", "GoUp", "GoDown", "MousePosition", "LastHorizontalDirection", "LastVerticalDirections", "CurrentDirection", "Directions" };
            String[] coloredNames2 = { "cm.", "if", "else", "while", "switch", "case", "break", "return", "new" };
            String[] coloredNames3 = { "MyPosition", "MyHp", "MyMp", "OtherPeopleInMap", ".RIGHT", ".LEFT", ".UP", ".DOWN", ".STOP_MOVING" };

            String[] arr2 = coloredNames.Union(coloredNames2).ToArray();
            Array arrAll = arr2.Union(coloredNames3).ToArray(); //Gets all arrays together
            Array[] wordsArray = { coloredNames, coloredNames2, coloredNames3 }; //All found strings in the word
            List<String> wordsFoundList = new List<String>();
            int foundChangedColor = 0;
            int wordsFound = 0;


            char current = (char)script.GetCharFromPosition(script.GetPositionFromCharIndex(index)); //Where the editor thingy is
                                                                                                     //Check forward text where he uses space and save text
            while (!System.Char.IsWhiteSpace(current) && index < script.Text.Length)
            {
                index++;
                current = (char)script.GetCharFromPosition(script.GetPositionFromCharIndex(index));
            }
            int lengthForward = index - saveLastSelectionStart;
            script.Select(script.SelectionStart, lengthForward);
            forwards = script.SelectedText;
            //Debug.WriteLine("Forwards: " + forwards);
            script.SelectionStart = saveLastSelectionStart;
            this.ScriptRichTextBox.Select(script.SelectionStart, 0);
            index = script.SelectionStart;
            current = (char)script.GetCharFromPosition(script.GetPositionFromCharIndex(index));
            int length = 0;
            //Check backwords where he uses space and save text
            while ((!System.Char.IsWhiteSpace(current) || length == 0) && index > 0 && index <= script.Text.Length)
            {
                index--;
                length++;
                current = (char)script.GetCharFromPosition(script.GetPositionFromCharIndex(index));
            }
            script.SelectionStart -= length;
            script.Select(script.SelectionStart + 1, length - 1);
            backwards = script.SelectedText;
            //Debug.WriteLine("Backwards: " + backwards);
            script.SelectionStart = saveLastSelectionStart;
            this.ScriptRichTextBox.Select(saveLastSelectionStart, 0);
            this.ScriptRichTextBox.SelectionColor = Color.Black;
            finalWord = backwards + forwards; //Our all word!
                                              //Debug.WriteLine("WORD:" + finalWord);

            //Setting all of the word black, after it coloring the right places
            script.Select(index + 1, length + lengthForward);
            script.SelectionColor = Color.Black;
            foreach (string word in arrAll)
            {
                if (finalWord.IndexOf(word) != -1)
                {
                    wordsFound++;
                    wordsFoundList.Add(word);
                    script.Select(index + 1 + finalWord.IndexOf(word), word.Length);
                    if (coloredNames.Any(word.Contains))
                    {
                        script.SelectionColor = Color.LightSkyBlue;
                        foundChangedColor++;
                    }
                    else if (coloredNames2.Any(word.Contains))
                    {
                        script.SelectionColor = Color.Blue;
                        foundChangedColor++;
                    }
                    else if (coloredNames3.Any(word.Contains))
                    {
                        script.SelectionColor = Color.DarkGreen;
                        foundChangedColor++;
                    }
                    //Debug.WriteLine("Word to edit: " + script.SelectedText);
                    this.ScriptRichTextBox.Select(saveLastSelectionStart, 0);
                    this.ScriptRichTextBox.SelectionColor = Color.Black;
                }
            }

            //No strings found, color it black
            if (wordsFound == 0)
            {
                script.Select(index + 1, length + lengthForward);
                script.SelectionColor = Color.Black;
                //Debug.WriteLine("WORD??: " + script.SelectedText);
                this.ScriptRichTextBox.Select(saveLastSelectionStart, 0);
                this.ScriptRichTextBox.SelectionColor = Color.Black;
            }
        }
    }
}
