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

  public class Location
  {
    private string _location;
    public Location(string location)
    {
      _location = location;
    }
    public string GetLocation()
    {
      return _location;
    }
  }

  public class Album
  {
    string _title,_artist,_price;
    public Album(string title, string artist, string price)
    {
      _title = title;
      _artist = artist;
      _price = price;
    }
    public string GetTitle()
    {
      return _title;
    }
    public string GetArtist()
    {
      return _artist;
    }
    public string GetPrice()
    {
      return _price;
    }

  }
}
