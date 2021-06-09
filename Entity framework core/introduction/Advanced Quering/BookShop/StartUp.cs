namespace BookShop
{
    using BookShop.Models;
    using Data;
    using Initializer;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);
            string comand = Console.ReadLine().ToLower();

            Console.WriteLine(GetTotalProfitByCategory(db));

        }
        public static string GetBooksByPrice(BookShopContext context, string command)
        {
            StringBuilder sb = new StringBuilder();

            List<string> bookTitle = context
                .Books
                .ToList()
                .Where(x => x.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToList();

            return string.Join(Environment.NewLine, bookTitle );
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            List<string> goldenEditionTitles = context.
                Books
                .Where(x => x.Copies < 5000)
                .OrderBy(x => x.BookId)
                .Select(x => x.Title)
                .ToList();

            return string.Join(Environment.NewLine, goldenEditionTitles);
        }

        //public static string GetBooksByPrice(BookShopContext context)
        //{
        //    var titleAndPrive = context.Books
        //        .Select(x => new
        //        {
        //            Author = x.Author,
        //            Price = x.Price,

        //        })
        //        .Where(x => x.Price > 40)
        //        .OrderByDescending(x => x.Price)
        //        .ToList();
        //     foreach (var item in titleAndPrive)
        //    {
        //        return $"{item.Author} - ${item.Price}";
        //    }

        //}

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            List<string> titleOfBooks = context.Books
                .Where(x => x.ReleaseDate.Value.Year != year)
                .OrderBy(x => x.BookId)
                .Select(x => x.Title)
                .ToList();

            return string.Join(Environment.NewLine, titleOfBooks);
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input
                .Split(' ')
                .Select(x => x.ToLower())
                .ToArray();

            List<string> bookTitles = new List<string>();

            foreach (var cat in categories)
            {
                List<string> currBookTitle = context
                    .Books
                    .Where(x => x.BookCategories.Any(x =>
                    x.Category.Name.ToLower() == cat))
                    .Select(x => x.Title)
                    .ToList();

                bookTitles.AddRange(currBookTitle);

            }
            bookTitles = bookTitles
                .OrderBy(x => x)
                .ToList();

            return string.Join(Environment.NewLine, bookTitles);
        }
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            List<string> title = context
                .Books
                .Where(x => x.Title.ToLower().Contains(input))
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToList();

            return string.Join(Environment.NewLine, title);
        }
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var authorCopies = context.
                Authors
                .Select(x => new
                {
                    FullName = x.FirstName + ' ' + x.LastName,
                    BookCopies = x.Books.Sum(x => x.Copies)
                })
                .OrderByDescending(x => x.BookCopies)
                .ToList();

            foreach (var a in authorCopies)
            {
                sb.AppendLine($"{a.FullName} - {a.BookCopies}");
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var totalProfit = context
                .Books
                .Select(x => new
                {
                    cat = x.BookCategories,
                    profit = x.Price * x.Copies

                })
                .OrderByDescending(x => x.profit)
                .ThenBy(x => x.cat)
                .ToList();

            foreach (var item in totalProfit)
            {
                sb.AppendLine($"{item.cat}${item.profit}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}
