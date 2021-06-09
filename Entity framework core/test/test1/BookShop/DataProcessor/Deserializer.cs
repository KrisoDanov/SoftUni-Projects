namespace BookShop.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using BookShop.Data.Models;
    using BookShop.Data.Models.Enums;
    using BookShop.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedBook
            = "Successfully imported book {0} for {1:F2}.";

        private const string SuccessfullyImportedAuthor
            = "Successfully imported author - {0} with {1} books.";

        public static string ImportBooks(BookShopContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer serializer = new XmlSerializer(typeof(ImportBookDto[])
                , new XmlRootAttribute("Books"));

            using (StringReader stringReader = new StringReader(xmlString))
            {
                ImportBookDto[] bookDtos = (ImportBookDto[])
                    serializer.Deserialize(stringReader);

                List<Book> validBooks = new List<Book>();

                foreach (var bookDto in bookDtos)
                {
                    if (IsValid(bookDto))
                    {
                        sb
                            .AppendLine(ErrorMessage);
                        continue;
                    }

                    DateTime publishedOn;
                    bool IsDateValid = DateTime.TryParseExact(bookDto.PublishedOn, "MM/dd/yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None,
                        out publishedOn);

                    if (!IsDateValid)
                    {
                        sb
                            .AppendLine(ErrorMessage);
                        continue;
                    }

                    Book validBook = new Book()
                    { 
                    Name = bookDto.Name,
                    Genre = (Genre)bookDto.Genre,
                    Price = bookDto.Price,
                    Pages = bookDto.Pages,
                    PublishedOn = publishedOn
                    };

                    validBooks.Add(validBook);

                    sb.AppendLine(String.Format(SuccessfullyImportedBook,
                        validBook.Name, validBook.Price));
                }
                context.Books.AddRange(validBooks);
                context.SaveChanges();
            }
            return sb.ToString().TrimEnd();
        }

        public static string ImportAuthors(BookShopContext context, string jsonString)
        {
            throw new NotImplementedException();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}