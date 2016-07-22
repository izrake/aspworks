using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace CGI.CSharp.MProject
{
    class Registration
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Pass { get; set; }
        public string CheckUser { get; set; }
        public string CheckPass { get; set; }
        public bool Track { get; set; }
        public string PrName { get; set; }
        public string PSearchName { get; set; }
        public bool SessionTracker { get; set; }
        public string PrCategory { get; set; }
        public float PrPrice { get; set; }
        public string PrDescription { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public bool QTrack { get; set; }
        public int Option { get; set; }
        public bool OptionTrack { get; set; }
        public char SignInStatus { get; set; }
        public char SearchStatus { get; set; }
        ArrayList arr = new ArrayList();        
        //List<string> Items = new List<string>();
        ArrayList Item = new ArrayList();
        
        public int key { get; set; }
            
            // Use to get the user details
        public void GetTheDetails()
        {
            
            Console.Write("FirstName: ");
            FName = Console.ReadLine().Trim() ;            
            Console.Write("LastName: ");
            LName = Console.ReadLine().Trim();
            Console.Write("EmailId: ");
            EmailId = Console.ReadLine().Trim();
            Console.Write("Mobile No: ");
            MobileNo = Console.ReadLine().Trim();
            Console.Write("Password: ");
            Pass = Console.ReadLine().Trim();           
            arr.Add(new User(FName, LName,EmailId,MobileNo,Pass));
        }
              //used to check the username and password   
        public void SignIn()
        {
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("                                  Enter Firstname As User                                             ");
            Console.WriteLine("******************************************************************************************************");
            foreach (object obj in arr)
            {
                User us = new User();
                us = (User)obj;
                Console.Write("UserName: ");
                CheckUser = Console.ReadLine().Trim();
                Console.Write("Password: ");
                CheckPass = Console.ReadLine().Trim();
                if (us.FName == CheckUser && us.Pass==CheckPass )
                {
                    Console.WriteLine("Sucessfully Signed In!!!!!");
                    SelectOption();
                }
                else
                {
                    Console.WriteLine("Sign In Again");
                    SignIn();                    
                }
                
            }
        }
        //used to ask user want to sign in or not
        public void StatusSignIn()
        {
            do
            {
                try
                {
                    Console.WriteLine("Do you want to Sign In:y/n ");
                    SignInStatus = Convert.ToChar(Console.ReadLine());
                    OptionTrack = false;
                    if (SignInStatus == 'y' || SignInStatus == 'Y')
                    {
                        Console.WriteLine("Please fill details to sign in!!!");
                        Console.Clear();
                        SignIn();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Thank You For Visiting");
                    }
                    
                }
                catch (FormatException ex)
                {
                    OptionTrack = true;
                    Console.WriteLine("Please enter the character as y or n " + ex.Message);
                }
            } while (OptionTrack);

                            
        }
        //used to add the product in the list
        public void AddProductInList()
        {
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("                                 Add Your Poducts !!!!!!!!                                            ");
            Console.WriteLine("******************************************************************************************************");
            do
            {
                
                Console.WriteLine("Please enter the product name:");
                PrName = Console.ReadLine().Trim();
                //Items.Add(PName);
                Console.Write("Product Category: ");
                PrCategory = Console.ReadLine().Trim();               
                Console.Write("Product Description: ");
                PrDescription = Console.ReadLine().Trim();               
                do
                {

                    try
                    {
                        Console.Write("Product Price: ");
                        PrPrice = float.Parse(Console.ReadLine().Trim());
                        Item.Add(new AddProduct(PrName, PrCategory, PrPrice, PrDescription, Quantity, "P00" + key));
                        QTrack = false;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        QTrack = true;
                    }
                   
                } while (QTrack);
                do
                {
                    try
                    {

                        Console.WriteLine("Enter the quantity");
                        Quantity = Convert.ToInt32(Console.ReadLine());
                        QuantityCheck check = new QuantityCheck(Quantity);
                        Quantity = check.CheckQuantity();
                        QTrack = false;
                    }
                    catch (QuantityException qx)
                    {
                        Console.WriteLine(qx.Message);
                        QTrack = true;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        QTrack = true;
                            
                    }
                    
                } while (QTrack);
                do
                {
                    try
                    {
                        Console.WriteLine("Do you want to add more product:y/n");
                        char status = Convert.ToChar(Console.ReadLine());
                        if (status == 'y' || status == 'Y')
                        {
                            Track = true;
                            QTrack = false;
                            key++;
                        }

                        else
                        {
                            key++;
                            SelectOption();
                            Track = false;
                            
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        QTrack = true;
                    }
                } while (QTrack);
                
                

            } while (Track);

        }
        //used to create the options
        public void SelectOption()
        {
            
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("                                 Choose The Options!!!!!!!                                            ");
            Console.WriteLine("******************************************************************************************************");
            do
            {
                try
                {
                    Console.WriteLine("1.Add Product\n2.Display\n3.Search Product\n4.SignOut");
                    Option = Convert.ToInt32(Console.ReadLine());
                    OptionTrack = false;
                }
                catch (FormatException ex)
                {
                    OptionTrack = true;
                    Console.WriteLine("Enter Value In Number Format!!!");
                    Console.WriteLine(ex.Message);

                }
            } while (OptionTrack);
            switch (Option)
            {
                case 1:
                    AddProductInList();
                    break;
                case 2:
                    Console.Clear();
                    DisplayData();
                    SelectOption();
                    break;
                case 3:
                    SearchProduct();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Come Back Again!!!!!");
                    SignIn();
                    SessionTracker = false;
                    break;
                default:
                    Console.WriteLine("Please enter the right choice");
                    SelectOption();
                    break;
            }
            
        }
        //used to make the search for the product in the list
        public void SearchProduct()
        {
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("                                 Search Your Product!!!!!!                                            ");
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("Do you want to search product: y/n");
            
            try
            {
                SearchStatus = Convert.ToChar(Console.ReadLine());
                if (SearchStatus == 'y' || SearchStatus == 'Y')
                {
                    WriteTheProduct();
                }
                else
                {
                    SelectOption();

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter correct choice " + ex.Message);
                SearchProduct();                
            }
        }
        //it is used to only display the data
        public void DisplayData()
        {
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("                           Added Product List By The User!!                                           ");
            Console.WriteLine("******************************************************************************************************");
            User us = new User();

            foreach (object obj in arr)
            {
                us = (User)obj;
                Console.WriteLine("Username {0} {1}\tMobile No: {2}\tEmaild Id: {3}", us.FName, us.LName, us.MobileNo, us.EmailId);
            }
            Console.WriteLine("The products are: ");
            AddProduct add = new AddProduct();
            Console.WriteLine("PID\tProduct\tCategory\tPrice\tDescription");
            foreach (object obj in Item)
            {
                add = (AddProduct)obj;
                Console.WriteLine(add.ProductId + "\t" + add.PrName + "\t" + add.PrCategory + "\t" + add.PrPrice + "\t" + add.PrDescription);
            }
            
        }
        //used to write the data as per the search parameter of the user product search
        public void WriteAsIOStream(string pname,string pcategory,float pprice,string pdesc,int quantity)
        {
            FileStream fs = new FileStream(@"D:\CGI.CSharp.MProject\save.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (object obj in arr)
            {
                sw.WriteLine("First Name: {0}\nLast Name: {1}\n",FName,LName);
                sw.WriteLine("Product Name: {0}Category: {1}Price: {2}Description: {3} Quantity: {4}",pname,pcategory,pprice,pdesc,quantity);
                sw.Flush();
                
            }
            sw.Close();
            fs.Close();   
            
            SelectOption();            
        }
        //used to search the product and passing the product as the parameter
        public void WriteTheProduct()
        {
           
            int count = 0;
            Console.WriteLine("Enter the name of the product: ");
            PSearchName = Console.ReadLine();
            AddProduct se = new AddProduct();          
            foreach (object i in Item)
            {
                se=(AddProduct)i;
                if (se.PrName == PSearchName.Trim())
                {
                    count++;                   
                }
               
            }
            if (count == 1)
            {
                Console.Clear();
                Console.WriteLine("Product Found Detail is: " );
                Console.WriteLine("Product: {0}\tCategory: {1}\tPrice: {2}\tDescription: {3}\tQuantity: {4}", PrName, PrCategory, PrPrice, PrDescription,Quantity);
                WriteAsIOStream(PSearchName,PrCategory,PrPrice,PrDescription,Quantity);
            }
            else { Console.WriteLine("Product Not found!!"); SelectOption(); }
             
        }
       

    }
}
