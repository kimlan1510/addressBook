using System;
using System.Collections.Generic;

namespace addressBook.Objects
{
  public class contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address;
    private int _id;
    private static List<contact> _listContact = new List<contact>();

    public contact(string name, string phoneNumber, string address)
    {
      SetInfo(name, phoneNumber, address);
      _listContact.Add(this);
      _id = _listContact.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public int GetID()
    {
      return _id;
    }

    public void SetInfo(string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
    }

    public static List<contact> ShowAll()
    {
      return _listContact;
    }

    public static void ClearAll()
    {
      _listContact.Clear();
    }

    public static contact Find(int searchID)
    {
      return _listContact[searchID - 1];
    }
  }

}
