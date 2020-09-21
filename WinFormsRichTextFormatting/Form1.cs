using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WinFormsRichTextFormatting
{
public partial class Form1 : Form
{
    private readonly string[] _skyBlueStrings;
    private readonly string[] _blueStrings;
    private readonly string[] _greenStrings;

    //for pasting
    bool _IsCtrl;
    bool _IsV;

    //value to fix the colour not setting first character after return key pressed
    int _returnIdxFix = 0;

    //regex patterns to use
    string _LightBlueRegX = "";
    string _BlueRegX = "";
    string _GreenRegX = "";

    //match only words
    Regex _rgxAnyWords = new Regex(@"(\w+)");

    //colour setup
    Color _LightBlueColour = Color.LightSkyBlue;
    Color _BlueColour = Color.Blue;
    Color _GreenColour = Color.DarkGreen;
    Color _DefaultColour = Color.Black;


    public Form1()
    {
        InitializeComponent();

        _skyBlueStrings = new string[] { "Main", "ClickMouseDown", "ClickMouseUp", "PressKey", "StopMoving", "Delay", "GoRight", "GoLeft", "GoUp", "GoDown", "MousePosition", "LastHorizontalDirection", "LastVerticalDirections", "CurrentDirection", "Directions" };
        _blueStrings = new string[] { "cm", "if", "else", "while", "switch", "case", "break", "return", "new" };
        _greenStrings = new string[] { "MyPosition", "MyHp", "MyMp", "OtherPeopleInMap", "RIGHT", "LEFT", "UP", "DOWN", "STOP_MOVING" };

        _LightBlueRegX = BuildRegExPattern(_skyBlueStrings);
        _BlueRegX = BuildRegExPattern(_blueStrings);
        _GreenRegX = BuildRegExPattern(_greenStrings);
    }

    string BuildRegExPattern(string[] keyworkArray)
    {
        StringBuilder _regExPatern = new StringBuilder();
        _regExPatern.Append(@"\b(");//beginning of word
        _regExPatern.Append(string.Join("|", keyworkArray));//all reserve words
        _regExPatern.Append(@")\b");//end of word
        return _regExPatern.ToString();
    }

    private void ProcessAllText()
    {
        BeginRtbUpdate();
        FormatKeywords(_LightBlueRegX, _LightBlueColour);
        FormatKeywords(_BlueRegX, _BlueColour);
        FormatKeywords(_GreenRegX, _GreenColour);

        //internal function to process words and set their colours
        void FormatKeywords(string regExPattern, Color wordColour)
        {
            var matchStrings = Regex.Matches(ScriptRichTextBox.Text, regExPattern);
            foreach (Match match in matchStrings)
            {
                FormatKeyword(keyword: match.Value, wordIndex: match.Index, wordColour: wordColour);
            }
        }

        EndRtbUpdate();
        ScriptRichTextBox.Select(ScriptRichTextBox.Text.Length, 0);
        ScriptRichTextBox.Invalidate();
    }

    void ProcessWordAtIndex(string fullText, int cursorIdx)
    {
        MatchCollection anyWordMatches = _rgxAnyWords.Matches(fullText);
        if (anyWordMatches.Count == 0)
        { return; } // no words found

        var allWords = anyWordMatches.OfType<Match>().ToList();

        //get the word just before cursor
        var wordAtCursor = allWords.FirstOrDefault(w => (cursorIdx - _returnIdxFix) == (w.Index + w.Length));
        if (wordAtCursor is null || string.IsNullOrWhiteSpace(wordAtCursor.Value))
        { return; }//no word at cursor or the match was blank

        Color wordColour = CalculateWordColour(wordAtCursor.Value);
        FormatKeyword(wordAtCursor.Value, wordAtCursor.Index, wordColour);

    }

    private Color CalculateWordColour(string word)
    {
        if (_skyBlueStrings.Contains(word))
        { return _LightBlueColour; }
        if (_blueStrings.Contains(word))
        { return _BlueColour; }
        if (_greenStrings.Contains(word))
        { return _GreenColour; }
        return _DefaultColour;
    }

    private void FormatKeyword(string keyword, int wordIndex, Color wordColour)
    {
        ScriptRichTextBox.Select((wordIndex - _returnIdxFix), keyword.Length);
        ScriptRichTextBox.SelectionColor = wordColour;
        ScriptRichTextBox.Select(wordIndex + keyword.Length, 0);
        ScriptRichTextBox.SelectionColor = _DefaultColour;
    }

    #region RichTextBox BeginUpdate and EndUpdate Methods
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            //wait until the rtb is visible, otherwise you get some weird behaviour.
            if (ScriptRichTextBox.Visible && ScriptRichTextBox.IsHandleCreated)
            {
                if (m.LParam == ScriptRichTextBox.Handle)
                {
                    rtBox_lParam = m.LParam;
                    rtBox_wParam = m.WParam;
                }
            }
        }

        IntPtr rtBox_wParam = IntPtr.Zero;
        IntPtr rtBox_lParam = IntPtr.Zero;
        const int WM_SETREDRAW = 0x0b;
        const int EM_HIDESELECTION = 0x43f;

        void BeginRtbUpdate()
        {
            Message msg_WM_SETREDRAW = Message.Create(ScriptRichTextBox.Handle, WM_SETREDRAW, (IntPtr)0, rtBox_lParam);
            this.DefWndProc(ref msg_WM_SETREDRAW);
        }

        public void EndRtbUpdate()
        {
            Message msg_WM_SETREDRAW = Message.Create(ScriptRichTextBox.Handle, WM_SETREDRAW, rtBox_wParam, rtBox_lParam);
            this.DefWndProc(ref msg_WM_SETREDRAW);
            //redraw the RichTextBox
            ScriptRichTextBox.Invalidate();
        }
        #endregion

    private void ScriptRichTextBox_TextChanged(object sender, EventArgs e)
    {
        //only run all text if it was pasted NOT ON EVERY TEXT CHANGE!
        if (_IsCtrl && _IsV)
        {
            _IsCtrl = false;
            ProcessAllText();
        }
    }

    protected void ScriptRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetterOrDigit(e.KeyChar))
        {
            //if the key was enter the cursor position is 1 position off                
            _returnIdxFix = (e.KeyChar == '\r') ? 1 : 0;
            ProcessWordAtIndex(ScriptRichTextBox.Text, ScriptRichTextBox.SelectionStart);
        }
    }

    private void ScriptRichTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
    {
        if (e.KeyCode == Keys.ControlKey)
        {
            _IsCtrl = true;
        }
        if (e.KeyCode == Keys.V)
        {
            _IsV = true;
        }
    }

    private void ScriptRichTextBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
    {
        if (e.KeyCode == Keys.ControlKey)
        {
            _IsCtrl = false;
        }
        if (e.KeyCode == Keys.V)
        {
            _IsV = false;
        }
    }
}
}

/*
 private void FirstPlat(){
  if(MyPosition.Y , 19)  { 
     if(MyPosition.X < 120) {
       cm.GoRight()
      AttackTeleCombo(); }
     else if (MyPosition.X >= 120 && MyPosition.X < 150){
      cm.GoUp();
      cm.PressKey("KEY_X",0);  }
  else{
    cm.GoLeft(); }
 }
}
private void SecondPlat() {
   if(MyPosition.Y , 19) { 
      if(MyPosition.X < 120)  {
       cm.RIGHT
       AttackTeleCombo();}
     else if (MyPosition.X >= 120 && MyPosition.X < 150){
     cm.GoUp();
     cm.PressKey("KEY_X",0);}
   else{
     cm.GoLeft();}
    }
}
 */
