﻿using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    public class ImplementSQL
    {
        //This function creates the tables and inserts a sample menu into your database.
        // Before you run, ensure that you've filled out the correct SQL login information in Windows.cs
        // Make sure that you have comment out the main function in Program.cs. 
        // Then uncomment the static void main function here.

        //--------------------------------------------------------------------------------------------------------------
        
        //Comment begin here!
        
        // static void Main()
        // {
        //     MySqlConnection conn =
        //         new MySqlConnection("SERVER=" + HotPlateData.SQLServer + ";DATABASE=" + HotPlateData.SQLDatabaseName + 
        //                             ";UID=" + HotPlateData.SQLusername + ";PASSWORD=" + HotPlateData.SQLPassword + ";");
        //     conn.Open();
        //     createTable(conn);
        //     insertSampleMenu(conn);
        //     //deleteEverything(conn);
        // }
        
        // Comment ends here!
        
        
        //--------------------------------------------------------------------------------------------------------------
        
        
        // Creates two tables in your mySQL database. 
        // foodtable - Stores all the menu items
        //      - Category: Stores the category of the item (Burger: "b", Chicken: "c")
        //      - ID: Stores a unique ID for the item (Primary Key)
        //      - Title: Name of the item
        //      - Price: Price of the item
        //      - Picture: Name reference to the picture stored in the Resources folder. 
        // ordertable - Stores all customer's orders
        //      - Confirmation ID: A unique ID generated by GUID (Primary Key)
        //      - CustomerName: User's full name
        //      - Total: The grand total the customer had paid
        //      - Time: The time when the customer submitted their order.
        //      - Address: The customer's address
        //      - Email: Customer's email
        //      - Phone: Customer's Phone number
        //      - Order: The list of items the customer had ordered
        static void createTable(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand("CREATE TABLE `foodtable` (" +
                                                "`category` varchar(30) NOT NULL," +
                                                "`ID` varchar(45) NOT NULL," +
                                                "`title` varchar(45) NOT NULL," +
                                                "`price` varchar(45) NOT NULL," +
                                                "`picture` varchar(100) NOT NULL," +
                                                "PRIMARY KEY (`ID`));", conn);
            cmd.ExecuteNonQuery();

            cmd = new MySqlCommand("CREATE TABLE `ordertable` (" +
                                   "`Confirmation ID` varchar(40) NOT NULL," +
                                   "`CustomerName` varchar(45) NOT NULL," +
                                   "`Total` varchar(10) NOT NULL," +
                                   "`Time` varchar(45) NOT NULL," +
                                   "`Address` varchar(200) NOT NULL," +
                                   "`Email` varchar(100) NOT NULL," +
                                   "`Phone` varchar(12) NOT NULL," +
                                   "`Order` varchar(500) NOT NULL," +
                                   "PRIMARY KEY (`Confirmation ID`));", conn);

            cmd.ExecuteNonQuery();
        }
        
        //--------------------------------------------------------------------------------------------------------------
        // Deletes the two tables and all the data
        static void deleteEverything(MySqlConnection conn)
        {
            (new MySqlCommand("DROP TABLE foodtable;", conn))
                .ExecuteNonQuery();
            (new MySqlCommand("DROP TABLE ordertable;", conn))
                .ExecuteNonQuery();
        }

        //--------------------------------------------------------------------------------------------------------------
        // Inserts a sample menu to foodtable.
        static void insertSampleMenu(MySqlConnection conn)
        {
            
            //Burgers
            (new MySqlCommand(
                    "INSERT INTO foodtable VALUES ('b','1','Hamburger','5.30','hamburger')",
                    conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('b','2','Cheese Burger','6.30','cheeseBurger')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('b','3','Double Cheese Burger','7.00','doubleCheeseBurger')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('b','4','HotPlate Original Burger','8.50','hotplateCheeseBurger')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('b','5','BBQ Cheese Burger','7.40','bbqCheeseBurger')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('b','6','Breakfast Burger','6.40','breakfastBurger')",
                conn)).ExecuteNonQuery();
            
            //Chicken
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('c','7','Fried Chicken Burger','7.50','chickenBurger')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('c','8','BBQ Texas Chicken','9.50','bbqChickenBurger')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('c','9','Grilled Chicken Burger','5.50','grilledChickenBurger')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('c','10','Santa Fe Chicken Burger','6.00','santaFeChickenBurger')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('c','11','Chicken Bites','5.20','chickenBites')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('c','12','Chicken Tenders','8.10','chickenTenders')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('c','13','Popcorn Chicken','6.40','popcornChicken')",
                conn)).ExecuteNonQuery();
            
            //Sides
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('s','14','French Fries','3.50','frenchFries')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('s','15','Sweet Potato Fries','4.40','sweetPotatoFries')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('s','16','Tater Tots','4.00','taterTots')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('s','19','Fried Pickles','4.80','friedPickles')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('s','18','5 Original Dippers','4.00','dipper')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('s','17','Coleslaw','3.00','coleslaw')",
                conn)).ExecuteNonQuery();
            
            //Drinks
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('d','33','Cocacola','2.00','coke')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('d','20','Diet Coke','2.00','dietCoke')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('d','21','Dr.Pepper','2.00','drPepper')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('d','22','Root Beer','2.00','rootBeer')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('d','23','Sprite','2.00','sprite')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('d','24','Chocolate Shake','5.00','chocolateMilkShake')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('d','25','Vanilla Shake','5.00','vanillaMilkShake')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('d','26','Strawberry Shake','5.00','strawberryMilkShake')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('d','27','Hotplate Lucky Shake','5.00','mintMilkShake')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('d','28','Coffee','4.50','coffee')",
                conn)).ExecuteNonQuery();
            
            //Desserts
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('de','29','Hershey Cake','5.00','hersheyCake')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('de','30','HotPlate Lucky Cake','5.00','mintCake')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('de','31','Oreo Cake','5.00','oreoCake')",
                conn)).ExecuteNonQuery();
            (new MySqlCommand(
                "INSERT INTO foodtable VALUES ('de','32','Soft Served Ice Cream','2.00','softServeIceCream')",
                conn)).ExecuteNonQuery();
        }
        //--------------------------------------------------------------------------------------------------------------
    }
}