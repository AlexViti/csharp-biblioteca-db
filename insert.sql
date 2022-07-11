INSERT INTO book (title, author, [year], plot, age_range)
VALUES
('The Hobbit', 'J.R.R. Tolkien', 1937, 'The Hobbit is a children''s fantasy novel written by English author and scholar J.R.R. Tolkien. It is set in the fictional world of Middle-earth, and the story follows the characters of the Hobbit, Bilbo Baggins, and Gandalf the Grey, as they journey toward the Lonely Mountain to find the One Ring, the only Ring that can be destroyed by the Dark Lord Sauron.', 'All'),
('The Catcher in the Rye, The', 'J.D. Salinger', 1951, 'The Catcher in the Rye is a novel by J.D. Salinger. It was published in 1951 and is considered one of his best works. The novel vividly portrays the life of a working class family in the South of the United States during the Prohibition era.', 'All'),
('The Lord of the Rings, The', 'J.R.R. Tolkien', 1954, 'The Lord of the Rings is a fantasy novel written by English author and scholar J.R.R. Tolkien. It is one of the best-selling novels in English, with over 150 million copies sold, and set in the fictional world of Middle-earth, in the time of the Third Age.', 'All'),
('The Hitchhiker''s Guide to the Galaxy', 'Douglas Adams', 1970,'Something', '18-99');

INSERT INTO genre (name)
VALUES ('Adventure'), ('Fantasy'), ('Sci-fi'), ('Mystery'), ('Thriller'), ('Dystopian'), ('Coming of age');

INSERT INTO book_genre (book_id, genre_id)
VALUES
(1,1),
(1,2),
(2,7),
(3,1),
(3,2),
(4,3);

INSERT INTO condition (name)
VALUES ('New'), ('Used'), ('Very good'), ('Good'), ('Acceptable'), ('Poor');

-- Publisher: Penguin Random House,Hachette Book Group,HarperCollins,Macmillan Publishers,Simon & Schuster
INSERT INTO [copy] (book_id, condition_id, library_code, publisher, [language], isbn, pages)
VALUES
(1, 1, 123, 'Penguin Random', 'English', 1234567890123, 400),
(1, 4, 124, 'Mondadori', 'Italiano', 1234567890125, 350),
(2, 2, 135, 'Hachette Book Group', 'English', 1234567890126, 500),
(2, 3, 136, 'HarperCollins', 'English', 1234567890127, 600),
(3, 6, 137, 'Macmillan Publishers', 'English', 1234567890128, 700),
(3, 5, 138, 'Simon & Schuster', 'English', 1234567890129, 800),
(4, 4, 139, 'Penguin Random', 'English', 1234567890130, 200),
(4, 2, 140, 'Mondadori', 'Italiano', 1234567890131, 400);

INSERT INTO [user] ([name], surname)
VALUES ('Alice', 'Smith'), ('Bob', 'Jones'), ('Charlie', 'Brown'), ('David', 'Williams'), ('Eve', 'Davis'), ('Frank', 'Miller');

INSERT INTO [lent] (copy_id, [user_id], [start], [end])
VALUES
(1, 1, '2022-06-1', '2022-06-2'),
(2, 2, '2022-06-3', '2022-06-16'),
(3, 3, '2022-06-5', '2022-06-26'),
(4, 4, '2022-06-7', '2022-06-18'),
(5, 5, '2022-06-9', '2022-06-20'),
(6, 6, '2022-07-11', NULL);
