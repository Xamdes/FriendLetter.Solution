namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient, _sender;

    public LetterVariable()
    {
      _recipient = "Kyle";
      _sender = "Jack";
    }

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }
  }
}
