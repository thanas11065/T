﻿using System;
public class Program
{
    public static void Main(string[] args)
    { 
      FlightData flightData = new FlightData();
      Payment payment = new Payment();
      Reserve reserve = new Reserve();
    }
    public static void ChooseLoginOrSignUp()
    {
        Console.Clear();
        Console.WriteLine("   *==Wellcome==*");
        Console.WriteLine("");
        Console.WriteLine("   Please Select");
        Console.WriteLine("-+-------------------");
        Console.WriteLine("1| Login");
        Console.WriteLine("2| Signup");
        Console.WriteLine("-+-------------------");
        InputType();
    }
    public static void InputType()
{
        Console.WriteLine("Input Type: ");
        for(int i = 0; i  <= 0;)
    {
        int Type = int.Parse(Console.ReadLine());
        if(Type == 1)
        {
          // Test
          Console.WriteLine("1");
        }
        else if (Type == 2)
        {
          // Test
          Console.WriteLine("2");
        }
        else
        {
        Console.WriteLine("Try Again!!");
        }
    }
    BlackToMenu();
}
static void BackToMenu()
    {
        Console.Clear();
        ChooseLoginOrSignUp();
    }
    public static void ShowLoginUI()
    {
        Console.Clear();
        Console.WriteLine(" ----Login----");
        Console.WriteLine("--------------------");
        Console.WriteLine(" Username: ");
        Console.WriteLine(" Password: ");
        Console.WriteLine("--------------------");
    }
    public static void ShowSignUpUI()
    {
        Console.Clear();
        Console.WriteLine(" ----SignUp----");
        Console.WriteLine("--------------------");
        Console.WriteLine(" Username: ");
        Console.WriteLine(" Password: ");
        Console.WriteLine("--------------------");
    }
    public static void ShowReserveUI()
    {
    Console.Clear();
    Console.WriteLine(" Payment List ");
    Console.WriteLine("--------------------");
    }
     public static void ShowPaymentUI()
    {
        Console.Clear();
        Console.WriteLine(" Payment List ");
        Console.WriteLine("--------------------");
        Program.payment.CalcPrice();
        Console.ReadLine();
        Console.WriteLine("Input any key to back to menu.");
        BackToMenu();
       
    }


}