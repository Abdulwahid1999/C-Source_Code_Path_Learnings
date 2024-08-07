using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace practice_coding
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(Product(BrandShoesList.Converse, FranchiseArtist.Dayet));

            Console.WriteLine(AttendanceListGrade10(SectionSchoolOfGrade10.Senon, Grade10Attendance.Miga));
            Console.WriteLine(AttendanceListGrade10(SectionSchoolOfGrade10.Kenon, Grade10Attendance.Ayna));
            Console.WriteLine(AttendanceListGrade10(SectionSchoolOfGrade10.Genon, Grade10Attendance.Olen));
            Console.WriteLine(AttendanceListGrade10(SectionSchoolOfGrade10.Xenon, Grade10Attendance.Markan));

            Console.WriteLine(AttendanceListGrade11(SectionSchoolOfGrade11.Promo, Grade11Attedance.Olanda));
            Console.WriteLine(AttendanceListGrade11(SectionSchoolOfGrade11.Grono, Grade11Attedance.Kapol));
            Console.WriteLine(AttendanceListGrade11(SectionSchoolOfGrade11.Mrono, Grade11Attedance.Miga));
            Console.WriteLine(AttendanceListGrade11(SectionSchoolOfGrade11.Sonon, Grade11Attedance.Mork));
            Console.WriteLine(AttendanceListGrade11(SectionSchoolOfGrade11.Prono, Grade11Attedance.Shan));

            const string soap = "safeguard";
            const string toothpaste = "colgate";
            const string shampoo = "palmolive";
            const string lotion = "SPA-10";

            Console.WriteLine(MarketPriceList(soap));
            Console.WriteLine(MarketPriceList(toothpaste));
            Console.WriteLine(MarketPriceList(shampoo));
            Console.WriteLine(MarketPriceList(lotion));

            var userReadBooks = ReadBooks(BookTypes.ASPNetCoreMVC);
            var userReadBook2 = ReadBooks(BookTypes.Winforms); 
            var userReadBook3 = ReadBooks(BookTypes.Maui); 
            var userReadBook4 = ReadBooks(BookTypes.UnityGame); 

            Console.WriteLine(userReadBooks);
            Console.WriteLine(userReadBook2);
            Console.WriteLine(userReadBook3);
            Console.WriteLine(userReadBook4);

        }

        public static string MarketPriceList(string itemPrice)
        {
            return itemPrice switch
            {
               "safeguard" => $"cost $3.33 of {itemPrice}", 
               "colgate" => $"cost $2.32 of {itemPrice}",
               "palmolive" => $"cost $1.11 of {itemPrice}", 
               "SPA-10" => $"cost $5.04 of {itemPrice}"
            }; 
        }

        public static string ReadBooks(BookTypes books)
        {
            return books switch
            {
                BookTypes.ASPNetCoreMVC => $"ASP.net core MVC it is a concept of Web Development that allow to us to build a massive websites services",
                BookTypes.Maui => $"Maui is a cross platform mobile development that allow us to create different os application", 
                BookTypes.Xamarin => $"Xamarin is the mobile development that allow us to create application on mobile",
                BookTypes.Winforms => $"Winforms it is the desktop Development that allow us to create desktop application on Computer and Laptop",
                BookTypes.UnityGame => $"Unity is the Game Engine that allow us to create Games 2d and 3d with c# programming language",
                _ => throw new ArgumentNullException($"failed to find a books", nameof(books))
            };
        }

        public enum BookTypes
        {
            ASPNetCoreMVC,
            Maui,
            Xamarin,
            WPF,
            Winforms,
            IOT,
            UnityGame,
        }
        public static string AttendanceListGrade10(SectionSchoolOfGrade10 section, Grade10Attendance studentName) 
            => (section, studentName) switch
        {
            (SectionSchoolOfGrade10.Kenon, Grade10Attendance.Ayna) => $"Attendance of Grade 10 and name:{studentName} and Section:{section}",
            (SectionSchoolOfGrade10.Genon, Grade10Attendance.Olen) => $"Attendance of Grade 10 and name:{studentName} and Section:{section}", 
            (SectionSchoolOfGrade10.Xenon, Grade10Attendance.Markan) => $"Attendance of Grade 10 and name:{studentName} and Section:{section}",
            (SectionSchoolOfGrade10.Menon, Grade10Attendance.Mukasan) => $"Attendance of Grade 10 and name:{studentName} and Section:{section}",
            (SectionSchoolOfGrade10.Senon, Grade10Attendance.Miga) => $"Attendance of Grade 10 and name:{studentName} and Section:{section}",
            _=> throw new ArgumentException($"cannot found information"), 

        };

        public static string AttendanceListGrade11(SectionSchoolOfGrade11 section, Grade11Attedance studentName)
            => (section, studentName) switch
        {
            (SectionSchoolOfGrade11.Grono, Grade11Attedance.Kapol) => $"Attendance of Grade 11 and name:{studentName} and Section:{section}", 
            (SectionSchoolOfGrade11.Prono, Grade11Attedance.Shan) => $"Attendance of Grade 11 and name:{studentName} and Section:{section}", 
            (SectionSchoolOfGrade11.Promo, Grade11Attedance.Olanda) => $"Attendance of Grade 11 and name:{studentName} and Section:{section}",
            (SectionSchoolOfGrade11.Mrono, Grade11Attedance.Miga) => $"Attendance of Grade 11 and name:{studentName} and Section:{section}",
            (SectionSchoolOfGrade11.Sonon, Grade11Attedance.Mork) => $"Attendance of Grade 11 and name:{studentName} and Section:{section}",


        }; 

        public enum SectionSchoolOfGrade10
        {
            Xenon,
            Menon,
            Genon,
            Kenon,
            Penon,
            Senon,
              
        }

        public enum SectionSchoolOfGrade11
        {
            Promo,
            Mrono,
            Grono,
            Krono,
            Prono,
            Sonon,

        }
        public enum Grade10Attendance
        {
            Ayna, 
            Omar,
            Markan,
            Miga,
            Myka,
            Olen,
            Mukasan,
            Oklaw, 
        }

        public enum Grade11Attedance
        {
            Sasa,
            Shan,
            Mork,
            Mun,
            Miga,
            Olanda,
            Kapol, 
        }

        public static string Product(BrandShoesList shoes, FranchiseArtist artist) => (shoes, artist) switch
        {
            (BrandShoesList.Nike or BrandShoesList.NikeSB, FranchiseArtist.Brayan or FranchiseArtist.Wade) => $"Nike Zoom", 
            (BrandShoesList.Addidas, FranchiseArtist.Wade) => $"Addidas Band", 
            (BrandShoesList.Fila, FranchiseArtist.James) => $"Fila Time!!!",
(           (BrandShoesList.Puma, FranchiseArtist.Chris)) => $"Puma Time!!!", 
            (BrandShoesList.UnderArmour, FranchiseArtist.Stephen) => $"Curry Time", 
            (BrandShoesList.Converse, FranchiseArtist.Dayet) => $"Dirty!!!",  
            _ => throw new ArgumentException("invalid brand and artist"), 
        }; 
        
        public enum BrandShoesList
        {
            Nike, 
            NikeSB,
            Addidas, 
            Fila, 
            Puma, 
            UnderArmour, 
            Converse,

        }

        public enum FranchiseArtist
        {
            Brayan, 
            Stephen, 
            James,
            Wade, 
            Chris,
            Dayet
        }
    }
}
