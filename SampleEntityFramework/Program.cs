﻿using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {

            //InsertBooks();
            //AddAuthors();
            //AddBooks();
            //UpdateBook();


            Console.WriteLine("# 1.1");
            Exercise13_1_1();

            Console.WriteLine("# 1.2");
            foreach (var book in Exercise13_1_2()) {
                Console.WriteLine($"{book.Title} {book.PublishedYear} " +
                    $"{book.Author.Name} {book.Author.Birthday}");
            }

            Console.WriteLine();

            Console.WriteLine("# 1.3");
            Exercise13_1_3();

            Console.WriteLine("# 1.4");
            Exercise13_1_4();

            Console.WriteLine("# 1.5");
            Exercise13_1_5();

            Console.ReadLine();
        }

        private static void Exercise13_1_1() {
            using (var db = new BooksDbContext()) {

                var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1,
                };
                db.Books.Add(book1);


                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author2,
                };
                db.Books.Add(book2);


                var book5 = new Book {
                    Title = "真珠婦人",
                    PublishedYear = 2002,
                    Author = new Author {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛",
                    }
                };
                db.Books.Add(book5);


                var book3 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成",
                    }
                };
                db.Books.Add(book3);
                db.SaveChanges();
            }
        }

        private static IEnumerable<Book> Exercise13_1_2() {
            using (var db = new BooksDbContext()) {
                return db.Books.Include(nameof(Author)).ToList();
            }
        }

        private static void Exercise13_1_3() {
            using (var db = new BooksDbContext()) {
                var author = db.Books.Where(s => s.Title.Length == db.Books.Max(a => a.Title.Length));
                foreach (var book in author) {
                    Console.WriteLine($"{book.Title}");
                }
                Console.WriteLine();
            }
        }

        private static void Exercise13_1_4() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.OrderBy(s => s.PublishedYear).Take(3);
                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.Author.Name} ");
                }
                Console.WriteLine();
            }
        }

        private static void Exercise13_1_5() {
            using (var db = new BooksDbContext()) {
                var authors = db.Authors.OrderByDescending(s => s.Birthday);
                foreach (var author in authors) {
                    foreach (var book in author.Books) {
                        Console.WriteLine($"{book.Title} {book.PublishedYear}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }











        private static void DeleteBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if (book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }

        private static void UpdateBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();

            }
        }

        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();
            }
        }

        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach (var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine();
        }

        
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);

                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }
        }

        
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }
    }
}