class Word
{
    private string _text;
    private bool _hidden;

    public string Text => _text;
    public bool Hidden => _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public override string ToString()
    {
        return _hidden ? new string('_', _text.Length) : _text;
    }
}
