﻿create table books
(
id int not null primary key identity,
author nvarchar(255),
book_name nvarchar(255),
year_published int
);

insert into books(author, book_name, year_published)
values
('Карамзин Н.М.', 'Бедная Лиза', 1792 ),
('Карамзин Н.М.', 'История государства Российского', 1815),
('Пелевин В.О.', 'Чапаев и Пустота', 1996),
('Пелевин В.О.', 'Омон Ра', 1992 ),
('Пушкин А.С.', 'Капитанская дочка', 1841),
('Пушкин А.С.', 'Евгений Онегин', 1833),
('Джеффри Рихтер', 'CLR via C# 4-е издание',2021 ),
('Тургенев И.С.', 'Отцы и дети', 1860),
('Пелевин В.О.', 'Жизнь насекомых', 1993),
('Энтони Берджесс', 'Заводной апельсин', 1962);