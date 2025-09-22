public class Word
{
    //------------------------MEMBER VARIABLES-----------------

    private string _text;
    private bool _isHidden;

    //-----------------------CONSTRUCTORS-----------------------
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //---------------------METHODS----------------------
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }


}