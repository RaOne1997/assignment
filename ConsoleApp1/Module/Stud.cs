internal class Stud
{
   private string Name, Address, Email, Cource_Code;

    public string name
    {

        get { return Name; }   
        set { Name = value; }
    }

    public string address
    {

        get { return Address; }
        set { Address = value; }
    }


    public string email
    {

        get { return Email; }
        set { Email = value; }
    }

    public string cource_Code
    {

        get { return Cource_Code; }
        set { Cource_Code = value; }
    }


   public Stud(string Name, string Address, string Email, string Cource_Code)
    {

        this.Name = Name;
        this.Address = Address;
        this.Email = Email;
        this.Cource_Code= Cource_Code;
    }

}

