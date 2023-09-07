// string permission = "Admin|Manager";
// int level = 55;

static void userValidation(string permission, int level)
{
  if (permission == "Admin")
  {
    if (level > 55)
    {
      Console.WriteLine("Welcome, Super Admin");
    }
    else if (level <= 55)
    {
      Console.WriteLine("Welcome, Admin user");
    }
    else if (level >= 20)
    {
      Console.WriteLine("Contact a Manager for access.");
    }
  }

else if (permission == "Manager")
  {
    if (level >= 20)
    {
      Console.WriteLine("Contact an Admin for access.");
    }
    else if (level < 20)
    {
      Console.WriteLine("You do not have sufficient privileges.");
    }
    else
    {
      Console.WriteLine("You do not have sufficient privileges.");
    }
  }
  else
  {
    Console.WriteLine("You do not have sufficient privileges.");
  }
}

userValidation("Admin", 60);
userValidation("Admin", 20);
userValidation("Manager", 20);
userValidation("Manager", 8);
userValidation("User", 0);

// q: how do I use classes?
// a: classes are used to create objects
// q: how do I create an object?
// a: use the new keyword