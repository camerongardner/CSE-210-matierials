class Word
{
    private string _words;
    private bool _isHidden;
    public Word(string words)
    {
        _words = words;
        _isHidden = false;
    }
    public string GetText()
    {
        if (_isHidden)
        {
            return new string('_', _words.Length);
        }
        else
        {
            return _words;
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
    //Check to see of a word has already been hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
}