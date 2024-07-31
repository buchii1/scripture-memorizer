// A code template for the category of things known as Word.
// The responsibility of a Word is to hide, and replace hidden words
// in a scripture with _
public class Word
{
    private string _word;
    private bool _isHidden;

    // A constructor that accepts one argument and set the value word
    // to be hidden by default
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    // A method that returns the _isHidden attribute of the word
    public bool IsHidden()
    {
        return _isHidden;
    }

    // A method that hides a word
    public void HideWord()
    {
        _isHidden = true;
    }

    // A getter method that replaces hidden words with "_" and 
    //  returns the word
    public string ReplaceHiddenWord()
    {
        string hidden = "";

        // Condition to run if the word is hidden
        if (_isHidden)
        {
            // Loop through the length of the hidden word
            for (int i = 0; i < _word.Length; i++)
            {
                // Replace each index with an _
                hidden += "_";
            }
            return hidden;
        }
        else
        {
            return _word;
        }
    }
}