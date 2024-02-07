using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOrder
{
    public class Login
    {
        public int ID { get; set; }
        public long MobileNumber { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public int OTP { get; set; }
    }

    public class SignUp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string EmailID {  get; set; }
        public string CountryName {  get; set; }
        public string Password { get; set; }
        public int OTP { get; set; }

    }

    public class ForgotPassword
    {
        public int ID { get; set; }
        public long MobileNumber { get; set; }
        public string EmailID { get; set; }

        public string Password { get; set; }
        public int OTP { get; set; }
    }

    public class ChangePassword
    {
        public string OldPassword { get; set; }
        public string CPassword { get; set; }
    
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCategoryID { get; set;}
        public string ProductCategoryName { get; set;}
        public string ProductCategoryDescription { get; set;}
        public float ProductPrice { get; set; }
        public int ProductQuantity {  get; set; }
        public decimal Discount { get; set; }
        public bool IsProductAvailable { get; set; }

    }

    public class AddToCart
    {
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int ProductQuantity { get; set;}
    }

    public class PriceDetails
    {
        public decimal TotalProductPrice { get; set; }
        public decimal DeliveryCharge {  get; set; }
        public decimal TotalAmount {  get; set; }
    }

    public class DeliveryAddress
    {
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string PinCode { get; set; }
        public long PhoneNumber { get; set; }
        
    }

    public class Payments
    {
        public string Options { get; set; }
    }
    public enum CPassword
    {
        NewPassword,
        ConfirmPassword,
    }
    public enum ProductCategoryName
    {
        Baby_Product,
        BeautyAndPersonalCare,
        BooksAndNewsPaper,
        Clothing,
        Electronics,
        ExerciseAndFitnesssupplies,
        Groceries,
        HomeAndKitchen,
        OfficeSupplies,
        PetSupplies,
        ToyAndGames
    }
    public enum Options 
    {
        UPI,
        Wallet,
        PostPaid,
        Credit,Debit,ATMCard,
        NetBanking,
        EMI,
        CashOnDelivery
    }
}
//internal class Program
//{
//    static void Main(string[] args)
//    {
//    }
//}